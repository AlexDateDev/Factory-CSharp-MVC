// ----------------------------------------------------------------------------
// Título:        PhoneValidation - JS
//
// Fecha:        04/07/2016
// Autor:        Alex Solé
// Versión:        1.0.0
// Dependencias:
// ----------------------------------------------------------------------------


/* Telephone ************/
jQuery.validator.addMethod('telephone',
    function (value, element, params) {
        if (!value || !value.length) {
            // return valid if value not specified - leave that to the 'required' validator
            return true;
        }
        var phonePattern = /([9|6])+[0-9]{8}/;
        return phonePattern.test(value);
    },
    ''
);

jQuery.validator.unobtrusive.adapters.add('telephone', {},
    function (options) {
        options.rules['telephone'] = true;
        options.messages['telephone'] = options.message;
    }
);
