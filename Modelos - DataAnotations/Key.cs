//// ----------------------------------------------------------------------------
//// T�tulo:    Key
////
//// Fecha:     04/07/2016
//// Autor:    Alex Sol�
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
