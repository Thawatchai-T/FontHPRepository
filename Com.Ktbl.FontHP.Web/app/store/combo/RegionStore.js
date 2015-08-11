/*
 * File: app/store/combo/LoginStore.js
 * [200150811] Add by Woody 
 * store region 
 * standard_type = '00006'
 */

Ext.define('FrontHPApp.store.combo.RegionStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.RegionStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            autoLoad:true,
            proxy: {
                type: 'rest',
                url: 'api/common?stdcode=00006',
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});