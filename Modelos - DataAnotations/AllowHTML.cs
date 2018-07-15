// ----------------------------------------------------------------------------
// Título:    AllowHTML
//
// Fecha:     04/07/2016
// Autor:    Alex Solé
// ----------------------------------------------------------------------------


// TextoHTML  ----------------------------------------------------------------------------
// Permite aceptar texto HTML desde los post al validar el modelo

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

public partial class MyData
{
	//[Required( ErrorMessageResourceType = typeof( RC ),
	//			ErrorMessageResourceName = "Campo_obligatorio" )]
	[Required( ErrorMessage = "Es obligatorio indicar un nombre para el cliente" )]
	[AllowHtml]
	public string TextoHTML { get; set; }
}
