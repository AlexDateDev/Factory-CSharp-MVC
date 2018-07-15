// ----------------------------------------------------------------------------
// T�tulo:    ValidationMessage
//
// Fecha:     04/07/2016
// Autor:    Alex Sol�
// ----------------------------------------------------------------------------

using System;
using System.Linq.Expressions;

namespace System.Web.Mvc.Html
{
	public static partial class MvcHtmlExtensions
	{
		/// <summary>
		/// Muestra un mensaje procedente dela validaciÃ³n del servidor
		/// Se pone dentro de un pÃ¡rrafo <p></p>
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TProperty"></typeparam>
		/// <param name="htmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="validationMessage"></param>
		/// <param name="htmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpValidationMessageFor<TModel, TProperty>( this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, TProperty>> expression,
			string validationMessage = null,
			object htmlAttributes = null )
		{
			string result = null;
			MvcHtmlString normal = htmlHelper.ValidationMessageFor( expression, validationMessage, htmlAttributes );
			if( normal != null ) {
				TagBuilder p = new TagBuilder( "p" );
				p.MergeAttribute( "style", "font-size:15px !important" );
				p.InnerHtml = normal.ToHtmlString( );
				result = p.ToString( TagRenderMode.Normal );
			}
			return MvcHtmlString.Create( result );
		}
	}

}
