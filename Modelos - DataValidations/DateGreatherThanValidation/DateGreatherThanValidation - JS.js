// ----------------------------------------------------------------------------
// Título:        DateGreatherThanValidation - JS
//
// Fecha:        04/07/2016
// Autor:        Alex Solé
// Versión:        1.0.0
// Dependencias:
// ----------------------------------------------------------------------------

/* Fecha mayor que *************************/
$.validator.addMethod("clibbgreaterthan", function (value, element, params) {
        var dtBegin = $(params).val();
        dtBegin = dtBegin.split(" ")[0]; // Eliminamos las horas (si existes)
        var dtEnd = value;
        dtEnd = dtEnd.split(" ")[0]; // Eliminamos las horas (si existes)
        if( !dtBegin || !dtEnd){
            return true;
        }
        var oDateBegin = Data.Date.toDateObject( dtBegin);
        var oDateEnd = Data.Date.toDateObject( dtEnd );

        if( oDateEnd >= oDateBegin ){
            return true;
        }
        return false;
    });

$.validator.unobtrusive.adapters.add("clibbgreaterthan", ["otherpropertyname"], function (options) {
        options.rules["clibbgreaterthan"] = "#" + options.params.otherpropertyname;
        options.messages["clibbgreaterthan"] = options.message;
    });
