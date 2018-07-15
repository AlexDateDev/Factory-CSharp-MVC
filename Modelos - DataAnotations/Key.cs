//// ----------------------------------------------------------------------------
//// Título:    Key
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

public partial class MyData
{
	[Key]
	public int IdCliente
	{
		get;
		set;
	}
}
