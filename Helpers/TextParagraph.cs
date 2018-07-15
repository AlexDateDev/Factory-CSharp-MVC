// ----------------------------------------------------------------------------
// T�tulo:    TextParagraph
//
// Fecha:     04/07/2016
// Autor:    Alex Sol�
// ----------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using System.Web.Routing;

namespace System.Web.Mvc.Html
{
	public static partial class MvcHtmlExtensions
	{
		/// <summary>
		/// Muestra una fecha (dd/mm/yyyy) en un parágrafo
		/// </summary>
		/// <param name="helper"></param>
		/// <param name="dt"></param>
		/// <param name="Class"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString FactoryTextParagraph( this HtmlHelper helper,
			DateTime? dt,
			string Class = null,
			object HtmlAttributes = null )
		{
			if( null != dt ) {
				return HelpTextParagraph( helper, dt.Value.ToShortDateString( ), Class, HtmlAttributes );
			} else {
				return HelpTextParagraph( helper, "", Class, HtmlAttributes );
			}
		}

		/// <summary>
		/// Muestra un int en una parágraph
		/// </summary>
		/// <param name="helper"></param>
		/// <param name="Num"></param>
		/// <param name="Class"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextParagraph( this HtmlHelper helper,
			int? Num,
			string Class = null,
			object HtmlAttributes = null )
		{
			if( null != Num ) {
				return HelpTextParagraph( helper, Convert.ToString( Num ), Class, HtmlAttributes );
			} else {
				return HelpTextParagraph( helper, "", Class, HtmlAttributes );
			}
		}

		/// <summary>
		/// Muestra un double en una parágraph
		/// </summary>
		/// <param name="helper"></param>
		/// <param name="Num"></param>
		/// <param name="Class"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextParagraph( this HtmlHelper helper,
			double? Num,
			string Class = null,
			object HtmlAttributes = null )
		{
			if( null != Num ) {
				return HelpTextParagraph( helper, Convert.ToString( Num ), Class, HtmlAttributes );
			} else {
				return HelpTextParagraph( helper, "", Class, HtmlAttributes );
			}
		}


		/// <summary>
		/// Muestra un texto en un parágrafo
		/// </summary>
		/// <param name="helper"></param>
		/// <param name="Text"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextParagraph( this HtmlHelper helper,
			string Text,    // Puede ser null
			string Class = null,
			object HtmlAttributes = null )
		{

			var container = new TagBuilder( "p" );

			if( !string.IsNullOrEmpty( Class ) ) {
				container.AddCssClass( Class );
			}

			container.MergeAttributes( new RouteValueDictionary( HtmlAttributes ) );

			if( null != Text ) {
				container.InnerHtml = Text;
			}

			return MvcHtmlString.Create( container.ToString( ) );
		}
	}

}
