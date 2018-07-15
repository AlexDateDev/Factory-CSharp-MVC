// ----------------------------------------------------------------------------
// Título:    Chekbox
//
// Fecha:     04/07/2016
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using System.Web.Routing;

namespace System.Web.Mvc.Html
{
	public static partial class MvcHtmlExtensions
	{
		/// <summary>
		///	CheckboxFor
		///		Obtiene el título de la descripción del Modelo
		///		Crea el label for del texto de check
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <param name="htmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="value"></param>
		/// <param name="isCheked"></param>
		/// <param name="text"></param>
		/// <param name="tabIndex"></param>
		/// <param name="textAfter"></param>
		/// <param name="sClass"></param>
		/// <param name="htmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpCheckBoxFor<TModel>(
			this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, bool>> expression,
			string value,
			bool isCheked,
			string text,
			int tabIndex = 0,
			bool textAfter = true,
			string sClass = null,
			object htmlAttributes = null
			)
		{
			if( null == value ) {
				throw new ArgumentNullException( "Value" );
			}
			if( string.IsNullOrEmpty( text ) ) {
				throw new ArgumentNullException( "Text" );
			}

			var metaData = ModelMetadata.FromLambdaExpression( expression, htmlHelper.ViewData );

			RouteValueDictionary oHtmlAttributes = new RouteValueDictionary( htmlAttributes );
			if( !string.IsNullOrEmpty( metaData.Description ) ) {
				oHtmlAttributes.Add( "title", metaData.Description );
			}

			if( !string.IsNullOrEmpty( sClass ) ) {
				oHtmlAttributes.Add( "class", sClass );
			}
			if( tabIndex != 0 ) {
				oHtmlAttributes.Add( "tabindex", tabIndex );
			}

			oHtmlAttributes.Add( "value", value );

			var label = new TagBuilder( "label" );
			string htmlFieldName = ExpressionHelper.GetExpressionText( expression );
			label.Attributes.Add( "for", htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldId( htmlFieldName ) );

			if( !string.IsNullOrEmpty( metaData.Description ) ) {
				label.Attributes.Add( "title", metaData.Description );
			}

			label.SetInnerText( text );

			// oHtmlAttributes.Add( "style", "vertical-align:middle" ); Opcional

			if( isCheked ) {
				oHtmlAttributes.Add( "checked", "checked" );
			}

			MvcHtmlString chk = Html.InputExtensions.CheckBoxFor( htmlHelper, expression, oHtmlAttributes );

			if( textAfter ) {
				return MvcHtmlString.Create( chk.ToString( ) + "&nbsp;" + label.ToString( ) );
			} else {
				return MvcHtmlString.Create( label.ToString( ) + "&nbsp;" + chk.ToString( ) );
			}
		}

		/// <summary>
		/// ChekBoxFor
		///		No obtiene ningún valor del Modelo
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TProperty"></typeparam>
		/// <param name="htmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="id"></param>
		/// <param name="title"></param>
		/// <param name="value"></param>
		/// <param name="isCheked"></param>
		/// <param name="text"></param>
		/// <param name="textAfter"></param>
		/// <param name="sClass"></param>
		/// <param name="htmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpCheckBoxFor<TModel, TProperty>(
			this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, TProperty>> expression,
			string id,
			string title,
			string value,
			bool isCheked,
			string text,
			bool textAfter = true,
			string sClass = null,
			object htmlAttributes = null
			)
		{
			string property = ModelMetadata.FromLambdaExpression( expression, htmlHelper.ViewData ).PropertyName;

			if( string.IsNullOrEmpty( id ) ) {
				throw new ArgumentNullException( "Id" );
			}
			if( null == value ) {
				throw new ArgumentNullException( "Value" );
			}
			if( string.IsNullOrEmpty( title ) ) {
				throw new ArgumentNullException( "Title" );
			}
			if( string.IsNullOrEmpty( text ) ) {
				throw new ArgumentNullException( "Text" );
			}

			TagBuilder htmlRadio = new TagBuilder( "input" );
			htmlRadio.MergeAttribute( "type", "checkbox" );
			htmlRadio.MergeAttribute( "style", "vertical-align:middle" );

			htmlRadio.MergeAttribute( "id", id );
			htmlRadio.MergeAttribute( "name", property );
			htmlRadio.MergeAttribute( "title", title );

			if( !string.IsNullOrEmpty( sClass ) ) {
				htmlRadio.MergeAttribute( "class", sClass );
			}
			htmlRadio.MergeAttribute( "value", value );

			htmlRadio.MergeAttributes( new RouteValueDictionary( htmlAttributes ) );

			if( isCheked ) {
				htmlRadio.MergeAttribute( "checked", "checked" );
			}
			string lText = "";
			if( null != text ) {
				lText = "<span>" + text + "</span>";
			}

			if( textAfter ) {
				return MvcHtmlString.Create( htmlRadio.ToString( TagRenderMode.SelfClosing ) + "&nbsp;" + lText );
			} else {
				return MvcHtmlString.Create( lText + "&nbsp;" + htmlRadio.ToString( TagRenderMode.SelfClosing ) );
			}
		}

		/// <summary>
		/// ChekBox
		///		No obtiene ningún valor del Modelo
		/// </summary>
		/// <param name="htmlHelper"></param>
		/// <param name="name"></param>
		/// <param name="id"></param>
		/// <param name="title"></param>
		/// <param name="value"></param>
		/// <param name="isCheked"></param>
		/// <param name="text"></param>
		/// <param name="textAfter"></param>
		/// <param name="sClass"></param>
		/// <param name="htmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpCheckBox(
			this HtmlHelper htmlHelper,
			string name,    // Obligatorio
			string id,        // Obligatorio
			string title,    // Obligatorio
			string value,    // Obligatorio
			bool isCheked,    // Obligatorio
			string text,    // Obligatorio
			bool textAfter = true,
			string sClass = null,
			object htmlAttributes = null)
		{
			if( string.IsNullOrEmpty( name ) ) {
				throw new ArgumentNullException( "Name" );
			}
			if( string.IsNullOrEmpty( id ) ) {
				throw new ArgumentNullException( "Id" );
			}
			if( null == value ) {
				throw new ArgumentNullException( "Value" );
			}
			if( string.IsNullOrEmpty( title ) ) {
				throw new ArgumentNullException( "Title" );
			}
			if( string.IsNullOrEmpty( text ) ) {
				throw new ArgumentNullException( "Text" );
			}

			TagBuilder htmlRadio = new TagBuilder( "input" );
			htmlRadio.MergeAttribute( "type", "checkbox" );
			htmlRadio.MergeAttribute( "style", "vertical-align:top" );

			htmlRadio.MergeAttribute( "id", id );
			htmlRadio.MergeAttribute( "name", name );
			htmlRadio.MergeAttribute( "title", title );

			if( !string.IsNullOrEmpty( sClass ) ) {
				htmlRadio.MergeAttribute( "class", sClass );
			}
			htmlRadio.MergeAttribute( "value", value );

			htmlRadio.MergeAttributes( new RouteValueDictionary( htmlAttributes ) );

			if( isCheked ) {
				htmlRadio.MergeAttribute( "checked", "checked" );
			}
			string lText = "";
			if( null != text ) {
				lText = "<span>" + text + "</span>";
			}
			if( textAfter ) {
				return MvcHtmlString.Create( htmlRadio.ToString( TagRenderMode.SelfClosing ) + "&nbsp;" + lText );
			} else {
				return MvcHtmlString.Create( lText + "&nbsp;" + htmlRadio.ToString( TagRenderMode.SelfClosing ) );
			}
		}
	}

}
