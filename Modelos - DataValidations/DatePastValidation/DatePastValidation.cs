//// ----------------------------------------------------------------------------
//// T�tulo:    DatePastValidation
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
//    public class DataDatePastNullAttribute : ValidationAttribute, IClientValidatable
//    {
//        public DataDatePastNullAttribute( )
//            : base() {
//        }

//        /// <summary>
//        /// FunciÃ³n de validaciÃ³n de Phone (Server side)
//        /// </summary>
//        /// <param name="value"></param>
//        /// <returns></returns>
//        public override bool IsValid( object value ) {
//            DateTime dt;

//            if(null == value) {
//                // Si no hay fecha => es correcta
//                return true;
//            }

//            bool parsed = DateTime.TryParse(value.ToString(), out dt);
//            if(parsed) {
//                // Comprobar que sea menor o igual que hoy
//                DateTime today = new DateTime( DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59 );
//                if(dt <= today) {
//                    return true;
//                }
//                else {
//                    return false;
//                }
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
//                ErrorMessage = "Fecha incorrecta";
//            }

//            // Devolvemos la regla de validaciÃ³n para el cliente
//            yield return new ModelClientValidationRule {
//                ErrorMessage = ErrorMessage,
//                ValidationType = "dataclibbpast"
//            };
//        }
//    }
//}
