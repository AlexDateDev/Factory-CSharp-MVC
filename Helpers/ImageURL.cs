// ----------------------------------------------------------------------------
// Título:    ImagteUrl
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
		/// ImageURL
		/// </summary>
		/// <param name="helper"></param>
		/// <param name="id"></param>
		/// <param name="srcImageUrl"></param>
		/// <param name="alt"></param>
		/// <param name="witdh"></param>
		/// <param name="height"></param>
		/// <param name="htmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpImageUrl( this HtmlHelper helper,
			string id,        // Obligatorio
			string srcImageUrl,    // Obligatorio
			string alt,    // Obligatorio
			int? witdh = null,
			int? height = null,
			object htmlAttributes = null )
		{
			// Si no hay imagen no se muestra nada
			if( !string.IsNullOrEmpty( srcImageUrl ) ) {

				if( string.IsNullOrEmpty( alt ) ) {
					throw new ArgumentNullException( "Alt" );
				}
				if( string.IsNullOrEmpty( id ) ) {
					throw new ArgumentNullException( "Id" );
				}

				TagBuilder imageTag = new TagBuilder( "img" );

				imageTag.MergeAttribute( "src", srcImageUrl );

				imageTag.MergeAttribute( "alt", alt );
				imageTag.MergeAttribute( "title", alt );
				imageTag.MergeAttribute( "id", id );

				if( null != witdh ) {
					imageTag.MergeAttribute( "width", Convert.ToString( witdh ) );
				}
				if( null != height ) {
					imageTag.MergeAttribute( "height", Convert.ToString( height ) );
				}

				imageTag.MergeAttributes( new RouteValueDictionary( htmlAttributes ) );

				MvcHtmlString m = MvcHtmlString.Create( imageTag.ToString( TagRenderMode.SelfClosing ) );
				return MvcHtmlString.Create( imageTag.ToString( TagRenderMode.SelfClosing ) );
			}
			return null;
		}
	}

}
