//// ----------------------------------------------------------------------------
//// Título:    HttpPostedFileBase
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//                                            [HttpPost]
//public ActionResult uploaddbpost( )
//{
//    HttpPostedFileBase file = Request.Files[ "FileUpload1"];
//    this._managementUsuario.addImage( file );

//    return View( "index");
//}

//[HttpPost]
//public ActionResult uploadnormalpost()
//{
//    HttpPostedFileBase ficheroASubir = Request.Files[ "ficheroASubir" ];
//    if( ficheroASubir != null && ficheroASubir.ContentLength > 0 ) {
//        var nombrefichero = Path.GetFileName( ficheroASubir.FileName );
//        var path = Path.Combine( Server.MapPath( "~/App_Data/ficheros" ), nombrefichero );
//        ficheroASubir.SaveAs( path );
//        return RedirectToAction( "Index" );
//    }
//    else
//        return View( );
//}

//[HttpPost]
//public JsonResult upload( )
//{
//    var file = new StreamReader(this.HttpContext.Request.InputStream, Encoding.UTF8).ReadToEnd();
//    return Json( new { contenido = file } );
//}

//public void addImage(HttpPostedFileBase file)
//{
//    try {
//        string mimeType = file.ContentType;
//        Stream fileStream = file.InputStream;
//        string fileName = Path.GetFileName( file.FileName );
//        int fileLength = file.ContentLength;
//        byte[] fileData = new byte[ fileLength ];
//        fileStream.Read( fileData, 0, fileLength );

//        FileStore f = new FileStore( );
//        f.FileContent = fileData;
//        f.FileName = fileName;
//        f.MimeType = mimeType;

//        this.db.FileStore.AddObject( f );
//        //this.db.ObjectStateManager.ChangeObjectState( f, EntityState.Added );
//        this.db.SaveChanges( );
//    }
//    catch( EntityException dbEx ) {
//        throw new Exception( dbEx.Message );

//    }
//    finally {
//        if( null != this.db ) {
//            this.Dispose( );
//            this.db.Dispose( );
//        }
//    }
//}
