using System;

namespace Pims.Dal.Entities.Views
{
    /// <summary>
    /// Property class, provides a model that represents a view in the database.
    /// </summary>
    public class Property
    {
        #region Properties
        /// <summary>
        /// get/set - The primary key IDENTITY SEED.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// get/set - The property type [0=Parcel, 1=Building].
        /// </summary>
        public PropertyTypes PropertyTypeId { get; set; }

        /// <summary>
        /// get/set - The RAEG/SPP project number.
        /// </summary>
        public string ProjectNumber { get; set; }

        /// <summary>
        /// get/set - The foreign key to the property status.
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// get/set - The status for this property.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// get/set - The foreign key to the property classification.
        /// </summary>
        public int ClassificationId { get; set; }

        /// <summary>
        /// get/set - The classification for this property.
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// get/set - The foreign key to the agency that owns this property.
        /// </summary>
        public int AgencyId { get; set; }

        /// <summary>
        /// get/set - The agency this property belongs to.
        /// /summary>
        public string Agency { get; set; }

        /// <summary>
        /// get/set - The property description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// get/set - The foreign key to the property address.
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// get/set - The address for this property.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// get/set - The address for this property.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// get/set - The address for this property.
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// get/set - The address for this property.
        /// </summary>
        public string Postal { get; set; }

        /// <summary>
        /// get/set - The Latitude co-ordinate.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// get/set - The longitude co-ordinate.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// get/set - Whether this property is considered sensitive and should only be visible to users who are part of the owning agency.
        /// </summary>
        public bool IsSensitive { get; set; }

        #region Financials
        /// <summary>
        /// get/set - The most recent estimate.
        /// </summary>
        public decimal Estimated { get; set; }

        /// <summary>
        /// get/set - The fiscal year estimate.
        /// </summary>
        public int? EstimatedFiscalYear { get; set; }

        /// <summary>
        /// get/set - The most recent netbook value.
        /// </summary>
        public decimal NetBook { get; set; }

        /// <summary>
        /// get/set - The fiscal year netbook value.
        /// </summary>
        public int? NetBookFiscalYear { get; set; }

        /// <summary>
        /// get/set - The most recent assessment.
        /// </summary>
        public decimal Assessed { get; set; }

        /// <summary>
        /// get/set - When the assessment was completed.
        /// </summary>
        public DateTime? AssessedDate { get; set; }

        /// <summary>
        /// get/set - The most recent appraisal.
        /// </summary>
        public decimal Appraised { get; set; }

        /// <summary>
        /// get/set - When the appraisal was completed.
        /// </summary>
        public DateTime? AppraisedDate { get; set; }
        #endregion

        #region Parcel Properties
        /// <summary>
        /// get/set - The property identification number for Titled land.
        /// </summary>
        public int PID { get; set; }

        /// <summary>
        /// get - The friendly formated Parcel Id.
        /// </summary>
        public string ParcelIdentity { get { return this.PID > 0 ? $"{this.PID:000-000-000}" : null; } }

        /// <summary>
        /// get/set - The property identification number of Crown Lands Registry that are not Titled.
        /// </summary>
        /// <value></value>
        public int? PIN { get; set; }

        /// <summary>
        /// get/set - The land area.
        /// </summary>
        public float LandArea { get; set; }

        /// <summary>
        /// get/set - The land legal description.
        /// </summary>
        public string LandLegalDescription { get; set; }

        /// <summary>
        /// get/set - The municipality the parcel belongs to.
        /// </summary>
        public string Municipality { get; set; }

        /// <summary>
        /// get/set - Current Parcel zoning information
        /// </summary>
        public string Zoning { get; set; }

        /// <summary>
        /// get/set - Potential future Parcel zoning information
        /// </summary>
        public string ZoningPotential { get; set; }
        #endregion

        #region Building Properties
        /// <summary>
        /// get/set - The local identification number.
        /// </summary>
        public string LocalId { get; set; }

        /// <summary>
        /// get/set - The foreign key to the property building construction type.
        /// </summary>
        public int BuildingConstructionTypeId { get; set; }

        /// <summary>
        /// get/set - The building construction type for this property.
        /// </summary>
        public string BuildingConstructionType { get; set; }

        /// <summary>
        /// get/set - The number of floors in the building.
        /// </summary>
        public int BuildingFloorCount { get; set; }

