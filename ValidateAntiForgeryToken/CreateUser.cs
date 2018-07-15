//// ----------------------------------------------------------------------------
//// Título:    CreateUser
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//[HttpPost]
//[ValidateAntiForgeryToken]
//public ActionResult create(UsuarioViewModel vmUsr)
//{
//    if( ModelState.IsValid ) {
//        try {
//            vmUsr.Usuario.IdUsuario = 1;
//            this._managementUsuario.create( vmUsr.Usuario );
//            return View( "Index" );
//        }
//        catch( Exception e ) {
//            return Content( e.Message + "<br />" + e.InnerException );

//        }
//    }
//    return View( );
//}
