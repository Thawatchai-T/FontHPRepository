/*
 * File: app/store/combo/OccupationCatelogyStore.js
 * [200150811] Add by P2P
 * store region 
 * standard_type = '00061'
 */

Ext.define('FrontHPApp.store.combo.OccupationGroupStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.OccupationGroupStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            proxy: {
                type: 'rest',
                url: 'api/common/GetOccupationGroup',//ส่งค่าไปที่ Get  public IEnumerable<ComboBox> Get(string stdcode) ในไฟล์ CommonController 
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});