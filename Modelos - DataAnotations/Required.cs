//// ----------------------------------------------------------------------------
//// Título:    Required
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations;

public partial class MyData
{

	// Obligatirio sin espacios
	[Required( ErrorMessage = "Es obligatorio indicar un nombre para el cliente" )]
	public string Nombre3
	{
		get;
		set;
	}


	[Required]
	public DateTime FechaCreacion3
	{
		get;
		set;
	}

	// Obligatirio sin espacios
	[Required( AllowEmptyStrings = false,
				ErrorMessage = "Es obligatorio indicar un email" )]
	public string Email3 { get; set; }

}
