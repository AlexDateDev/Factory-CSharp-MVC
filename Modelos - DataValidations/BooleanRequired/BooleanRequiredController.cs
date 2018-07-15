//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace TrucoTeca.Controllers
//{
//    public class BooleanRequiredController : Controller
//    {
//		[HttpGet]
//		public ActionResult BooleanRequired( )
//		{
//			return View( );
//		}

//		/// <summary>
//		/// Comprobación del modelo
//		/// </summary>
//		/// <param name="Cliente"></param>
//		/// <returns></returns>
//		[HttpPost]
//		public ActionResult BooleanRequired( ClienteBoolean Cliente)
//		{
//			// Si el check no esta seleccionado, el modelo no es válido
//			if( !this.ModelState.IsValid ) {
//				return View( Cliente );
//			}
//			return View( Cliente);
//		}

//    }
//}
