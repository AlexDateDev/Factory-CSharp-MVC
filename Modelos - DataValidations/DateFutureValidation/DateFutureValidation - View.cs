//// ----------------------------------------------------------------------------
//// Título:    DateFutureValidation - View
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------

//@using Demo.Application.Models

//@{
//    ViewBag.Title = "Validate";
//}

//@model ValidateModel
//<script type="text/javascript">

//    /* DateFuture */
//    jQuery.validator.addMethod('datefuture',
//    function (value, element, params)
//    {
//        /*if (!Data.Validate.isDate(value)) {
//            return false;
//        }
//        var oDate = Data.Date.toDateObject(value);
//        var sToday = Data.Date.today();
//        var oDateToday = Data.Date.toDateObject(sToday);
//        if (oDate > oDateToday) {
//            return true;
//        }
//        */
//        return false;
//    },
//    ''
//);

//    jQuery.validator.unobtrusive.adapters.add('datefuture', {},
//    function (options) {
//        options.rules['datefuture'] = true;
//        options.messages['datefuture'] = options.message;
//    }
//);
//</script>
//<h2>@ViewBag.Title</h2>
//@using( Html.BeginForm( ) ) {
//    @Html.ValidationSummary()
//    <table width="100%">
//    <tr>
//        <td>Fecha: @Html.EditorFor( p => p.Event)</td>
//        <td>@Html.ValidationMessageFor( p => p.Event)</td>
//    </tr>

//    </table>
//    <input type="submit" value="Enviar" />
//}
