using System.Security.Claims;
using Pims.Dal.Services;

namespace Pims.Dal.Services.Admin
{
    /// <summary>
    /// IPimsAdminService interface, provides a way to interface with the backend datasource.
    /// </summary>
    public interface IPimsAdminService
    {
        #region Properties
        ClaimsPrincipal Principal { get; }
        IUserService User { get; }
        IRoleService Role { get; }
        IAgencyService Agency { get; }
        IParcelService Parcel { get; }
        IBuildingService Building { get; }
        IAddressService Address { get; }
        IProvinceService Province { get; }
        ICityService City { get; }
        IBuildingConstructionTypeService BuildingConstructionType { get; }
        IBuildingPredominateUseService BuildingPredominateUse { get; }
        IPropertyClassificationService PropertyClassification { get; }
        IPropertyStatusService PropertyStatus { get; }
        IPropertyTypeService PropertyType { get; }
        #endregion

        #region Methods
        int CommitTransaction();
        #endregion
    }
}