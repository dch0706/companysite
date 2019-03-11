using System.Linq;
using System.Web.Mvc;
using Glass.Mapper;
using Glass.Mapper.Sc;
using Sitecore.Mvc.Presentation;
using Sitecore.XConnect.Serialization;
using VanLanschot.Feature.VolleyGroup.Repositories;
using VanLanschot.Feature.VolleyGroup.ViewModels;
using VanLanschot.Feature.VolleyGroup.XConnect;
using VanLanschot.Foundation.Kernel.Forms;

namespace VanLanschot.Feature.VolleyGroup.Controllers
{
    public class VolleyGroupController : VanLanschot.Foundation.Kernel.Controllers.ControllerBase
    {
        private readonly IXdbRepository _xdbRepository;

        public VolleyGroupController(IXdbRepository xdbRepository)
        {
            _xdbRepository = xdbRepository;
        }
        [HttpGet]
        public ActionResult Join()
        {
            var model = new JoinVolleyGroupViewModel();
            model.Initialize(RenderingContext.Current.Rendering);
            if (model.GlassItem == null) return DataSourceNotConfiguredResult;
            return View("Join", model);
        }

        [HttpPost]
        [ValidateFormHandler]
        public ActionResult Join(JoinVolleyGroupViewModel model)
        {
            //var json = XdbModelWriter.Serialize(ContactCustomModel.Model);
            if (!string.IsNullOrEmpty(model.ExternalId))
            {
                _xdbRepository.SetVolleyGroupExternalId(model.ExternalId);
            }
            return View("Join", model);
        }
    }
}