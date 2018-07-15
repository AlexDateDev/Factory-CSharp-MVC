//// ----------------------------------------------------------------------------
//// Título:    DateFutureValidation - Controller
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Demo.Application.Models;

//namespace Demo.Application.Controllers
//{
//    public class ValidateController : Controller
//    {
//        //
//        // GET: /Validate/
//        [HttpGet]
//        public ActionResult Index()
//        {
//            ValidateModel v = new ValidateModel( );
//            return View(v);
//        }

//        [HttpPost]
//        public ActionResult Index( ValidateModel v)
//        {
//            if( !ModelState.IsValid ) {
//                v.Event = DateTime.Now;
//            }
//            return View( v );
//        }

//    }
//}
