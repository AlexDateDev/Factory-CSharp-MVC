//// ----------------------------------------------------------------------------
//// Título:    Binding UpdateModel
////
//// Fecha:     02/03/2013
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

// --------------------------------------
// OK
// MVCController.cs
// --------------------------------------


//// UpdateModel realiza el binding de forma manual, pero se tiene que realizar dentro de un try/catch
//[HttpPost]
//public ActionResult Edit()
//{
//    GridViewModel vm = new GridViewModel( );
//    try {
//        UpdateModel( vm ); // Binding
//    this._managementGrid.Update( vm.PageItem );
//    return View( "Edit", this.GridViewModel );
//    }
//    catch {
//        return View( "Edit", vm );
//    }
//}

//// TryUpdateModel realiza el binding de forma manual, pero controla el try/cath de esta forma detectando si el modelo es válido.
//[HttpPost]
//public ActionResult Edit()
//{
//    GridViewModel vm = new GridViewModel( );
//    TryUpdateModel( vm ); // Binding
//    if( ModelState.IsValid ){
//        this._managementGrid.Update( vm.PageItem );
//        return View( "Edit", this.GridViewModel );
//    }
//    else{
//        return View( "Edit", vm );
//    }
//}

