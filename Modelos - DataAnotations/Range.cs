// ----------------------------------------------------------------------------
// T�tulo:    Range
//
// Fecha:     04/07/2016
// Autor:    Alex Sol�
// ----------------------------------------------------------------------------

// -------------------------------------------------------------
// ProductoID => Combo con opci�n seleccionada mayor que 0
//
using System.ComponentModel.DataAnnotations;

public partial class MyData
{
	//[Required( ErrorMessageResourceType = typeof( RC ),
	//		ErrorMessageResourceName = "Campo_obligatorio" )]
	//[Range( 1, 10000, ErrorMessageResourceType = typeof( RC ),
	//		ErrorMessageResourceName = "Campo_obligatorio" )]
	public short ProductoID
	{
		get;
		set;
	}
}

