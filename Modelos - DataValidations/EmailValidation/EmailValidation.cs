//// ----------------------------------------------------------------------------
//// T�tulo:    EmailValidation
////
//// Fecha:     04/07/2016
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------

//ï»¿using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Web;
//using System.Web.Mvc;
//using System.ComponentModel.DataAnnotations;


//namespace Clibb.Common.Utils.Web
//{
//    /// <summary>
//    /// Regla de validaciÃ³n de Phone
//    /// </summary>
//    //public class EmailValidationRule : ModelClientValidationRule
//    //{
//    //    public EmailValidationRule(string errorMessage)
//    //    {
//    //        ErrorMessage = errorMessage;
//    //        ValidationType = "email";
//    //    }
//    //}

//    /// <summary>
//    /// Atributo Email
//    /// </summary>
//    public class DataEmailAttribute : RegularExpressionAttribute, IClientValidatable
//    {
//        /// <summary>
//        /// Constructor
//        /// </summary>
//        public DataEmailAttribute( )
//            : base("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$") {
//            //\b[A-Z0-9._%+-]+@(?:[A-Z0-9-]+\.)+[A-Z]{2,4}\b
//        }

//        /// <summary>
//        /// ValidaciÃ³n Client-Side
//        /// </summary>
//        /// <param name="metadata"></param>
//        /// <param name="context"></param>
//        /// <returns></returns>
//        public IEnumerable<ModelClientValidationRule> GetClientValidationRules( ModelMetadata metadata, ControllerContext context ) {
//            if(string.IsNullOrEmpty(ErrorMessage)) {
//                ErrorMessage = "Formato de correo incorrecto";
//            }
//            //yield return new EmailValidationRule( ErrorMessage );
//            yield return new ModelClientValidationRule {
//                ErrorMessage = ErrorMessage,
//                ValidationType = "email"
//            };
//        }
//    }
//}
