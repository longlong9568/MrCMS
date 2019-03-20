using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MrCMS.Entities.Documents.Web;
using MrCMS.Web.Apps.Admin.Models;

namespace MrCMS.Web.Apps.Admin.Services
{
    public interface IMergeWebpageAdminService
    {
        IEnumerable<SelectListItem> GetValidParents(Webpage webpage);
        MergeWebpageResult Validate(MergeWebpageModel moveWebpageModel);
        MergeWebpageConfirmationModel GetConfirmationModel(MergeWebpageModel model);
        MergeWebpageResult Confirm(MergeWebpageModel model);
        MergeWebpageModel GetModel(Webpage webpage);
    }
}