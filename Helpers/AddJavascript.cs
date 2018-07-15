// ----------------------------------------------------------------------------
// Título:    AddJavascript
//
// Fecha:     29/06/2015
// Autor:    Alex Solé
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace System.Web.Mvc.Html
{
	public static partial class HtmlHelperExtensions
	{
		private const string _jSViewDataName = "_RenderJavaScript_";

		/// <summary>
		/// Función que añade una url al contexto para luego ser añadida por RenderJavaScripts
		/// @Html.AddJavaScript( "url1")
		/// @Html.AddJavaScript( "url2")
		/// @Html.AddJavaScript( "url3")
		/// @Html.RenderJavaScripts()
		/// </summary>
		/// <param name="htmlHelper"></param>
		/// <param name="scriptURL"></param>
		public static MvcHtmlString HelpAddJavaScript( this HtmlHelper htmlHelper, string scriptURL )
		{
			List<string> scriptList = htmlHelper.ViewContext.HttpContext.Items[ HtmlHelperExtensions._jSViewDataName ] as List<string>;
			if( scriptList != null ) {
				if( !scriptList.Contains( scriptURL ) ) {
					scriptList.Add( scriptURL );
				}
			} else {
				scriptList = new List<string>( );
				scriptList.Add( scriptURL );
				htmlHelper.ViewContext.HttpContext.Items.Add( HtmlHelperExtensions._jSViewDataName, scriptList );
			}
			return null;
		}

		/// <summary>
		/// Crea el código js de los links de las urls javascript añadiadas AddJavaScript y lo vuelca al navegador
		/// </summary>
		/// <param name="HtmlHelper"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpRenderJavaScripts( this HtmlHelper HtmlHelper )
		{
			StringBuilder result = new StringBuilder( );

			List<string> scriptList = HtmlHelper.ViewContext.HttpContext.Items[ HtmlHelperExtensions._jSViewDataName ] as List<string>;
			if( scriptList != null ) {
				foreach( string script in scriptList ) {
					result.AppendLine( string.Format( "<script type=\"text/javascript\" src=\"{0}\"></script>", script ) );
				}
			}

			return MvcHtmlString.Create( result.ToString( ) );
		}

	}
}
