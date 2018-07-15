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
//	/// Bind de la calse ClienteBoolean con su Metadata
//	/// </summary>
//	[MetadataType( typeof( ClienteBooleanMetadata ) )]
//	public partial class ClienteBoolean { }

//	/// <summary>
//	/// Metadata de la clase ClienteBoolean
//	/// </summary>
//	public class ClienteBooleanMetadata
//	{

//		/// <summary>
//		/// Indicamos que el cambo bool Seleccionar es obligatorio ser seleccionado
//		/// para acptar un post
//		/// </summary>
//		[Display( Name = "Seleccionar", Description = "Obligatiorio seleccionar" )]
//		[AlxBooleanRequired( ErrorMessage = "Es obligatorio seleccionar la opción." )]
//		public bool Seleccionar 
//		{ 
//		    get; 
//		    set; 
//		}
//	}
//}