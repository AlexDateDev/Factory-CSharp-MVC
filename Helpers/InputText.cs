// ----------------------------------------------------------------------------
// TÌtulo:    InputTextBox
//
// Fecha:     04/07/2016
// Autor:    Alex SolÈ
// ----------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using System.Web.Routing;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace System.Web.Mvc.Html
{
	public static partial class MvcHtmlExtensions
	{
		/// <summary>
		/// Input text de un campo de una entidad
		/// EL title del input se obtiene del Display Description del Metadata (Si esta definido)
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="htmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="tabIndex"></param>
		/// <param name="readOnly"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpInputTextFor<TModel, TValue>( this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, TValue>> expression,
			int tabIndex = 0,
			bool readOnly = false,
			string sClass = null,
			object HtmlAttributes = null )
		{
			ModelMetadata metadata = ModelMetadata.FromLambdaExpression( expression, htmlHelper.ViewData );

			RouteValueDictionary oHtmlAttributes = new RouteValueDictionary( HtmlAttributes );
			if( !string.IsNullOrEmpty( metadata.Description ) ) {
				oHtmlAttributes.Add( "title", metadata.Description );
			}
			if( tabIndex != 0 && !oHtmlAttributes.ContainsKey( "tabindex" ) ) {
				oHtmlAttributes.Add( "tabindex", tabIndex );
			}
			if( readOnly && !oHtmlAttributes.ContainsKey( "readonly" ) ) {
				oHtmlAttributes.Add( "readonly", "1" );
			}

			// Obtenemos la informaciÛn utilizada para validar el tama√±o del texto
			ControllerContext cctx = htmlHelper.ViewContext.Controller.ControllerContext;
			StringLengthAttributeAdapter stringLengthValidator = metadata.GetValidators( cctx )
																.OfType<StringLengthAttributeAdapter>( )
																.FirstOrDefault( );

			if( stringLengthValidator != null ) {                  // Si hay validaciÛn de este tipo...
				var parms = stringLengthValidator.GetClientValidationRules( )
												 .First( )
												 .ValidationParameters;
				// Obtenemos el valor
				int maxlength = (int) parms[ "max" ]; // tama√±o m√°ximo para el texto...

				oHtmlAttributes.Add( "maxlength", maxlength );  // y a√±adimos el atributo maxlength
			}

			if( !string.IsNullOrEmpty( sClass ) ) {
				oHtmlAttributes.Add( "class", sClass );
			}

			return Html.InputExtensions.TextBoxFor( htmlHelper, expression, oHtmlAttributes );
		}

		/// <summary>
		/// Input text de un campo de una entidad
		///		No obtiene datos de modelo
		/// </summary>
		/// <param name="htmlHelper"></param>
		/// <param name="name"></param>
		/// <param name="id"></param>
		/// <param name="title"></param>
		/// <param name="maxLength"></param>
		/// <param name="value"></param>
		/// <param name="sClass"></param>
		/// <param name="htmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpInputText( this HtmlHelper htmlHelper,
			string name,    // Obligatorio
			string id,        // Obligatorio
			string title,    // Obligatorio
			int maxLength,    // Obligatorio (-1 => Sin longitud)
			string value = null,
			string sClass = null,
			object htmlAttributes = null )
		{
			if( string.IsNullOrEmpty( name ) ) {
				throw new ArgumentNullException( "Name" );
			}
			if( string.IsNullOrEmpty( id ) ) {
				throw new ArgumentNullException( "Id" );
			}

			if( string.IsNullOrEmpty( title ) ) {
				throw new ArgumentNullException( "Title" );
			}
			if( maxLength == 0 || maxLength < -1 ) {
				throw new ArgumentNullException( "MaxLength" );
			}
			TagBuilder html = new TagBuilder( "input" );

			html.MergeAttribute( "type", "text" );
			html.MergeAttribute( "id", id );
			html.MergeAttribute( "name", name );

			html.MergeAttribute( "title", title );
			if( maxLength != -1 ) {
				html.MergeAttribute( "maxlength", Convert.ToString( maxLength ) );
			}

			if( !string.IsNullOrEmpty( sClass ) ) {
				html.MergeAttribute( "class", sClass );
			}
			if( !string.IsNullOrEmpty( value ) ) {
				html.MergeAttribute( "value", value );
			}

			html.MergeAttributes( new RouteValueDictionary( htmlAttributes ) );

			return MvcHtmlString.Create( html.ToString( ) );
		}

		/// <summary>
		/// Input text de un campo de una entidad
		///		No obtiene datos de modelo
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="HtmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="title"></param>
		/// <param name="maxLength"></param>
		/// <param name="sClass"></param>
		/// <param name="htmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpInputTextFor<TModel, TValue>(
			this HtmlHelper<TModel> HtmlHelper,
			Expression<Func<TModel, TValue>> expression,
			string title,    // Obligatorio
			int maxLength,    // Obligatorio (-1 => Sin longitud)
			string sClass = null,
			object htmlAttributes = null )
		{
			if( string.IsNullOrEmpty( title ) ) {
				throw new ArgumentNullException( "Title" );
			}
			if( maxLength == 0 || maxLength < -1 ) {
				throw new ArgumentNullException( "MaxLength" );
			}
			RouteValueDictionary routeValues = new RouteValueDictionary( htmlAttributes );
			routeValues.Add( "title", title );

			if( maxLength != -1 ) {
				routeValues.Add( "maxlength", maxLength );
			}
			if( !string.IsNullOrEmpty( sClass ) ) {
				routeValues.Add( "class", sClass );
			}

			return Html.InputExtensions.TextBoxFor( HtmlHelper, expression, routeValues );
		}


		
	}

}
