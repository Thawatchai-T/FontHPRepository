/*
 * File: app/store/combo/CreditStore.js
 * [200150814] Add by P2P 
 * store region 
 * standard_type = '00126'
 */

Ext.define('FrontHPApp.store.combo.CreditStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.CreditStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            autoLoad:true,
            proxy: {
                type: 'rest',
                url: 'api/common?stdcode=00126',
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});