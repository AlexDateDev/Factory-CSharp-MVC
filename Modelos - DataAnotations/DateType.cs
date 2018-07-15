//// ----------------------------------------------------------------------------
//// T�tulo:    DateType
////
//// Fecha:     04/07/2016
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;

public partial class MyData
{
	// Fecha
	[Required]
	[Display( Name = "Fecha de creación", Description = "Fecha de creación" )]
	[DisplayFormat( DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true )]
	[DataType( DataType.Date )]
	public DateTime FechaCreacion { get; set; }

	// Password
	[Required]
	[DataType( DataType.Password )]
	[Display( Name = "Current password" )]
	public string OldPassword2 { get; set; }

	// Email
	[Required]
	[DataType( DataType.EmailAddress )]
	[Display( Name = "Email address" )]
	public string Email { get; set; }

}
