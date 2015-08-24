/*
 * File: app/store/combo/OccupationCatelogyStore.js
 * [200150811] Add by P2P
 * store region 
 * standard_type = '00061'
 */

Ext.define('FrontHPApp.store.combo.OccupationMarryGroupStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.OccupationMarryGroupStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            proxy: {
                type: 'rest',
                url: 'api/common/GetOccupationGroup', 
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});