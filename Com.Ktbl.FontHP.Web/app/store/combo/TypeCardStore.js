/*
 * File: app/store/combo/TypeCardStore.js
 * [200150814] Add by P2P 
 * store region 
 * standard_type = '00012'
 */

Ext.define('FrontHPApp.store.combo.TypeCardStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.TypeCardStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            autoLoad:true,
            proxy: {
                type: 'rest',
                url: 'api/common?stdcode=00012',
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});