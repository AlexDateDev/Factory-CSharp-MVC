// ----------------------------------------------------------------------------
// T�tulo:    InputTextBoxNumeric
//
// Fecha:     04/07/2016
// Autor:    Alex Sol�
// ----------------------------------------------------------------------------


using System;
using System.Linq.Expressions;
using System.Web.Routing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace System.Web.Mvc.Html
{
	public static partial class MvcHtmlExtensions
	{

		/// <summary>
		///
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="htmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="title"></param>
		/// <param name="maxLength"></param>
		/// <param name="sClass"></param>
		/// <param name="htmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpInputNumericFor<TModel, TValue>(
			this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, TValue>> expression,
			string title,    // Obligatorio
			int? maxLength = null,    // null => Sin longitud)
			int? maxValue = null,
			int? minValue = null,
			int? stepValue = null,
			string sClass = null,
			object htmlAttributes = null )
		{
			if( string.IsNullOrEmpty( title ) ) {
				throw new ArgumentNullException( "Title" );
			}
			if( maxLength == 0 || maxLength < -1 ) {
				throw new ArgumentNullException( "MaxLength" );
			}

			RouteValueDictionary oHtmlAttributes = new RouteValueDictionary( htmlAttributes );
			oHtmlAttributes.Add( "title", title );
			if( maxLength > -1 && null!=maxLength) {
				oHtmlAttributes.Add( "onKeyDown", "return EVENT.MaxLengthNumbers(event," + maxLength + ", this)" );
			}
			oHtmlAttributes.Add( "type", "number" );
			if( null != maxValue) {
				oHtmlAttributes.Add( "max", maxValue );
			}
			if( null != minValue ) {
				oHtmlAttributes.Add( "min", minValue );
			}
			if( null != stepValue ) {
				oHtmlAttributes.Add( "step", stepValue  );
			}

			if( !string.IsNullOrEmpty( sClass ) ) {
				oHtmlAttributes.Add( "class", sClass );
			}

			return Html.InputExtensions.TextBoxFor( htmlHelper, expression, oHtmlAttributes );
		}

		/// <summary>
		///
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="htmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpInputNumericFor<TModel, TValue>(
			this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, TValue>> expression,
			string sClass = null,
			object HtmlAttributes = null )
		{
			RouteValueDictionary routeValues = new RouteValueDictionary( HtmlAttributes );

			ModelMetadata metadata = ModelMetadata.FromLambdaExpression( expression, htmlHelper.ViewData );

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
			}

			routeValues.Add( "onkeypress", "F.Validate.Event.PressOnlyNumbers(event)" );

			if( !string.IsNullOrEmpty( sClass ) ) {
				routeValues.Add( "class", sClass );
			} else {
				routeValues.Add( "class", "Helper-InputTextBoxNumeric" );
			}

			return Html.InputExtensions.TextBoxFor( htmlHelper, expression, routeValues );
		}


		/// <summary>
		/// Input text de un campo numérico de una entidad
		/// El valor numerico se guarda en un campo string
		/// </summary>
		/// <param name="htmlHelper"></param>
		/// <param name="Name"></param>
		/// <param name="Id"></param>
		/// <param name="Title"></param>
		/// <param name="MaxLength"></param>
		/// <param name="Value"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpInputNumeric( this HtmlHelper htmlHelper,
			string Name,    // Obligatorio
			string Id,        // Obligatorio
			string Title,    // Obligatorio
			int MaxLength,    // Obligatorio (-1 => Sin longitud)
			string Value = null,
			string sClass = null,
			object HtmlAttributes = null )
		{
			if( string.IsNullOrEmpty( Name ) ) {
				throw new ArgumentNullException( "Name" );
			}
			if( string.IsNullOrEmpty( Id ) ) {
				throw new ArgumentNullException( "Id" );
			}

			if( string.IsNullOrEmpty( Title ) ) {
				throw new ArgumentNullException( "Title" );
			}
			if( MaxLength == 0 || MaxLength < -1 ) {
				throw new ArgumentNullException( "MaxLength" );
			}

			TagBuilder html = new TagBuilder( "input" );

			html.MergeAttribute( "type", "text" );
			html.MergeAttribute( "id", Id );
			html.MergeAttribute( "name", Name );
			html.MergeAttribute( "title", Title );
			html.MergeAttribute( "onkeypress", "F.Validate.Event.PressOnlyNumbers(event)" );

			if( MaxLength != -1 ) {
				html.MergeAttribute( "maxlength", Convert.ToString( MaxLength ) );
			}
			if( !string.IsNullOrEmpty( Value ) ) {
				html.MergeAttribute( "value", Value );
			}

			if( !string.IsNullOrEmpty( sClass ) ) {
				html.MergeAttribute( "class", sClass );
			} else {
				html.MergeAttribute( "class", "Helper-InputTextBoxNumeric" );
			}

			html.MergeAttributes( new RouteValueDictionary( HtmlAttributes ) );

			return MvcHtmlString.Create( html.ToString( ) );
		}

		/// <summary>
		/// Sirve para int y int?
		/// </summary>
		/// <param name="htmlHelper"></param>
		/// <param name="Name"></param>
		/// <param name="Id"></param>
		/// <param name="Title"></param>
		/// <param name="MaxLength"></param>
		/// <param name="ValueInt"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		///

		public static MvcHtmlString HelpInputNumeric( this HtmlHelper htmlHelper,
			string Name,    // Obligatorio
			string Id,        // Obligatorio
			string Title,    // Obligatorio
			int MaxLength,    // Obligatorio (-1 => Sin longitud)
			int? ValueInt,
			string sClass = null,
			object HtmlAttributes = null )
		{
			string sValue = ( null == ValueInt ) ? "" : Convert.ToString( ValueInt.Value );
			return HelpInputNumeric( htmlHelper,
								Name,
								Id,
								Title,
								MaxLength,
								sValue,
								sClass,
								HtmlAttributes );
		}

	}
}
