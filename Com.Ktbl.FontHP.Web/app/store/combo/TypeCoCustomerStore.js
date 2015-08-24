/*
 * File: app/store/combo/TypeCoCustomerStore.js
 * [200150811] Add by P2P
 * store region 
 * standard_type = '00061'
 */

Ext.define('FrontHPApp.store.combo.TypeCoCustomerStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.TypeCoCustomerStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            autoLoad:true,
            proxy: {
                type: 'rest',
                url: 'api/common?stdcode=00147',
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});