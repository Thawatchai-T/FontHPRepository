Ext.define('FrontHPApp.model.InsuranceFormModel', {
    extend: 'Ext.data.Model',
    alias: 'model.insuranceformmodel',

    requires: [
        'Ext.data.field.String',
        'Ext.data.field.Integer'
    ],

    fields: [
        {
            type: 'string',
            name: 'Customer',
            mapping: 'objIns.Customer'
        },
        {
            name: 'InsuranceBy'
        },
        {
            name: 'ConditionInsurance'
        },
        {
            name: 'InsuranceCompany'
        },
        {
            name: 'NoticeNo'
        },
        {
            name: 'NoticeBy'
        },
        {
            type: 'string',
            name: 'NotiDate'
        },
        {
            name: 'PoicyNo'
        },
        {
            type: 'string',
            name: 'SSStart'
        },
        {
            type: 'string',
            name: 'SSEnd'
        },
        {
            type: 'int',
            name: 'SSCost'
        },
        {
            type: 'int',
            name: 'SSFee'
        },
        {
            type: 'int',
            name: 'WHInsFee'
        },
        {
            type: 'int',
            name: 'Stamp'
        },
        {
            type: 'int',
            name: 'SSFeeCoect'
        },
        {
            name: 'Deduct'
        },
        {
            name: 'Driver'
        },
        {
            name: 'WhereRepair'
        },
        {
            name: 'DriverName1'
        },
        {
            type: 'string',
            name: 'DriverBirth1'
        },
        {
            name: 'DrivingC1'
        },
        {
            name: 'DriverName2'
        },
        {
            type: 'string',
            name: 'DriverBirth2'
        },
        {
            name: 'DrivingC2'
        },
        {
            name: 'SSCampaign'
        },
        {
            type: 'int',
            name: 'SSComm'
        },
        {
            type: 'int',
            name: 'SSDiscount'
        },
        {
            type: 'int',
            name: 'SSPromotion'
        },
        {
            type: 'int',
            name: 'SSPromotionDiscount'
        },
        //Prb
        //{
        //    name: 'CompusaryInsCompany'

        //}

    ]
});