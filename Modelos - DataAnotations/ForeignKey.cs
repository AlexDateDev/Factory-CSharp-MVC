//// ----------------------------------------------------------------------------
//// Título:    ForeignKey
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public partial class MyData
{
	[Key]
	public int IdUsuario { get; set; }

	[Required]
	public int IdEstado { get; set; }

	[ForeignKey( "IdEstado" )]
	public int oneEstado { get; set; }


	[ForeignKey( "IdUsuario" )]
	[Required]
	public bool oneCredencial { get; set; }
}

