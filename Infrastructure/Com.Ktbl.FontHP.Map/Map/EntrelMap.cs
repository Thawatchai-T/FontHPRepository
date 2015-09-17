using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class EntrelMap : ClassMap<EntRelDomain>
    {

        public EntrelMap()
        {
            Table("ENTREL");
            LazyLoad();
            CompositeId().KeyProperty(x => x.ComId, "COM_ID")
                         .KeyProperty(x => x.EntCode, "ENTCODE");
            Map(x => x.NameTH).Column("NAME_T").Length(50);
            Map(x => x.NameENG).Column("NAME_E").Length(50);
            Map(x => x.TitleTH).Column("TITLE_T").Length(15);
            Map(x => x.TitleENG).Column("TITLE_E").Length(15);
            Map(x => x.TaxId).Column("TAX_ID").Length(15);
            Map(x => x.Contact).Column("CONTACT").Length(70);
            Map(x => x.TypeEnt).Column("TYPE_ENT").Length(1);
            Map(x => x.Mobile).Column("MOBILE").Length(50);
            Map(x => x.EMail).Column("E_MAIL").Length(50);
            Map(x => x.OthComm).Column("OTH_COMM").Length(20);
            Map(x => x.Activity).Column("ACTIVITY").Length(50);
            Map(x => x.StartDd).Column("START_DD");
            Map(x => x.IdDesc).Column("ID_DESC").Length(50);
            Map(x => x.Issued).Column("ISSUED");
            Map(x => x.Expire).Column("EXPIRE");
            Map(x => x.Race).Column("RACE").Length(12);
            Map(x => x.Nation).Column("NATION").Length(12);
            Map(x => x.Sex).Column("SEX").Length(1);
            Map(x => x.CrLine).Column("CR_LINE").Precision(12).Scale(2);
            Map(x => x.Grpcode).Column("GRPCODE").Length(15);
            Map(x => x.Cat1).Column("CAT1").Length(15);
            Map(x => x.Cat2).Column("CAT2").Length(15);
            Map(x => x.Cat3).Column("CAT3").Length(15);
            Map(x => x.Cat4).Column("CAT4").Length(15);
            Map(x => x.Cat5).Column("CAT5").Length(15);
            Map(x => x.Cat6).Column("CAT6").Length(15);
            Map(x => x.Amount1).Column("AMOUNT1").Precision(12).Scale(2);
            Map(x => x.Amount2).Column("AMOUNT2").Precision(12).Scale(2);
            Map(x => x.Amount3).Column("AMOUNT3").Precision(12).Scale(2);
            Map(x => x.Amount4).Column("AMOUNT4").Precision(12).Scale(2);
            Map(x => x.Amount5).Column("AMOUNT5").Precision(12).Scale(2);
            Map(x => x.Amount6).Column("AMOUNT6").Precision(12).Scale(2);
            Map(x => x.IssuBy).Column("ISSU_BY").Length(50);
            Map(x => x.Marital).Column("MARITAL").Length(1);
            Map(x => x.Spouse).Column("SPOUSE").Length(15);
            Map(x => x.Income).Column("INCOME").Precision(12).Scale(2);
            Map(x => x.OthInc).Column("OTH_INC").Length(60);
            Map(x => x.Mobile2).Column("MOBILE2").Length(50);
            Map(x => x.TranferBy).Column("Tranfer_BY").Length(5);
        }
    }
}