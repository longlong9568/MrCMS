using System.Collections.Generic;
using MrCMS.Entities.Documents.Web;
using MrCMS.Models;
using MrCMS.Web.Apps.Admin.Models;

namespace MrCMS.Web.Apps.Admin.Services
{
    public interface IWebpageAdminService
    {
        Webpage GetWebpage(int? id);
        AddWebpageModel GetAddModel(int? id);
        object GetAdditionalPropertyModel(string type);
        Webpage Add(AddWebpageModel model, object additionalPropertyModel = null);
        Webpage Update(UpdateWebpageViewModel viewModel);
        void Delete(Webpage webpage);
        List<SortItem> GetSortItems(Webpage parent);
        void SetOrders(List<SortItem> items);
        void PublishNow(int id);
        void Unpublish(int id);
    }
}