﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace TrucoTeca.Controllers
//{
//    public class MaxController : Controller
//    {
//		[HttpGet]
//        public ActionResult MaxValue()
//        {
//            return View();
//        }

//		/// <summary>
//		/// Comprobación del modelo
//		/// </summary>
//		/// <param name="Cliente"></param>
//		/// <returns></returns>
//		[HttpPost]
//		public ActionResult MaxValue( ClienteMax Cliente )
//		{
//			// Los valores no pueden superar el máximo especificado en el Metadata
//			if( !this.ModelState.IsValid ) {
//				return View( Cliente );
//			}
//			return View( Cliente );
//		}
//    }
//}
