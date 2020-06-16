using System.Collections.Generic;
using Pims.Api.Models.Parcel;

namespace Pims.Api.Areas.Project.Models.Dispose
{
    public class ParcelModel : PropertyModel
    {
        #region Properties
        public string PID { get; set; }

        public int? PIN { get; set; }

        public float LandArea { get; set; }

        public string LandLegalDescription { get; set; }

        public string Municipality { get; set; }

        public string Zoning { get; set; }

        public string ZoningPotential { get; set; }

        public override string SubAgency { get; set; }

        public IEnumerable<ParcelEvaluationModel> Evaluations { get; set; } = new List<ParcelEvaluationModel>();

        public IEnumerable<ParcelFiscalModel> Fiscals { get; set; } = new List<ParcelFiscalModel>();

        public IEnumerable<ParcelBuildingModel> Buildings { get; set; } = new List<ParcelBuildingModel>();
        #endregion
    }
}