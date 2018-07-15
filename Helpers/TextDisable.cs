// ----------------------------------------------------------------------------
// Título:    TextDisable
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
		public static MvcHtmlString HelpTextDissable( this HtmlHelper helper,
			string Text,
			object HtmlAttributes = null )
		{

			if( !string.IsNullOrEmpty( Text ) ) {
				var container = new TagBuilder( "p" );
				container.AddCssClass( "disable" );

				container.MergeAttributes( new RouteValueDictionary( HtmlAttributes ) );
				container.InnerHtml += Text;
				return MvcHtmlString.Create( container.ToString( ) );
			}
			return MvcHtmlString.Create( "" );

		}

	}

}
