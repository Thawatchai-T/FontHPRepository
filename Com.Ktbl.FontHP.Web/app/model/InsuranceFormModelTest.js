Ext.define('FrontHPApp.model.InsuranceFormModelTest', {
    extend: 'FrontHPApp.model.InsuranceFormModel',
    alias: 'model.insuranceformmodeltest',

    requires: [
        'Ext.data.field.String',
        'Ext.data.field.Integer'
    ],

    fields: [
        {
            type: 'string',
            name: 'CompusaryInsCompany',
            mapping: 'objCom.CompusaryInsCompany'
        },
        {
            name: 'PRBPoicy',
            mapping: 'objCom.PRBPoicy'
        }
    ]
});