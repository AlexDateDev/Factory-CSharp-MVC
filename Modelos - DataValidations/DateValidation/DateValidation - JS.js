// ----------------------------------------------------------------------------
// Título:        DateValidation - JS
//
// Fecha:        04/07/2016
// Autor:        Alex Solé
// Versión:        1.0.0
// Dependencias:
// ----------------------------------------------------------------------------

/* Fecha correcta **********************/
jQuery.validator.addMethod('dataclibb',
    function (value, element, params) {
        if (!value || !value.length) {
            // return valid if value not specified - leave that to the 'required' validator
            return true;
        }
        return Data.Validate.isDate( value );
    },
    ''
);

jQuery.validator.unobtrusive.adapters.add('dataclibb', {},
    function (options) {
        options.rules['dataclibb'] = true;
        options.messages['dataclibb'] = options.message;
    }
);
