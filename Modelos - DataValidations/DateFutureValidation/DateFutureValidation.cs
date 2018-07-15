//// ----------------------------------------------------------------------------
//// Título:    DateFutureValidation
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//using System.ComponentModel.DataAnnotations;
//using System.Web.Mvc;

//namespace Demo.Application.Controllers
//{
//    public class ModelClientDateFutureValidationRule : ModelClientValidationRule
//    {
//        /// <summary>
//        /// Constructor
//        /// </summary>
//        /// <param name="errorMessage"></param>
//        public ModelClientDateFutureValidationRule( string errorMessage, bool TodayValid )
//        {
//            ErrorMessage = errorMessage;
//            ValidationType = "datefuture";
//            ValidationParameters[ "todayvalid" ] = TodayValid;
//        }
//    }

//    /// <summary>
//    /// DateFuture
//    /// </summary>
//    public class DateFutureValidatorAttribute : ValidationAttribute, IClientValidatable
//    {
//        private readonly bool _todayValid;

//        public bool TodayValid { get { return this._todayValid; } }


//        /// <summary>
//        /// Constructor
//        /// </summary>
//        public DateFutureValidatorAttribute( bool TodayValid = true )
//            : base( )
//        {
//            this._todayValid = TodayValid;
//        }

//        /// <summary>
//        /// validaror
//        /// </summary>
//        /// <param name="value"></param>
//        /// <returns></returns>
//        public override bool IsValid( object value )
//        {
//            if( this._todayValid ) {
//                return value != null && ( DateTime ) value >= DateTime.Now;
//            } else {
//                return value != null && ( DateTime ) value > DateTime.Now;
//            }
//        }

//        /// <summary>
//        /// Regla de validaciÃƒÂ³n del cliente
//        /// </summary>
//        /// <param name="metadata"></param>
//        /// <param name="context"></param>
//        /// <returns></returns>
//        public IEnumerable<ModelClientValidationRule>
//               GetClientValidationRules( ModelMetadata metadata, ControllerContext context )
//        {
//            //var rule = new ModelClientDateFutureValidationRule( ErrorMessage, TodayValid );
//            //yield return rule;
//            yield return new ModelClientValidationRule {
//                ErrorMessage = ErrorMessage,
//                ValidationType = "datefuture"
//            };
//        }
//    }

//}
