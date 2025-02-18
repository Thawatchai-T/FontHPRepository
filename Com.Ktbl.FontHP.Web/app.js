/*
 * File: app.js
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

// @require @packageOverrides
Ext.Loader.setConfig({

});


Ext.application({
    models: [
        'LoginModel',
        'TestModel',
        'GarantureModel',
        'SubsidyViewModel',
        'RequestStatusModel',
        'BranchModel',
        'RequestModel',
        'HistoryCheckDocumentModel',
        'CheckPaperModel',
        'CancelRequestLimit60Model',
        'TypePaperModel',
        'BrowsePaperMyModel',
        'CommonModel',
        'ProvinceModel',
        'DistrictModel',
        'SubDistrictModel',
        'OccupationCatelogyModel',
        'OccupationGroupModel',
        'OccupationTypeModel',
        'PositionModel',
        'IncomeMainModel',
        'IncomeSubModel',
        'IncomeOtherModel',
        'GurantorGridModel',
        'GaranterOccupationCatelogyModel',
        'GaranterOccupationGroupModel',
        'CommitinSpecialModel',
        'TypeCardModel',
        'SunsidyModel',
        'StatusModel',
        'JobIndex',
        'GridLeadModel',
        'MarketModel',
        'DealerSelectModel',
        'AddressCusModel',
        'TypePopupCardModel',
        'ComHirModel',
        'ComInsModel',
        'TypeCustomerModel',
        'AddressCusFormModel',
        //insert model 20150904
        'GarantorFormModel',
        'CardTypeTabFormModel',
        //insert model 20150908
        'ComHiringFormModel',
        'ComInsFormModel',
        'ComSpacialFormModel',

        'Insurance.LoanProtectionModel',
        'Insurance.InsuranceModel',
        'Insurance.CompulsoryModel',


    ],
    stores: [
        'combo.LoginStore',
        'combo.TestStore',
        'RequestStatusStores',
        'BranchStore',
        'requestModels',
        'historyCheckDocumentModels',
        'checkPaperModels',
        'cancelRequestLimit60Models',
        'typePaperModels',
        'browsePaperMyModels',
        'commonModels',
        'provinceModels',
        'districtModels',
        'subDistrictModels',
        'occupationCatelogyModels',
        'occupationGroupModels',
        'occupationTypeModels',
        'positionModels',
        'incomeMainModels',
        'incomeSubModels',
        'incomeOtherModels',
        'gurantorGridModels',
        'commitinSpecialModels',
        'typeCardModels',
        'sunsidyModels',
        'statusModels',
        'gridLeadModels',
        'marketModels',
        'dealerSelectModels',
        'addressCusModels',
        'typePopupCardModels',
        'comHirModels',
        'comInsModels',
        'typeCustomerModels',
        /*
        * [20150811] Add by Woody 
        * combo box 
        */
        'combo.RegionStore',
       // [20150811] Add by P2P
        'combo.RequestStatusStore',
        'combo.BranchStore',
        'combo.TitleStore',
        'combo.TypeRequestNoStore',
        'combo.DepositSalaryStore',
        'combo.CreditStore',
        'combo.CompanyInsuranceStore',
        'combo.CarVatStore',
        'combo.MethodPaymentStore',
        'combo.MethodTermtStore',
        'combo.RelationCustomerStore',
        'combo.ColorStore',
        'combo.MachineStore',
        'combo.GearStore',
        //��Сѹ���
        'combo.TellInsuranceStore',
        'combo.ConditionInsuranceStore',
        'combo.TypeInsurancewantStore',
        'combo.TypeInsuranceProtectStore',
        //�ѵ�
        'combo.TypeCardStore',
        'combo.PayDeductStore',
        'combo.ListSubsidyStore',
        //�������
        'combo.TypeAddressStore',
        //Group Position
        'combo.OccupationCatelogyStore',
        'combo.OccupationGroupStore',
        'combo.OccupationCareerStore',
        'combo.PositionStore',
        //Group Carre
        'combo.MainCareerStore',
        'combo.SubCareerStore',
        //Dummy Car
        'combo.BrandCarStore',
        'combo.ModelCarStore',
        'combo.ModelDetailCarStore',
        //20150818 insert standradcode to table
        'combo.MarryStore',
        'combo.TypeResidenceStore',
        'combo.AdressByHomeStore',
        'combo.StatusByHomeStore',
        'combo.OccupationCareerOtherStore',
        'combo.TypeCarStore',
        'combo.TypeCoCustomerStore',
        'combo.PerfomanceCarStore',
        'combo.OccupationMarryGroupStore',
        'combo.AbsorbTaxStore',
        'combo.LostInsuranceStore',
        'combo.RepairStore',
        //20150819
        'combo.TypeCustomerStore',
        'combo.OtherPaperStore',
        //
        'combo.CarYearStore'

       



    ],
    views: [
        'main.MainViewport',
        'main.mainmarketing.window.CommHiringWindow',
        'main.mainmarketing.MarketingTab',
        'main.mainmarketing.window.GarantorWindow',
        'main.mainmarketing.window.TypeCardWindow',
        'main.mainmarketing.window.SubsidyWindow',
        'main.mainmarketing.window.StatusInfoWindow',
        //'Tab1.window.FrmCreditNode',
        'main.maincheckdoc.CheckDocumentTab',
        //'Tab2.window.FrmPopupBrowsePaper',
        'main.maincheckdoc.DocumentHistoryTab',
        //'Tab2.window.FrmBrowseFileCheck',
        //'MyForm1',
       // 'MyGridPanel1',
        'main.mainmarketing.window.CommInsWindow',
        'main.mainmarketing.window.comspecial.ComSpecialWindow',
        'main.mainmarketing.WindowMainApp',
        'main.home.Indox',
        'main.mainmarketing.window.comspecial.PopupEmpSell',
        'main.mainmarketing.MktLimit60Tab',
        'main.mainmarketing.window.commonpopup.PopupCusAddress',
        'main.mainmarketing.window.commonpopup.PopupDealer',
        'main.mainmarketing.window.commonpopup.PopupTypeCard',
        'main.mainmarketing.window.requestcustomer.popup.PopupBranch',
        //edit name
        'main.mainmarketing.window.requestcustomer.RequestCustomerWindow',
        'main.mainmarketing.window.requestcustomer.popup.PopupLead',
        'main.mainmarketing.window.requestcustomer.popup.PopupMarketing',
        'main.mainmarketing.window.CustomeraddressWindow',
        'main.mainmarketing.window.InsuranceWindow',
        'main.mainmarketing.window.LeadWindow'
    ],
    name: 'FrontHPApp',

    launch: function() {
        Ext.create('FrontHPApp.view.main.MainViewport');
    }

});
