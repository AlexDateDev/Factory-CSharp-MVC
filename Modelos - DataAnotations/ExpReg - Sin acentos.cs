//// ----------------------------------------------------------------------------
//// Título:    ExpReg - Sin acentos
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

public partial class MyData
{
	[Required( ErrorMessage = "Es obligatorio indicar un nombre de usuario" )]
	[RegularExpression( @"^\S*$", ErrorMessage = "El nombre de usuario no puede contener espacios" )]
	[StringLength( 50, MinimumLength = 6, ErrorMessage = "MÃƒÂ­nimo {2} caracteres" )]
	[Remote( "remoteGetCredentialUserName", "User", HttpMethod = "Post", ErrorMessage = "Este nombre de usuario ya esta ocupado" )]
	public string UserName { get; set; }
}
