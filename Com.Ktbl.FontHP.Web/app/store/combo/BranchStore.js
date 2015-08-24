/*
 * File: app/store/combo/BranchStore.js
 * [200150811] Add by P2P
 * store region 
 * standard_type = '00061'
 */

Ext.define('FrontHPApp.store.combo.BranchStore', {
    extend: 'Ext.data.Store',

    requires: [
        'Ext.data.proxy.Memory',
        'Ext.data.reader.Json'
    ],

    constructor: function (cfg) {
        var me = this;
        cfg = cfg || {};
        me.callParent([Ext.apply({
            storeId: 'combo.BranchStore',
            //fields: ['id', 'Name'],
            //FrontHPApp.model.CommonModel,
            model: 'FrontHPApp.model.CommonModel',
            autoLoad:true,
            proxy: {
                type: 'rest',
                url: 'api/common?stdcode=00061',//ส่งค่าไปที่ Get  public IEnumerable<ComboBox> Get(string stdcode) ในไฟล์ CommonController 
                reader: {
                    type: 'json'
                }
            }
        }, cfg)]);
    }
});