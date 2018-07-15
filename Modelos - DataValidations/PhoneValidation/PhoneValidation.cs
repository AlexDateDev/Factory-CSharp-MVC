//// ----------------------------------------------------------------------------
//// T�tulo:    PhoneValidation
////
//// Fecha:     04/07/2016
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------

//ï»¿using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel.DataAnnotations;
//using System.Web.Mvc;

//namespace Clibb.Common.Utils.Web
//{

//    public class DataPhoneAttribute : ValidationAttribute, IClientValidatable
//    {
//        /// <summary>
//        /// Constructor
//        /// </summary>
//        public DataPhoneAttribute( )
//            : base() {
//        }

//        /// <summary>
//        /// FunciÃ³n de validaciÃ³n de Phone (Server side)
//        /// </summary>
//        /// <param name="value"></param>
//        /// <returns></returns>
//        public override bool IsValid( object value ) {
//            string sPhone = Convert.ToString(value);

//            if(null != sPhone) {
//                foreach(char c in sPhone) {
//                    if(!Char.IsDigit(c)) {
//                        return false;
//                    }
//                }
//                return (sPhone.Length == 9 && (sPhone[0] == '9' || sPhone[0] == '6'));
//            }
//            return false;
//        }

//        /// <summary>
//        /// ValidaciÃ³n Client-Side
//        /// </summary>
//        /// <param name="metadata"></param>
//        /// <param name="context"></param>
//        /// <returns></returns>
//        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
//            ModelMetadata metadata,
//            ControllerContext context ) {
//            if(string.IsNullOrEmpty(ErrorMessage)) {
//                ErrorMessage = "NÃºmero de telÃ©fono incorrecto";
//            }

//            // Devolvemos la regla de validaciÃ³n para el cliente
//            yield return new ModelClientValidationRule {
//                ErrorMessage = ErrorMessage,
//                ValidationType = "telephone"
//            };
//            //var rule = new ModelClientPhoneValidationRule( ErrorMessage );
//            //yield return rule;
//        }
//    }
//}
