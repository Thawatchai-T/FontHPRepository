using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    class LeadMktMap : ClassMap<LeadMktDomain>
    {

        public LeadMktMap()
        {
            Table("Lead_Mkt");
            LazyLoad();
            Id(x => x.MktCode).GeneratedBy.Assigned().Column("MktCode");
            Map(x => x.MktName).Column("MktName").Length(200);
            Map(x => x.MktHead).Column("MktHead").Length(15);
            Map(x => x.FlagAssign).Column("FlagAssign");
            Map(x => x.EmpGroup).Column("EmpGroup").Length(5);
            Map(x => x.EmpId).Column("EmpID").Length(14);
            Map(x => x.TelContact).Column("Tel_Contact").Length(50);
            Map(x => x.TelPerson).Column("Tel_Person").Length(100);
            Map(x => x.IsLeadMail).Column("Is_LeadMail");
            Map(x => x.LeadMailName).Column("LeadMail_Name").Length(100);
            Map(x => x.TelNumber).Column("Tel_Number").Length(100);
            Map(x => x.StartWork).Column("StartWork");
            Map(x => x.ExpWork).Column("ExpWork");
            Map(x => x.Tablet).Column("Tablet");
            Map(x => x.RTNDate).Column("RTNDate");
            Map(x => x.SerialNo).Column("Serial_No").Length(100);
            Map(x => x.MktStatus).Column("MktStatus").Length(20);
            Map(x => x.MktNickName).Column("MktNickName").Length(50);
            Map(x => x.LevelGroup).Column("LevelGroup").Precision(10);
            Map(x => x.SubGroup).Column("SubGroup").Length(2);
            Map(x => x.Branch).Column("Branch").Length(100);
            Map(x => x.BranchK).Column("Branch_K").Length(14);
            Map(x => x.CreateDate).Column("Create_Date");
            Map(x => x.CreateUser).Column("Create_User").Length(10);
            Map(x => x.ModifyDate).Column("Modify_Date");
            Map(x => x.ModifyUser).Column("Modify_User").Length(10);
            Map(x => x.IsActive).Column("Active");
            Map(x => x.Userad).Column("USERAD").Length(20);
        }
    }
}