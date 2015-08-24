/*
 * File: app/store/combo/PayDeductStore.js
 * [200150814] Add by P2P 
 * store region 
 * standard_type = '00028'
 */

Ext.define('FrontHPApp.store.combo.PayDeductStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.PayDeductStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            autoLoad:true,
            proxy: {
                type: 'rest',
                url: 'api/common?stdcode=00034',
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});