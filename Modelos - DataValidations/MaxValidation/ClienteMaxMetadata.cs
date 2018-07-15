//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel;
//using System.Web.Mvc.Html;

//namespace TrucoTeca.Controllers
//{
//	/// <summary>
//	/// Bind de la calse ClienteMax con su Metadata
//	/// </summary>
//	[MetadataType( typeof( ClienteMaxMetadata ) )]
//	public partial class ClienteMax{ }

//	/// <summary>
//	/// Metadata de la clase ClienteMaxMetadata
//	/// </summary>
//	public class ClienteMaxMetadata
//	{

//		// No es un valor obligatorio
//		[Display( Name = "Un byte (Max=100)", Description = "Un byte" )]
//		[AlxMax(100, ErrorMessage = "Un byte con máximo valor de 100" )]
//		public byte? UnByte { get; set; }

//		// Como no puede ser null => Es un campo obligatorio
//		[Display( Name = "Un short (Max=500)", Description = "Un short" )]
//		[AlxMax( 500)] // Como error se muestra el del atributo
//		public short UnShort { get; set; }

//		// Como no puede ser null => Es un campo obligatorio
//		[Display( Name = "Un int (Max=20000)", Description = "Un int" )]
//		[AlxMax( 20000, ErrorMessage = "Un int con máximo valor de 20000" )]
//		public int UnInt { get; set; }

//		// Como no puede ser null => Es un campo obligatorio
//		[Display( Name = "Un double(Max=49999.99)", Description = "Un double" )]
//		[AlxMax( 49999.99, ErrorMessage = "Un double con máximo valor de 49999.99" )]
//		public double UnDouble { get; set; }

//		// Como no puede ser null => Es un campo obligatorio
//		[Display( Name = "Un decimal(Max=123.45)", Description = "Un decimal" )]
//		[AlxMax( 123.45, ErrorMessage = "Un decimal con máximo valor de 123.45" )]
//		public decimal UnDecimal { get; set; }

//		// Como no puede ser null => Es un campo obligatorio
//		[Display( Name = "Un float(Max=22222.99)", Description = "Un float" )]
//		[AlxMax( 22222.99, ErrorMessage = "Un float con máximo valor de 22222.99" )]
//		public float UnFloat { get; set; }

//		// Como no puede ser null => Es un campo obligatorio
//		[Display( Name = "Un long(Max=123456789)", Description = "Un long" )]
//		[AlxMax( 123456789,ErrorMessage = "Un long con máximo valor de 123456789" ) ]
//		public long UnLong { get; set; }
//	}
//}