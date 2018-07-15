//// ----------------------------------------------------------------------------
//// Título:    OnActionExecuting
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//using System;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Routing;

//namespace Clibb.Common.Utils
//{
//    public class RedirectingAction : ActionFilterAttribute
//    {
//        /// <summary>
//        /// Función que se ejecuta antes de ejecutar cualquier accion de cualquier controlador
//        /// Sirve poara mirar si estamos autenticados, sino se redireigue al login
//        /// El controlador que lo utiliza ha de tener [RedirectingAction] declarado en la clase
//        /// </summary>
//        /// <param name="context"></param>
//        public override void OnActionExecuting(ActionExecutingContext context)
//        {
//            base.OnActionExecuting(context);

//            if (null == HttpContext.Current.Session["_currentUserId"] ||
//                 ((int)HttpContext.Current.Session["_currentUserId"] == 0))
//            {
//                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new
//                {
//                    controller = "Home",
//                    action = "Login"
//                }));
//            }
//        }
//    }
//}
