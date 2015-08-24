/*
 * File: app/store/combo/TypeAddressStore.js
 * [200150814] Add by P2P 
 * store region 
 * standard_type = '00013'
 */

Ext.define('FrontHPApp.store.combo.TypeAddressStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.TypeAddressStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            autoLoad:true,
            proxy: {
                type: 'rest',
                url: 'api/common?stdcode=00013',
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});