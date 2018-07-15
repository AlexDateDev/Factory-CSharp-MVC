// ----------------------------------------------------------------------------
// Título:    RadioButton
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
		public static MvcHtmlString HelpRadioButton(
			this HtmlHelper htmlHelper,
			string Name,
			string Id,
			string Title,
			string Value,
			bool IsCheked,
			string Text,
			bool TextAfter = true,
			string sClass = null,
			object HtmlAttributes = null
		)
		{
			if( string.IsNullOrEmpty( Name ) ) {
				throw new ArgumentNullException( "Name" );
			}
			if( string.IsNullOrEmpty( Id ) ) {
				throw new ArgumentNullException( "Id" );
			}
			if( null == Value ) {
				throw new ArgumentNullException( "Value" );
			}
			if( string.IsNullOrEmpty( Title ) ) {
				throw new ArgumentNullException( "Title" );
			}
			if( string.IsNullOrEmpty( Text ) ) {
				throw new ArgumentNullException( "Text" );
			}

			TagBuilder htmlRadio = new TagBuilder( "input" );
			htmlRadio.MergeAttribute( "type", "radio" );
			htmlRadio.MergeAttribute( "style", "vertical-align:top" );

			htmlRadio.MergeAttribute( "id", Id );
			htmlRadio.MergeAttribute( "name", Name );

			htmlRadio.MergeAttribute( "title", Title );

			if( !string.IsNullOrEmpty( sClass ) ) {
				htmlRadio.MergeAttribute( "class", sClass );
			}
			htmlRadio.MergeAttribute( "value", Value );

			htmlRadio.MergeAttributes( new RouteValueDictionary( HtmlAttributes ) );

			if( IsCheked ) {
				htmlRadio.MergeAttribute( "checked", "checked" );
			}
			string lText = "";
			if( null != Text ) {
				lText = "<span>" + Text + "</span>";
			}
			if( TextAfter ) {
				return MvcHtmlString.Create( htmlRadio.ToString( TagRenderMode.SelfClosing ) + "&nbsp;" + lText );
			} else {
				return MvcHtmlString.Create( lText + "&nbsp;" + htmlRadio.ToString( TagRenderMode.SelfClosing ) );
			}
		}


		/// <summary>
		///
		/// </summary>
		/// <typeparam name="TModel"></typeparam>
		/// <param name="htmlHelper"></param>
		/// <param name="expression"></param>
		/// <param name="Value"></param>
		/// <param name="IsCheked"></param>
		/// <param name="Text"></param>
		/// <param name="TextAfter"></param>
		/// <param name="sClass"></param>
		/// <param name="HtmlAttributes"></param>
		/// <returns></returns>
		///
		
        public static MvcHtmlString HelpRadioButtonFor<TModel>(
            this HtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, bool?>> expression,
            string Value,
            bool IsCheked,
            string Text,
            bool TextAfter = true,
            string sClass = null,
            object HtmlAttributes = null
            )
        {
            if( null == Value ) {
                throw new ArgumentNullException( "Value" );
            }
            if( string.IsNullOrEmpty( Text ) ) {
                throw new ArgumentNullException( "Text" );
            }

            var metaData = ModelMetadata.FromLambdaExpression( expression, htmlHelper.ViewData );

            RouteValueDictionary routeValues = new RouteValueDictionary( HtmlAttributes );
            if( !string.IsNullOrEmpty( metaData.Description ) ) {
                routeValues.Add( "title", metaData.Description );
            }

            if( !string.IsNullOrEmpty( sClass ) ) {
                routeValues.Add( "class", sClass );
            }
            routeValues.Add( "value", Value );

            var label = new TagBuilder( "label" );
            string htmlFieldName = ExpressionHelper.GetExpressionText( expression );
            label.Attributes.Add( "for", htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldId( htmlFieldName ) );

            if( !string.IsNullOrEmpty( metaData.Description ) )
                label.Attributes.Add( "title", metaData.Description );

            label.SetInnerText( Text );

            routeValues.Add( "style", "vertical-align:middle" );

            if( IsCheked ) {
                routeValues.Add( "checked", "checked" );
            }

            MvcHtmlString chk = Html.InputExtensions.RadioButtonFor( htmlHelper, expression, Value, routeValues );

            if( TextAfter ) {
                return MvcHtmlString.Create( chk.ToString( ) + "&nbsp;" + label.ToString() );
            }
            else {
                return MvcHtmlString.Create( label.ToString() + "&nbsp;" + chk.ToString( ) );
            }
        }
		public static MvcHtmlString HelpRadioButtonYesFor<TModel>(
			this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, bool?>> expression,
			bool IsCheked,
			bool TextAfter = true,
			string sClass = null,
			object HtmlAttributes = null
			)
		{
			return HelpRadioButtonFor( htmlHelper,
										expression,
										"true",
										IsCheked,
										"Sí",
										TextAfter,
										sClass,
										HtmlAttributes );
		}

		public static MvcHtmlString HelpRadioButtonNoFor<TModel>(
			this HtmlHelper<TModel> htmlHelper,
			Expression<Func<TModel, bool?>> expression,
			bool IsCheked,
			bool TextAfter = true,
			string sClass = null,
			object HtmlAttributes = null
			)
		{
			return HelpRadioButtonFor( htmlHelper,
										expression,
										"false",
										IsCheked,
										"No",
										TextAfter,
										sClass,
										HtmlAttributes );
		}
		

	}

}
