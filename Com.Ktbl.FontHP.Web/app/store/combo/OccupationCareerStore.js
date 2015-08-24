/*
 * File: app/store/combo/OccupationCatelogyStore.js
 * [200150811] Add by P2P
 * store region 
 * standard_type = '00061'
 */

Ext.define('FrontHPApp.store.combo.OccupationCareerStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.OccupationCareerStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            //autoLoad:true,
            proxy: {
                type: 'rest',
                url: 'api/common/GetOccupationType',//�觤��价�� Get  public IEnumerable<ComboBox> Get(string stdcode) ���� CommonController 
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});