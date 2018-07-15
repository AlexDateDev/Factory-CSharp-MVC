//// ----------------------------------------------------------------------------
//// Título:    DatePastValiation - JS
////
//// Fecha:     04/07/2016
//// Autor:    Alex Solé
//// ----------------------------------------------------------------------------


///* Fecha Past ********************/
//jQuery.validator.addMethod('dataclibbpast',
//    function (value, element, params) {
//        if (!value || !value.length) {
//            // return valid if value not specified - leave that to the 'required' validator
//            return true;
//        }
//        if( Data.Validate.isDate( value ))
//        {
//            var oDate = Data.Date.toDateObject( value )
//            var oToday= Data.Date.toDateObject( Data.Date.getToday());
//            if( oDate <= oToday ){
//                return true;
//            }
//            return false;
//        }
//    },
//    ''
//);

//jQuery.validator.unobtrusive.adapters.add('dataclibbpast', {},
//    function (options) {
//        options.rules['dataclibbpast'] = true;
//        options.messages['dataclibbpast'] = options.message;
//    }
//);
