/*
 * File: app/view/main/mainmarketing/MktLimit60Tab.js
 *
 * This file was generated by Sencha Architect version 3.2.0.
 * http://www.sencha.com/products/architect/
 *
 * This file requires use of the Ext JS 5.1.x library, under independent license.
 * License of Sencha Architect does not include license for Ext JS 5.1.x. For more
 * details see http://www.sencha.com/license or contact license@sencha.com.
 *
 * This file will be auto-generated each and everytime you save your project.
 *
 * Do NOT hand edit this file.
 */

Ext.define('FrontHPApp.view.main.mainmarketing.MktLimit60Tab', {
    extend: 'Ext.panel.Panel',
    alias: 'widget.mainmainmarketingmktlimit60tab',

    requires: [
        'FrontHPApp.view.main.mainmarketing.MktLimit60TabViewModel',
        'FrontHPApp.view.main.mainmarketing.MktLimit60TabViewController',
        'Ext.form.Panel',
        'Ext.form.field.ComboBox',
        'Ext.toolbar.Paging',
        'Ext.grid.Panel',
        'Ext.view.Table',
        'Ext.grid.column.RowNumberer',
        'Ext.button.Button',
        'Ext.selection.CheckboxModel'
    ],

    controller: 'mainmainmarketingmktlimit60tab',
    viewModel: {
        type: 'mainmainmarketingmktlimit60tab'
    },
    minHeight: 600,
    layout: 'border',
    manageHeight: false,

    dockedItems: [
        {
            xtype: 'form',
            dock: 'top',
            reference: 'form',
            itemId: 'myform1',
            title: '',
            layout: {
                type: 'hbox',
                pack: 'center'
            },
            items: [
                {
                    xtype: 'panel',
                    width: '100%',
                    defaults: {
                        labelAlign: 'right',
                        labelWidth: 190
                    },
                    iconCls: 'icon-details',
                    title: 'ยืนยันคำขอเกิน 60 วัน',
                    layout: {
                        type: 'table',
                        columns: 1
                    },
                    items: [
                        {
                            xtype: 'combobox',
                            margin: '5 0 0 0',
                            fieldLabel: 'สาขา',
                            labelWidth: 50,
                            emptyText: 'เลือก',
                            displayField: 'Name',
                            store: 'combo.BranchStore',
                            valueField: 'id',
                            listeners: {
                                select: 'onComboboxBranchSelect'
                            }
                        }
                    ]
                }
            ]
        },
        {
            xtype: 'pagingtoolbar',
            dock: 'bottom',
            displayInfo: true,
            store: 'cancelRequestLimit60Models'
        }
    ],
    items: [
        {
            xtype: 'gridpanel',
            region: 'center',
            split: false,
            collapsible: false,
            store: 'cancelRequestLimit60Models',
            viewConfig: {
                height: 50
            },
            columns: [
                {
                    xtype: 'rownumberer',
                    width: 45,
                    align: 'center',
                    text: '#',
                    tooltip: 'ลำดับ'
                },
                {
                    xtype: 'gridcolumn',
                    renderer: function(value, metaData, record, rowIndex, colIndex, store, view) {
                        return Ext.Date.format(value, 'd/m/Y');
                    },
                    width: '',
                    dataIndex: 'RequestDate',
                    text: 'วันที่คำขอ',
                    name:'RequestDate'
                },
                {
                    xtype: 'gridcolumn',
                    dataIndex: 'RequestNo',
                    text: 'เลขที่คำขอ',
                    name:'RequestNo',
                    
                },
                {
                    xtype: 'gridcolumn',
                    dataIndex: 'RequestStatus',
                    text: 'สถานะคำขอ',
                    name: 'RequestStatus',
                    flex: -1
                },
                {
                    xtype: 'gridcolumn',
                    dataIndex: 'DayNum',
                    name: 'DayNum',
                    text: 'จำนวนวัน'
                },

                {
                xtype: 'gridcolumn',
                dataIndex: 'BranchId',
                name: 'BranchId',
                text: 'รหัสสาขา(ไม่มี)',
                reference: 'branchid',
                }
            ],
            dockedItems: [
                {
                    xtype: 'toolbar',
                    dock: 'top',
                    items: [
                        {
                            xtype: 'button',
                            margin: '10 10 10 10',
                            ui: 'default-small',
                            width: 100,
                            iconCls: 'icon-save',
                            text: 'บันทึก',
                            listeners: {
                                click: 'onSaveClick'
                            }
                        }
                    ]
                }
            ],
            selModel: {
                selType: 'checkboxmodel'
            },
            listeners: {
                itemdblclick: 'onGridpanelItemDblClick'
            }
        }
    ]

});