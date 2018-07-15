// ----------------------------------------------------------------------------
// T�tulo:    TextLabel
//
// Fecha:     04/07/2016
// Autor:    Alex Sol�
// ----------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using System.Web.Routing;
using System.Linq;

namespace System.Web.Mvc.Html
{
	public static partial class MvcHtmlExtensions
	{
		/// <summary>
		///
		/// </summary>
		/// <param name="helper"></param>
		/// <param name="Text"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextLabel( this HtmlHelper helper,
			string Text,    // Puede ser null o vacio
			string sClass = null,
			object HtmlAttributes = null )
		{
			if( !string.IsNullOrEmpty( Text ) ) {
				var container = new TagBuilder( "p" );

				if( !string.IsNullOrEmpty( sClass ) ) {
					container.AddCssClass( sClass );
				}

				container.MergeAttributes( new RouteValueDictionary( HtmlAttributes ) );
				container.InnerHtml = Text + ":";

				return MvcHtmlString.Create( container.ToString( ) );
			}
			return MvcHtmlString.Create( "" );
		}

		/// <summary>
		/// Añade un texto que se obtiene de parámetro Display(Name) de la Annoattions (Si exiete)
		/// Añade el texto dentro de un párrafo <p></p>
		/// Crea el texto dentro de un label for
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="htmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		public static MvcHtmlString HelpTextLabelFor<TModel, TValue>( this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, TValue>> expression,
			string sClass = null,
			object HtmlAttributes = null )
		{

			var container = new TagBuilder( "p" );

			if( !string.IsNullOrEmpty( sClass ) ) {
				container.AddCssClass( sClass );
			}

			var metaData = ModelMetadata.FromLambdaExpression( expression, htmlHelper.ViewData );
			string htmlFieldName = ExpressionHelper.GetExpressionText( expression );
			string labelText = metaData.DisplayName ?? metaData.PropertyName ?? htmlFieldName.Split( '.' ).Last( );


			var label = new TagBuilder( "label" );
			label.Attributes.Add( "for", htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldId( htmlFieldName ) );

			if( !string.IsNullOrEmpty( metaData.Description ) )
				label.Attributes.Add( "title", metaData.Description );

			label.SetInnerText( labelText );

			container.MergeAttributes( new RouteValueDictionary( HtmlAttributes ) );
			container.InnerHtml = label.ToString( ) + ":";

			return MvcHtmlString.Create( container.ToString( ) );
		}

	}

}
