//// ----------------------------------------------------------------------------
//// Título:    StringLength
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

public partial class MyData
{
    [StringLength( 10, ErrorMessage = "MÃ¡ximo {1} caracteres" )]
	public string Nombre
	{
		get;
		set;
	}

	[StringLength( 9, MinimumLength = 9, ErrorMessage = "El DNI ha de tener 9 caracteres" )]
	public string DNI
	{
		get;
		set;
	}

}

