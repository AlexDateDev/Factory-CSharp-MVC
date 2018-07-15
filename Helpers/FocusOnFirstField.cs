using System;
using System.Linq;
using System.Web.Mvc;

namespace System.Web.Mvc.Html
{
	public static class HtmlExtensions
	{
		/// <summary>
		/// Pone el cursor (focos) en el primer input de la página o en el primer error si hay alguno
		/// </summary>
		/// <param name="htmlHelper"></param>
		/// <returns></returns>
		public static IHtmlString HelpFocusOnFirstField( this HtmlHelper htmlHelper )
		{
			HtmlString htmlFocus = new HtmlString( "<script>setTimeout(function(){ $(':input[tabindex]:visible:enabled:first').focus() }, 300);</script>" );

			// Si el Modelo es válido se posiciona en el primer campo
			if( htmlHelper.ViewData.ModelState.IsValid ) {
				//return new HtmlString( "");// "$(':text:visible:enabled:first').focus();" );
				//return new HtmlString( "$(':input[tabindex=1]:visible:enabled:first').focus();" );

				// Bug chrome tiene un bug, y hay que añadir un delat
				return htmlFocus;
			}

			var key = htmlHelper
				.ViewData
				.ModelState
				.Where( x => x.Value.Errors.Count > 0 )
				.Select( x => x.Key )
				.FirstOrDefault( );


			if( string.IsNullOrEmpty( key ) ) {
				return htmlFocus;
			} else {
				// Hay error, nos posicionamos en el
				return new HtmlString( "<script>setTimeout(function(){ $(':input[name={0}]').focus() }, 300);</script>" );

				//return new HtmlString( string.Format("$(':input[name={0}]').focus();", key));
			}
		}

	}

}