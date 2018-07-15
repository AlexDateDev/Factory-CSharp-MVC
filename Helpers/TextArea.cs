// ----------------------------------------------------------------------------
// T�tulo:    TextArea
//
// Fecha:     04/07/2016
// Autor:    Alex Sol�
// ----------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using System.Web.Routing;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace System.Web.Mvc.Html
{
	public static partial class MvcHtmlExtensions
	{
		/// <summary>
		/// Text Area
		/// El title y el maxlenght se obtiene del Metadata
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="htmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="NumRows"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextAreaFor<TModel, TValue>(
			this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, TValue>> expression,
			int NumRows,    // Obligatorio
			string sClass = null,
			object HtmlAttributes = null )
		{
			if( NumRows < 1 ) {
				throw new ArgumentNullException( "NumRows" );
			}
			ModelMetadata metadata = ModelMetadata.FromLambdaExpression( expression, htmlHelper.ViewData );

			RouteValueDictionary routeValues = new RouteValueDictionary( HtmlAttributes );
			if( !string.IsNullOrEmpty( metadata.Description ) ) {
				routeValues.Add( "title", metadata.Description );
			}

			// Obtenemos la información utilizada para validar el tamaño del texto
			ControllerContext cctx = htmlHelper.ViewContext.Controller.ControllerContext;
			StringLengthAttributeAdapter stringLengthValidator = metadata.GetValidators( cctx )
																.OfType<StringLengthAttributeAdapter>( )
																.FirstOrDefault( );

			if( stringLengthValidator != null ) {                                               // Si hay validación de este tipo...
				var parms = stringLengthValidator.GetClientValidationRules( )
												 .First( )
												 .ValidationParameters;
				// Obtenemos el valor
				int maxlength = (int) parms[ "max" ]; // tamaño máximo para el texto...

				routeValues.Add( "maxlength", maxlength );  // y añadimos el atributo maxlength
				routeValues.Add( "onkeyup", "return EVENT.onTextAreaMaxLen(this)" );
			}
			routeValues.Add( "rows", Convert.ToString( NumRows ) );

			if( !string.IsNullOrEmpty( sClass ) ) {
				routeValues.Add( "class", sClass );
			}

			return Html.TextAreaExtensions.TextAreaFor( htmlHelper, expression, routeValues );
		}

		/// <summary>
		///
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="htmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="Title"></param>
		/// <param name="MaxLength"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextAreaFor<TModel, TValue>(
			this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, TValue>> expression,
			string Title,    // Obligatorio
			int MaxLength,    // Obligatorio (-1 => Sin longitud)
			int NumRows,    // Obligatorio
			string sClass = null,
			object HtmlAttributes = null )
		{
			if( string.IsNullOrEmpty( Title ) ) {
				throw new ArgumentNullException( "Title" );
			}
			if( MaxLength == 0 || MaxLength < -1 ) {
				throw new ArgumentNullException( "MaxLength" );
			}
			if( NumRows < 1 ) {
				throw new ArgumentNullException( "NumRows" );
			}
			RouteValueDictionary routeValues = new RouteValueDictionary( HtmlAttributes );

			routeValues.Add( "title", Title );
			if( MaxLength != -1 ) {
				routeValues.Add( "maxlength", MaxLength );
				routeValues.Add( "onkeyup", "return EVENT.onTextAreaMaxLen(this)" );
			}

			if( !string.IsNullOrEmpty( sClass ) ) {
				routeValues.Add( "class", sClass );
			}

			return Html.TextAreaExtensions.TextAreaFor( htmlHelper, expression, routeValues );
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="htmlHelper"></param>
		/// <param name="Name"></param>
		/// <param name="Id"></param>
		/// <param name="Title"></param>
		/// <param name="MaxLength"></param>
		/// <param name="NumRows"></param>
		/// <param name="Value"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextArea(
			this HtmlHelper htmlHelper,
			string Name,    // Obligatorio
			string Id,        // Obligatorio
			string Title,    // Obligatorio
			int MaxLength,    // Obligatorio (-1 => Sin longitud)
			int NumRows,    // Obligatorio
			string Value = null,    // No obligatorio
			string sClass = null,
			object HtmlAttributes = null )
		{
			if( string.IsNullOrEmpty( Id ) ) {
				throw new ArgumentNullException( "Id" );
			}
			if( string.IsNullOrEmpty( Name ) ) {
				throw new ArgumentNullException( "Name" );
			}
			if( string.IsNullOrEmpty( Title ) ) {
				throw new ArgumentNullException( "Title" );
			}
			if( MaxLength == 0 || MaxLength < -1 ) {
				throw new ArgumentNullException( "MaxLength" );
			}
			if( NumRows < 1 ) {
				throw new ArgumentNullException( "NumRows" );
			}

			TagBuilder html = new TagBuilder( "textarea" );

			//html.GenerateId( Id );
			html.MergeAttribute( "id", Id );
			html.MergeAttribute( "name", Name );
			html.MergeAttribute( "title", Title );
			html.MergeAttribute( "rows", Convert.ToString( NumRows ) );

			if( MaxLength != -1 ) {
				html.MergeAttribute( "maxlength", Convert.ToString( MaxLength ) );
				html.MergeAttribute( "onkeyup", "return EVENT.onTextAreaMaxLen(this)" );
			}

			if( !string.IsNullOrEmpty( sClass ) ) {
				html.MergeAttribute( "class", sClass );
			}

			html.MergeAttributes( new RouteValueDictionary( HtmlAttributes ) );
			if( !string.IsNullOrEmpty( Value ) ) {
				html.InnerHtml = Value;
			}

			return MvcHtmlString.Create( html.ToString( ) );
		}

	}

}
