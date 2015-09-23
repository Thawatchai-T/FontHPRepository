using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain.Request;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map.Request
{
    public class RequestPaydealerMap : ClassMap<RequestPaydealerDomain>
    {

        public RequestPaydealerMap()
        {
            Table("Request_PayDealer");
            LazyLoad();
            //Map(x => x.RequestNo).Column("Request_No").Not.Nullable().Length(10);
            Id(x => x.RequestNo).GeneratedBy.Assigned().Column("Request_No");
            Map(x => x.MktCode).Column("Mkt_Code").Length(5);
            Map(x => x.MktName).Column("Mkt_Name").Length(50);
            Map(x => x.DealerCode).Column("Dealer_Code").Length(20);
            Map(x => x.ComAmt).Column("Com_Amt").Precision(13).Scale(2);
            Map(x => x.ComLoan).Column("Com_Loan").Precision(13).Scale(2);
            Map(x => x.ComTotal).Column("Com_Total").Precision(13).Scale(2);
            Map(x => x.ComTrs).Column("Com_Trs").Precision(13).Scale(2);
            Map(x => x.ComWhtRate).Column("Com_Wht_Rate").Precision(13).Scale(2);
            Map(x => x.ComWhtAmt).Column("Com_Wht_Amt").Precision(13).Scale(2);
            Map(x => x.ComNet).Column("Com_Net").Precision(13).Scale(2);
            Map(x => x.ComVat).Column("Com_Vat").Precision(13).Scale(2);
            Map(x => x.ComIncVat).Column("Com_Inc_Vat").Precision(13).Scale(2);
            Map(x => x.ComIncVatLoan).Column("Com_Inc_Vat_Loan").Precision(13).Scale(2);
            Map(x => x.Comtype).Column("ComType").Length(1);
            Map(x => x.FlagSendacc).Column("Flag_SendAcc");
            Map(x => x.SendaccDate).Column("SendAcc_Date");
            Map(x => x.ComDd).Column("COM_DD");
            Map(x => x.SendaccBy).Column("SendAcc_By").Length(20);
            Map(x => x.FlagPay).Column("Flag_Pay");
            Map(x => x.FlagPrinttax).Column("Flag_PrintTax");
            Map(x => x.PaidDate).Column("Paid_Date");
            Map(x => x.PrinttaxBy).Column("PrintTax_By").Length(20);
            Map(x => x.Bank).Column("Bank").Length(10);
            Map(x => x.Branch).Column("Branch").Length(50);
            Map(x => x.Accountno).Column("AccountNo").Length(50);
            Map(x => x.Typeent).Column("TypeENT").Length(5);
            Map(x => x.CarType01).Column("Car_Type01").Length(10);
            Map(x => x.CarType03).Column("Car_Type03").Length(10);
            Map(x => x.CarTypevan).Column("Car_TypeVAN").Length(10);
            Map(x => x.CreateDate).Column("Create_Date");
            Map(x => x.CreateUser).Column("Create_User").Length(20);
            Map(x => x.ModifyDate).Column("Modify_Date");
            Map(x => x.ModifyUser).Column("Modify_User").Length(20);
            Map(x => x.Active).Column("Active");
        }
    }
}
