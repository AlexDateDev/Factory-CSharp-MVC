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
		private const string _styleViewDataName = "RenderStyle";

		/// <summary>
		/// Función que añade una url al contexto para luego ser añadida por RenderStyles
		/// @Html.AddStyle( "url1")
		/// @Html.AddStyle( "url2")
		/// @Html.AddStyle( "url3")
		/// @Html.RenderStyles()
		/// </summary>
		/// <param name="htmlHelper"></param>
		/// <param name="styleURL"></param>
		public static void HelpAddStyle( this HtmlHelper htmlHelper, string styleURL )
		{
			List<string> styleList = htmlHelper.ViewContext.HttpContext.Items[ HtmlHelperExtensions._styleViewDataName ] as List<string>;

			if( styleList != null ) {
				if( !styleList.Contains( styleURL ) ) {
					styleList.Add( styleURL );
				}
			} else {
				styleList = new List<string>( );
				styleList.Add( styleURL );
				htmlHelper.ViewContext.HttpContext.Items.Add( HtmlHelperExtensions._styleViewDataName, styleList );
			}
		}

		/// <summary>
		/// Crea el código js de los links de las urls de archivos css añadiadas AddStyle y lo vuelca al navegador
		/// </summary>
		/// <param name="htmlHelper"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpRenderStyles( this HtmlHelper htmlHelper )
		{
			StringBuilder result = new StringBuilder( );

			List<string> styleList = htmlHelper.ViewContext.HttpContext.Items[ HtmlHelperExtensions._styleViewDataName ] as List<string>;

			if( styleList != null ) {
				foreach( string script in styleList ) {
					result.AppendLine( string.Format("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", script ) );
				}
			}

			return MvcHtmlString.Create( result.ToString( ) );
		}
	}
}