        /// <summary>
        /// get/set - The foreign key to the building predominant use.
        /// </summary>
        public int BuildingPredominateUseId { get; set; }

        /// <summary>
        /// get/set - The building predominant use for this building.
        /// </summary>
        public string BuildingPredominateUse { get; set; }

        /// <summary>
        /// get/set - The type of tenancy for this building.
        /// </summary>
        public string BuildingTenancy { get; set; }

        /// <summary>
        /// get/set - The building rentable area.
        /// </summary>
        public float RentableArea { get; set; }

        /// <summary>
        /// get/set - The foreign key to the building occupant type.
        /// </summary>
        public int BuildingOccupantTypeId { get; set; }

        /// <summary>
        /// get/set - The type of occupant for this building.
        /// </summary>
        public string BuildingOccupantType { get; set; }

        /// <summary>
        /// get/set - The expiry date of the currently active lease
        /// </summary>
        public DateTime? LeaseExpiry { get; set; }

        /// <summary>
        /// get/set - The name of the occupant/organization
        /// </summary>
        public string OccupantName { get; set; }

        /// <summary>
        /// get/set - Whether the lease on this building would be transferred if the building is sold.
        /// </summary>
        public bool TransferLeaseOnSale { get; set; } = false;
        #endregion
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new instance of a Property object.
        /// </summary>
        public Property()
        {

        }

        /// <summary>
        /// Creates a new instance of a Property object, initializes it with the specified arguments.
        /// </summary>
        /// <param name="property"></param>
        public Property(Entities.Property property)
        {
            this.Id = property.Id;
            this.ProjectNumber = property.ProjectNumber;
            this.StatusId = property.StatusId;
            this.Status = property.Status?.Name;
            this.ClassificationId = property.ClassificationId;
            this.Classification = property.Classification?.Name;
            this.AgencyId = property.AgencyId;
            this.Agency = property.Agency?.Name;
            this.Description = property.Description;
            this.AddressId = property.AddressId;
            this.Address = $"{property.Address?.Address1} {property.Address?.Address2}";
            this.City = property.Address?.City?.Name;
            this.Province = property.Address?.Province?.Name;
            this.Postal = property.Address?.Postal;
            this.Latitude = property.Latitude;
            this.Longitude = property.Longitude;
            this.IsSensitive = property.IsSensitive;
        }

        /// <summary>
        /// Creates a new instance of a Property object, initializes it with the specified arguments.
        /// </summary>
        /// <param name="parcel"></param>
        public Property(Parcel parcel) : this((Entities.Property)parcel)
        {
            this.PropertyTypeId = PropertyTypes.Land;
            this.PID = parcel.PID;
            this.PIN = parcel.PIN;
            this.LandArea = parcel.LandArea;
            this.LandLegalDescription = parcel.LandLegalDescription;
            this.Municipality = parcel.Municipality;
            this.Zoning = parcel.Zoning;
            this.ZoningPotential = parcel.ZoningPotential;
        }

        /// <summary>
        /// Creates a new instance of a Property object, initializes it with the specified arguments.
        /// </summary>
        /// <param name="building"></param>
        public Property(Building building) : this((Entities.Property)building)
        {
            this.PropertyTypeId = PropertyTypes.Building;
            this.PID = building.Parcel?.PID ?? 0;
            this.PIN = building.Parcel?.PIN;
            this.LocalId = building.LocalId;
            this.BuildingConstructionTypeId = building.BuildingConstructionTypeId;
            this.BuildingConstructionType = building.BuildingConstructionType?.Name;
            this.BuildingFloorCount = building.BuildingFloorCount;
            this.BuildingPredominateUseId = building.BuildingPredominateUseId;
            this.BuildingPredominateUse = building.BuildingPredominateUse?.Name;
            this.BuildingTenancy = building.BuildingTenancy;
            this.RentableArea = building.RentableArea;
            this.BuildingOccupantTypeId = building.BuildingOccupantTypeId;
            this.BuildingOccupantType = building.BuildingOccupantType?.Name;
            this.LeaseExpiry = building.LeaseExpiry;
            this.OccupantName = building.OccupantName;
            this.TransferLeaseOnSale = building.TransferLeaseOnSale;
        }
        #endregion
    }
}