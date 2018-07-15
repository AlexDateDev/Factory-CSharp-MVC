// ----------------------------------------------------------------------------
// Título:    TextTruncate
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
		/// Trunca un string a una longitud determinada. Def=10
		/// </summary>
		/// <param name="helper"></param>
		/// <param name="Value"></param>
		/// <param name="len"></param>
		/// <param name="Fill"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextTruncate( this HtmlHelper helper,
			string Value,
			int? len = 10,
			string Fill = null
			)
		{
			if( string.IsNullOrEmpty( Value ) ) {
				return MvcHtmlString.Empty;
			}
			if( string.IsNullOrEmpty( Fill ) ) {
				Fill = "...";
			}
			if( Value.Length <= len ) {
				return MvcHtmlString.Create( Value );
			} else {
				return MvcHtmlString.Create( Value.Substring( 0, len.Value ) + Fill );
			}
		}
	}

}
