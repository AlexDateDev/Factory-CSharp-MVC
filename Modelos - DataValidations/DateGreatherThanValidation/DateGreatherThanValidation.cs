//// ----------------------------------------------------------------------------
//// Título:    DateGratherThanValidation
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

//namespace Clibb.Common.Utils.Web
//{
//    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
//    public class DataDateGreaterThanAttribute : ValidationAttribute, IClientValidatable
//    {
//        string otherPropertyName;

//        public DataDateGreaterThanAttribute( string otherPropertyName, string errorMessage )
//            : base(errorMessage) {
//            this.otherPropertyName = otherPropertyName;
//        }

//        public IEnumerable<ModelClientValidationRule> GetClientValidationRules( ModelMetadata metadata, ControllerContext context ) {
//            //string errorMessage = this.FormatErrorMessage(metadata.DisplayName);
//            string errorMessage = ErrorMessageString;

//            // The value we set here are needed by the jQuery adapter
//            ModelClientValidationRule dateGreaterThanRule = new ModelClientValidationRule();
//            dateGreaterThanRule.ErrorMessage = errorMessage;
//            dateGreaterThanRule.ValidationType = "clibbgreaterthan"; // This is the name the jQuery adapter will use
//            //"otherpropertyname" is the name of the jQuery parameter for the adapter, must be LOWERCASE!
//            dateGreaterThanRule.ValidationParameters.Add("otherpropertyname", otherPropertyName);

//            yield return dateGreaterThanRule;
//        }

//        protected override ValidationResult IsValid( object value,
//            ValidationContext validationContext ) {
//            ValidationResult validationResult = ValidationResult.Success;
//            try {
//                // Using reflection we can get a reference to the other date property, in this example the project start date
//                //var otherPropertyInfo2 = validationContext.ObjectType.GetProperty(this.otherPropertyName);
//                // DateBegin_DateBegin
//                string sField = this.otherPropertyName;
//                if(this.otherPropertyName.IndexOf("_") > -1) {
//                    sField = this.otherPropertyName.Substring(this.otherPropertyName.IndexOf("_") + 1);
//                }
//                var otherPropertyInfo = validationContext.ObjectType.GetProperty(sField);
//                // Let's check that otherProperty is of type DateTime as we expect it to be
//                //Type t = new DateTime().GetType();

//                //Type tt = otherPropertyInfo.PropertyType;
//                //if (otherPropertyInfo.PropertyType.Equals(new DateTime().GetType()))
//                if(null != otherPropertyInfo)
//                {
//                    if(null != value) {
//                        DateTime toValidate = (DateTime) value;
//                        DateTime referenceProperty = (DateTime) otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);
//                        // if the end date is lower than the start date, than the validationResult will be set to false and return
//                        // a properly formatted error message
//                        if(toValidate.CompareTo(referenceProperty) < 1) {
//                            validationResult = new ValidationResult(ErrorMessageString);
//                        }
//                    }
//                }
//                //else
//                //{
//                //    validationResult = new ValidationResult("An error occurred while validating the property. OtherProperty is not of type DateTime");
//                //}
//            } catch(Exception ex) {
//                // Do stuff, i.e. log the exception
//                // Let it go through the upper levels, something bad happened
//                throw ex;
//            }

//            return validationResult;
//        }
//    }
//}
