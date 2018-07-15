//// ----------------------------------------------------------------------------
//// Título:    Display
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

public partial class MyData
{
	[Display( Name = "Nombre",
				Description = "Nombre del cliente" )]
	public string Nombre2 { get; set; }

	//[Display( Name = "TxtEmail",
	//			ResourceType = typeof( Res ),
	//			Description = "TxtEmailDescription" )]
	public string Email2 { get; set; }
}
