/*
 * File: app/store/combo/OtherPaperStore.js
 * [200150819] Add by P2P
 * store region 
 
 */

Ext.define('FrontHPApp.store.combo.OtherPaperStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.OtherPaperStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            autoLoad:true,
            proxy: {
                type: 'rest',
                url: 'api/common?stdcode=00155',
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});