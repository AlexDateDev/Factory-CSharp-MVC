// ----------------------------------------------------------------------------
// Título:    TextObligatory
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
		///
		/// </summary>
		/// <param name="helper"></param>
		/// <param name="Text"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextObligatory( this HtmlHelper helper,
			string Text = null,
			object HtmlAttributes = null )
		{
			if( string.IsNullOrEmpty( Text ) ) {
				Text = "Campo obligatorio";
			}
			var container = new TagBuilder( "p" );
			container.AddCssClass( "obligatory" );

			container.MergeAttributes( new RouteValueDictionary( HtmlAttributes ) );

			container.InnerHtml += Text;
			return MvcHtmlString.Create( container.ToString( ) );
		}
	}
}
