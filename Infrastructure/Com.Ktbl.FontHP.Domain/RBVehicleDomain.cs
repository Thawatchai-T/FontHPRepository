using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ktbl.FontHP.Domain
{
    public class RBVehicleDomain
    {
        public virtual DateTime EffectiveDate { get; set; }
        public virtual string VehicleKey { get; set; }
        public virtual string SourceType { get; set; }
        public virtual string BrandCode { get; set; }
        public virtual string FamilyCode { get; set; }
        public virtual string MakeDescription { get; set; }
        public virtual string MakeDescriptionThai { get; set; }
        public virtual string FamilyDescription { get; set; }
        public virtual string FamilyDescriptionThai { get; set; }
        public virtual string VehicleTypeDescription { get; set; }
        public virtual string VehicleTypeDescriptionThai { get; set; }
        public virtual short? YearGroup { get; set; }
        public virtual short? MonthGroup { get; set; }
        public virtual short? SequenceNum { get; set; }
        public virtual string Description { get; set; }
        public virtual string DescriptionThai { get; set; }
        public virtual bool? CurrentRelease { get; set; }
        public virtual string ImportStatus { get; set; }
        public virtual string ImportStatusTH { get; set; }
        public virtual bool? LimitedEdition { get; set; }
        public virtual string Series { get; set; }
        public virtual string SeriesThai { get; set; }
        public virtual string BodyStyleDescription { get; set; }
        public virtual string BodyStyleDescriptionThai { get; set; }
        public virtual string BodyConfigDescription { get; set; }
        public virtual string BodyConfigDescriptionThai { get; set; }
        public virtual string BadgeDescription { get; set; }
        public virtual string BadgeDescriptionThai { get; set; }
        public virtual string BadgeSecondaryDescription { get; set; }
        public virtual string BadgeSecondaryDescriptionThai { get; set; }
        public virtual string ExtraIdentification { get; set; }
        public virtual string ExtraIdentificationthai { get; set; }
        public virtual string GearTypeDescription { get; set; }
        public virtual string GearTypeDescriptionThai { get; set; }
        public virtual short? GearNum { get; set; }
        public virtual string GearLocationDescription { get; set; }
        public virtual string GearLocationDescriptionThai { get; set; }
        public virtual short? DoorNum { get; set; }
        public virtual short? SeatCapacity { get; set; }
        public virtual int? EngineSize { get; set; }
        public virtual string EngineDescription { get; set; }
        public virtual short? Cylinders { get; set; }
        public virtual string DriveDescription { get; set; }
        public virtual string DriveDescriptionThai { get; set; }
        public virtual string InductionDescription { get; set; }
        public virtual string InductionDescriptionThai { get; set; }
        public virtual string FuelDeliveryDescription { get; set; }
        public virtual string FuelDeliveryDescriptionThai { get; set; }
        public virtual string MethodOfDeliveryDescription { get; set; }
        public virtual string MethodOfDeliveryDescriptionThai { get; set; }
        public virtual string FuelTypeDescription { get; set; }
        public virtual string FuelTypeDescriptionThai { get; set; }
        public virtual string CamDescription { get; set; }
        public virtual string CamDescriptionThai { get; set; }
        public virtual double? Power { get; set; }
        public virtual int? PowerRPMFrom { get; set; }
        public virtual int? PowerRPMTo { get; set; }
        public virtual int? Torque { get; set; }
        public virtual int? TorqueRPMFrom { get; set; }
        public virtual int? TorqueRPMTo { get; set; }
        public virtual int? WheelBase { get; set; }
        public virtual int? GrossVehicleMass { get; set; }
        public virtual int? PayLoad { get; set; }
        public virtual int? GrossCombinationMass { get; set; }
        public virtual int? KerbWeight { get; set; }
        public virtual int? TareMass { get; set; }
        public virtual int? AverageKM { get; set; }
        public virtual int? GoodKM { get; set; }
        public virtual int? AvgWholesale { get; set; }
        public virtual int? AvgRetail { get; set; }
        public virtual int? GoodWholesale { get; set; }
        public virtual int? GoodRetail { get; set; }
        public virtual int? NewPrice { get; set; }
        public virtual string ModelNo { get; set; }
        public virtual bool Active { get; set; }
        public virtual DateTime? CreateDate { get; set; }
        public virtual string CreateUser { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual string ModifyUser { get; set; }
        public virtual string EngineTypeDescription { get; set; }
        public virtual string EngineTypeDescriptionThai { get; set; }
        public virtual int? FuelCapacity { get; set; }
        public virtual int? Height { get; set; }
        public virtual int? Length { get; set; }
        public virtual int? Width { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            var t = obj as RBVehicleDomain;
            if (t == null) return false;
            if (EffectiveDate == t.EffectiveDate
             && VehicleKey == t.VehicleKey)
                return true;

            return false;
        }
        public override int GetHashCode()
        {
            int hash = GetType().GetHashCode();
            hash = (hash * 397) ^ EffectiveDate.GetHashCode();
            hash = (hash * 397) ^ VehicleKey.GetHashCode();

            return hash;
        }
        #endregion
    }
}