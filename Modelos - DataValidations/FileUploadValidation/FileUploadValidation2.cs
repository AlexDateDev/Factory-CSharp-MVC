//// ----------------------------------------------------------------------------
//// T�tulo:    FileUploadValidation2
////
//// Fecha:     04/07/2016
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------

//﻿using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.ComponentModel.DataAnnotations;
//using System.Web;
//using System.Drawing;
//using Resources;

//namespace AraLleida.BackOffice.Utils
//{
//    /// <summary>
//    /// Tamaño del archivo en KBytes
//    /// </summary>
//    public class FileSizeKBAttribute : ValidationAttribute
//    {
//        private readonly int _maxSize;

//        public FileSizeKBAttribute( int maxSize ) {
//            _maxSize = maxSize;
//        }

//        public override bool IsValid( object value ) {
//            if(value == null) return true;

//            return (_maxSize * 1024) > (value as HttpPostedFileBase).ContentLength;
//        }

//        public override string FormatErrorMessage( string name ) {
//            return string.Format(@RCBackOffice.lblMaxSizeFile, _maxSize);
//        }

//    }

//    /// <summary>
//    /// Ancho de la Imagen
//    /// </summary>
//    public class FileTypeImageMaxWidthAttribute : ValidationAttribute
//    {
//        private int _maxWidth;
//        private readonly List<string> _types = new List<string>() { { "jpg" }, { "jpeg" }, { "png" }, { "gif" } };

//        public FileTypeImageMaxWidthAttribute( int Width ) {
//            this._maxWidth = Width;
//        }

//        public override bool IsValid( object value ) {
//            if(value == null) return true;

//            HttpPostedFileBase file = value as HttpPostedFileBase;
//            var fileName = Path.GetFileName(file.FileName);
//            var fileExtx = fileName.Substring(1);

//            // Para mirar las dimensiones, primero hemos de asegurarnos que es un tipo imagen
//            var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
//            if(_types.Contains(fileExt, StringComparer.OrdinalIgnoreCase)) {
//                Bitmap img = new Bitmap(fileName);
//                var imageWidth = img.Width;
//                if(imageWidth > this._maxWidth) {
//                    return false;
//                }
//            }
//            return true;
//        }

//        public override string FormatErrorMessage( string name ) {
//            return string.Format("El ancho de la imagen no puede ser superior a {0} px", this._maxWidth);
//        }
//    }

//    /// <summary>
//    /// Alturea de la imagen
//    /// </summary>
//    public class FileTypeImageMaxHeightAttribute : ValidationAttribute
//    {
//        private int _maxHeight;

//        private readonly List<string> _types = new List<string>(){ {"jpg"}, {"jpeg"}, {"png"},{"gif"}};

//        public FileTypeImageMaxHeightAttribute( int Height ) {
//            this._maxHeight = Height;
//        }

//        public override bool IsValid( object value ) {
//            if(value == null) return true;

//            HttpPostedFileBase file = value as HttpPostedFileBase;
//            string fileName = file.FileName;
//            var fileExtx = fileName.Substring(1);

//            // Para mirar las dimensiones, primero hemos de asegurarnos que es un tipo imagen
//            var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);

//            if(_types.Contains(fileExt, StringComparer.OrdinalIgnoreCase)) {
//                Bitmap img = new Bitmap(fileName);
//                if(img.Height > this._maxHeight) {
//                    return false;
//                }
//            }
//            return true;
//        }

//        public override string FormatErrorMessage( string name ) {
//            return string.Format("La altura de la imagen no puede ser superior a {0} px", this._maxHeight);
//        }
//    }


//    /// <summary>
//    /// Imagen
//    /// </summary>
//    public class FileTypeImageAttribute : ValidationAttribute
//    {
//        private readonly List<string> _types;

//        public FileTypeImageAttribute( ) {
//            _types = new List<string>(){ {"jpg"}, {"jpeg"}, {"png"},{"gif"}};
//        }

//        public override bool IsValid( object value ) {
//            if(value == null) return true;

//            HttpPostedFileBase file = value as HttpPostedFileBase;
//            string fileName = file.FileName;
//            var fileExtx = fileName.Substring(1);


//            var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
//            bool ok = _types.Contains(fileExt, StringComparer.OrdinalIgnoreCase);
//            return ok;
//        }

//        public override string FormatErrorMessage( string name ) {
//            return string.Format("Formato de la imagen incorrecto. Sólo se aceptan formatos {0}.", String.Join(", ", _types));
//        }
//    }

//    /// <summary>
//    /// Archivo CSV para importación
//    /// </summary>
//    public class FileTypeCSVAttribute : ValidationAttribute
//    {
//        private readonly List<string> _types;

//        public FileTypeCSVAttribute( ) {
//            _types = new List<string>() { { "csv" }};
//        }

//        public override bool IsValid( object value ) {
//            if(value == null) return true;

//            HttpPostedFileBase file = value as HttpPostedFileBase;
//            string fileName = file.FileName;
//            var fileExtx = fileName.Substring(1);

//            var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
//            bool ok = _types.Contains(fileExt, StringComparer.OrdinalIgnoreCase);
//            return ok;
//        }

//        public override string FormatErrorMessage( string name ) {
//            return string.Format("Formato de archivo incorrecto. Sólo se aceptan formatos {0}.", String.Join(", ", _types));
//        }
//    }


//    /// <summary>
//    /// Tipos de archivo
//    /// </summary>
//    public class FileTypesAttribute : ValidationAttribute
//    {
//        private readonly List<string> _types;

//        public FileTypesAttribute( string types ) {
//            _types = types.Split(',').ToList();
//        }

//        public override bool IsValid( object value ) {
//            if(value == null) return true;

//            HttpPostedFileBase file = value as HttpPostedFileBase;
//            string fileName = file.FileName;
//            var fileExtx = fileName.Substring(1);

//            var fileExt = System.IO.Path.GetExtension(file.FileName).Substring(1);
//            bool ok = _types.Contains(fileExt, StringComparer.OrdinalIgnoreCase);
//            return ok;
//        }

//        public override string FormatErrorMessage( string name ) {
//            return string.Format("Formato de archivo incorrecto. Sólo se aceptan formatos {0}.", String.Join(", ", _types));
//        }
//    }
//}
