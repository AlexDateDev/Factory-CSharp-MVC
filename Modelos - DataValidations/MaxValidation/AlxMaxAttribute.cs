//using System;
//using System.ComponentModel.DataAnnotations;
//using System.Globalization;

//namespace System.Web.Mvc.Html
//{
//	/// <summary>
//	/// Atributo
//	/// </summary>
//    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
//    public class AlxMaxAttribute : DataTypeAttribute
//    {
//		/// <summary>
//		/// Max Value
//		/// </summary>
//        public object Max { get { return _max; } }

//		// Max 
//        private readonly double _max;

//		/// <summary>
//		/// Constructor
//		/// </summary>
//		/// <param name="max"></param>
//        public AlxMaxAttribute(int max)
//            : base("max")
//        {
//            _max = max;
//        }

//		/// <summary>
//		/// Constructor
//		/// </summary>
//		/// <param name="max"></param>
//        public AlxMaxAttribute(double max)
//            : base("max")
//        {
//            _max = max;
//        }


//		/// <summary>
//		/// Mensaje de error que se muestra si el Metadata no tiene definido 
//		/// ningun texto de error al superar el valor máximo
//		/// </summary>
//		/// <param name="name"></param>
//		/// <returns></returns>
//		public override string FormatErrorMessage( string name )
//		{
//			if( ErrorMessage == null && ErrorMessageResourceName == null ) {
//				ErrorMessage = "Valor màximo superado";
//			}

//			return String.Format( CultureInfo.CurrentCulture, ErrorMessageString, name, _max );
//		}
//		/// <summary>
//		/// Validación
//		/// </summary>
//		/// <param name="value"></param>
//		/// <returns></returns>
//        public override bool IsValid(object value)
//        {
//            if (value == null) return true;

//            double valueAsDouble;

//            var isDouble = double.TryParse(Convert.ToString(value), out valueAsDouble);

//            return isDouble && valueAsDouble <= _max;
//        }
//    }
//}