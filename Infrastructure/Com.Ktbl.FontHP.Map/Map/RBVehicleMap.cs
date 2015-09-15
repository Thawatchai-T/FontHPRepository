using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Ktbl.FontHP.Domain;
using FluentNHibernate.Mapping;

namespace Com.Ktbl.FontHP.Map.Map
{
    public class RBVehicleMap : ClassMap<RBVehicleDomain> {

        public RBVehicleMap()
        {
            Table("RBVehicle");
            LazyLoad();
            CompositeId().KeyProperty(x => x.EffectiveDate, "EffectiveDate")
                         .KeyProperty(x => x.VehicleKey, "VehicleKey");
            Map(x => x.SourceType).Column("Source_Type").Not.Nullable().Length(1);
            Map(x => x.BrandCode).Column("Brand_Code").Length(5);
            Map(x => x.FamilyCode).Column("Family_Code").Length(10);
            Map(x => x.MakeDescription).Column("MakeDescription").Length(30);
            Map(x => x.MakeDescriptionThai).Column("MakeDescriptionThai").Length(30);
            Map(x => x.FamilyDescription).Column("FamilyDescription").Length(30);
            Map(x => x.FamilyDescriptionThai).Column("FamilyDescriptionThai").Length(30);
            Map(x => x.VehicleTypeDescription).Column("VehicleTypeDescription").Length(50);
            Map(x => x.VehicleTypeDescriptionThai).Column("VehicleTypeDescriptionThai").Length(50);
            Map(x => x.YearGroup).Column("YearGroup").Precision(5);
            Map(x => x.MonthGroup).Column("MonthGroup").Precision(5);
            Map(x => x.SequenceNum).Column("SequenceNum").Precision(5);
            Map(x => x.Description).Column("Description").Length(100);
            Map(x => x.DescriptionThai).Column("DescriptionThai").Length(100);
            Map(x => x.CurrentRelease).Column("CurrentRelease");
            Map(x => x.ImportStatus).Column("ImportStatus").Length(100);
            Map(x => x.ImportStatusTH).Column("ImportStatusTH").Length(300);
            Map(x => x.LimitedEdition).Column("LimitedEdition");
            Map(x => x.Series).Column("Series").Length(20);
            Map(x => x.SeriesThai).Column("SeriesThai").Length(20);
            Map(x => x.BodyStyleDescription).Column("BodyStyleDescription").Length(50);
            Map(x => x.BodyStyleDescriptionThai).Column("BodyStyleDescriptionThai").Length(50);
            Map(x => x.BodyConfigDescription).Column("BodyConfigDescription").Length(50);
            Map(x => x.BodyConfigDescriptionThai).Column("BodyConfigDescriptionThai").Length(50);
            Map(x => x.BadgeDescription).Column("BadgeDescription").Length(50);
            Map(x => x.BadgeDescriptionThai).Column("BadgeDescriptionThai").Length(50);
            Map(x => x.BadgeSecondaryDescription).Column("BadgeSecondaryDescription").Length(50);
            Map(x => x.BadgeSecondaryDescriptionThai).Column("BadgeSecondaryDescriptionThai").Length(50);
            Map(x => x.ExtraIdentification).Column("ExtraIdentification").Length(20);
            Map(x => x.ExtraIdentificationthai).Column("ExtraIdentificationThai").Length(20);
            Map(x => x.GearTypeDescription).Column("GearTypeDescription").Length(50);
            Map(x => x.GearTypeDescriptionThai).Column("GearTypeDescriptionThai").Length(50);
            Map(x => x.GearNum).Column("GearNum").Precision(5);
            Map(x => x.GearLocationDescription).Column("GearLocationDescription").Length(50);
            Map(x => x.GearLocationDescriptionThai).Column("GearLocationDescriptionThai").Length(50);
            Map(x => x.DoorNum).Column("DoorNum").Precision(5);
            Map(x => x.SeatCapacity).Column("SeatCapacity").Precision(5);
            Map(x => x.EngineSize).Column("EngineSize").Precision(10);
            Map(x => x.EngineDescription).Column("EngineDescription").Length(4);
            Map(x => x.Cylinders).Column("Cylinders").Precision(5);
            Map(x => x.DriveDescription).Column("DriveDescription").Length(50);
            Map(x => x.DriveDescriptionThai).Column("DriveDescriptionThai").Length(50);
            Map(x => x.InductionDescription).Column("InductionDescription").Length(50);
            Map(x => x.InductionDescriptionThai).Column("InductionDescriptionThai").Length(50);
            Map(x => x.FuelDeliveryDescription).Column("FuelDeliveryDescription").Length(50);
            Map(x => x.FuelDeliveryDescriptionThai).Column("FuelDeliveryDescriptionThai").Length(50);
            Map(x => x.MethodOfDeliveryDescription).Column("MethodOfDeliveryDescription").Length(50);
            Map(x => x.MethodOfDeliveryDescriptionThai).Column("MethodOfDeliveryDescriptionThai").Length(50);
            Map(x => x.FuelTypeDescription).Column("FuelTypeDescription").Length(50);
            Map(x => x.FuelTypeDescriptionThai).Column("FuelTypeDescriptionThai").Length(50);
            Map(x => x.CamDescription).Column("CamDescription").Length(50);
            Map(x => x.CamDescriptionThai).Column("CamDescriptionThai").Length(50);
            Map(x => x.Power).Column("Power").Precision(16).Scale(2);
            Map(x => x.PowerRPMFrom).Column("PowerRPMFrom").Precision(10);
            Map(x => x.PowerRPMTo).Column("PowerRPMTo").Precision(10);
            Map(x => x.Torque).Column("Torque").Precision(10);
            Map(x => x.TorqueRPMFrom).Column("TorqueRPMFrom").Precision(10);
            Map(x => x.TorqueRPMTo).Column("TorqueRPMTo").Precision(10);
            Map(x => x.WheelBase).Column("WheelBase").Precision(10);
            Map(x => x.GrossVehicleMass).Column("GrossVehicleMass").Precision(10);
            Map(x => x.PayLoad).Column("PayLoad").Precision(10);
            Map(x => x.GrossCombinationMass).Column("GrossCombinationMass").Precision(10);
            Map(x => x.KerbWeight).Column("KerbWeight").Precision(10);
            Map(x => x.TareMass).Column("TareMass").Precision(10);
            Map(x => x.AverageKM).Column("AverageKM").Precision(10);
            Map(x => x.GoodKM).Column("GoodKM").Precision(10);
            Map(x => x.AvgWholesale).Column("AvgWholesale").Precision(10);
            Map(x => x.AvgRetail).Column("AvgRetail").Precision(10);
            Map(x => x.GoodWholesale).Column("GoodWholesale").Precision(10);
            Map(x => x.GoodRetail).Column("GoodRetail").Precision(10);
            Map(x => x.NewPrice).Column("NewPrice").Precision(10);
            Map(x => x.ModelNo).Column("Model_No").Length(50);
            Map(x => x.Active).Column("Active").Not.Nullable();
            Map(x => x.CreateDate).Column("Create_Date");
            Map(x => x.CreateUser).Column("Create_User").Length(20);
            Map(x => x.ModifyDate).Column("Modify_Date");
            Map(x => x.ModifyUser).Column("Modify_User").Length(20);
            Map(x => x.EngineTypeDescription).Column("EngineTypeDescription").Length(50);
            Map(x => x.EngineTypeDescriptionThai).Column("EngineTypeDescriptionThai").Length(50);
            Map(x => x.FuelCapacity).Column("FuelCapacity").Precision(10);
            Map(x => x.Height).Column("Height").Precision(10);
            Map(x => x.Length).Column("Length").Precision(10);
            Map(x => x.Width).Column("Width").Precision(10);
        }
    }
}