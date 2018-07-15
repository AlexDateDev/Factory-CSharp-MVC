// ----------------------------------------------------------------------------
// Título:    TextBooleanYesNo
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
		///
		/// </summary>
		/// <param name="helper"></param>
		/// <param name="Val"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextYesNo( this HtmlHelper helper,
			bool? Val,
			string sClass = null,
			object HtmlAttributes = null )
		{

			var container = new TagBuilder( "p" );

			if( !string.IsNullOrEmpty( sClass ) ) {
				container.AddCssClass( sClass );
			}

			container.MergeAttributes( new RouteValueDictionary( HtmlAttributes ) );

			if( null == Val ) {
				container.InnerHtml = "&nbsp;";
			} else if( Val.Value ) {
				container.InnerHtml = "Sí";
			} else {
				container.InnerHtml = "No";
			}

			return MvcHtmlString.Create( container.ToString( ) );
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="helper"></param>
		/// <param name="Value"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextYesNo( this HtmlHelper helper,
			bool Value,
			string sClass = null,
			object HtmlAttributes = null )
		{
			var container = new TagBuilder( "p" );

			if( !string.IsNullOrEmpty( sClass ) ) {
				container.AddCssClass( sClass );
			}

			container.MergeAttributes( new RouteValueDictionary( HtmlAttributes ) );

			if( Value ) {
				container.InnerHtml = "Sí";
			} else {
				container.InnerHtml = "No";
			}

			return MvcHtmlString.Create( container.ToString( ) );
		}
	}

}
