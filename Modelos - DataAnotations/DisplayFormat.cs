//// ----------------------------------------------------------------------------
//// T�tulo:    DisplayFormat
////
//// Fecha:     04/07/2016
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;

public partial class MyData
{
	[Required]
	[Display( Name = "Fecha de creaci�n", Description = "Fecha de creaci�n" )]
	[DisplayFormat( DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true )]
	[DataType( DataType.Date )]
	public DateTime FechaCreacion2
	{
		get;
		set;
	}
}
