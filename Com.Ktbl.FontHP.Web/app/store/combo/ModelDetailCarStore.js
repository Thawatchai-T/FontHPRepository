/*
 * File: app/store/combo/ModelDetailCarStore.js
 * [200150818] Add by P2P
 * store region 
 
 */

Ext.define('FrontHPApp.store.combo.ModelDetailCarStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.ModelDetailCarStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            
            proxy: {
                type: 'rest',
                url: 'api/common/GetDetailModelCar',
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});