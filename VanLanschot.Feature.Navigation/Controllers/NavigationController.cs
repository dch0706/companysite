using System.Linq;
using System.Web.Mvc;
using Glass.Mapper;
using Glass.Mapper.Sc;
using Sitecore.Mvc.Presentation;
using VanLanschot.Feature.Navigation.ViewModels;
using ControllerBase = VanLanschot.Foundation.Kernel.Controllers.ControllerBase;

namespace VanLanschot.Feature.Navigation.Controllers
{
    public class NavigationController : ControllerBase
    {
        private readonly ISitecoreService _sitecoreService;

        public NavigationController(ISitecoreService sitecoreService)
        {
            _sitecoreService = sitecoreService;
        }
        public ActionResult HeaderNavigation()
        {
            var model = new HeaderNavigationViewModel();
            model.Initialize(RenderingContext.Current.Rendering);
            if (model.GlassItem == null) return DataSourceNotConfiguredResult;
            model.MenuItems = model.GlassItem.Children.Select(i => _sitecoreService.Cast<I_LinkMenuItem>(i.InnerItem));
            return View("HeaderNavigation", model);
        }
    }
}