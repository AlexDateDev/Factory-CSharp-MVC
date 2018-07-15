//// ----------------------------------------------------------------------------
//// Título:    RedirectToAction
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


//public class AccountController : Controller
//{
//    [HttpGet]
//    public ActionResult Index(GridViewModel model)
//    {
//        // …
//        return View( model );
//    }

//    [HttpPost]
//    public ActionResult Save(GridViewModel model)
//    {
//        // …
//        return RedirectToAction( "Index" );
//    }
//}

//// Varios formatos

//return RedirectToAction( "Action", new { id = 99 } );
//return RedirectToAction( "Action", "Controller" );
//return RedirectToAction( "Action", "Controller", new { id = 99 } );
//return RedirectToAction( "Main",
//                            new RouteValueDictionary(
//                                    new {     controller = "controllerName",
//                                            action = "Main",
//                                            Id = Id,
//                                            extraParam = someVariable
//                                        }
//                            )
//);
