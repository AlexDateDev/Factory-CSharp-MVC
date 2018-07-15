//using System.ComponentModel.DataAnnotations;
//using System.Collections.Generic;

//namespace System.Web.Mvc.Html
//{
//	/// <summary>
//	/// BooleanRequired
//	/// Cuando se define en un metadata sobre un bool, impolica
//	/// que apra aceptar el modelo, este bool ha de ser true
//	/// </summary>
//	public class AlxBooleanRequiredAttribute : ValidationAttribute, IClientValidatable
//	{
//		/// <summary>
//		/// Comprovación de si el modelo es válido
//		/// </summary>
//		/// <param name="value"></param>
//		/// <returns></returns>
//		public override bool IsValid(object value)
//		{
//			if( value is bool )
//				return ( bool )value;
//			else
//				return true;
//		}

//		/// <summary>
//		/// Regla de validación
//		/// </summary>
//		/// <param name="metadata"></param>
//		/// <param name="context"></param>
//		/// <returns></returns>
//		public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
//			ModelMetadata metadata,
//			ControllerContext context)
//		{
//			yield return new ModelClientValidationRule {
//				ErrorMessage = FormatErrorMessage( metadata.GetDisplayName( ) ),
//				ValidationType = "booleanrequired"
//			};
//		}
//	}
//}
