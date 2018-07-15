// ----------------------------------------------------------------------------
// Título:        EmailValidation - JS
//
// Fecha:        04/07/2016
// Autor:        Alex Solé
// Versión:        1.0.0
// Dependencias:
// ----------------------------------------------------------------------------

/* Email */
jQuery.validator.unobtrusive.adapters.add("email", function (rule) {
    var message = rule.Message;

    return function (value, context) {

        if (!value || !value.length) {
            // return valid if value not specified - leave that to the 'required' validator
            return true;
        }

        var emailPattern = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/;
        return emailPattern.test(value);
    };
});
