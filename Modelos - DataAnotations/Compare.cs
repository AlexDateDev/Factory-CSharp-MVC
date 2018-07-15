//// ----------------------------------------------------------------------------
//// T�tulo:    Compare
////
//// Fecha:     04/07/2016
//// Autor:    Alex Sol�
//// ----------------------------------------------------------------------------


using System.ComponentModel.DataAnnotations;

public partial class MyData
{
	[Required]
	[DataType( DataType.Password )]
	[Display( Name = "Current password" )]
	public string OldPassword { get; set; }

	[Required]
	[StringLength( 100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6 )]
	[DataType( DataType.Password )]
	[Display( Name = "New password" )]
	public string NewPassword { get; set; }

	[DataType( DataType.Password )]
	[Display( Name = "Confirm new password" )]
	[Compare( "NewPassword", ErrorMessage = "The new password and confirmation password do not match." )]
	public string ConfirmPassword { get; set; }
}
