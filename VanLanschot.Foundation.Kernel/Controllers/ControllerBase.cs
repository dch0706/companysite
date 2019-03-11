using System.Text;
using System.Web.Mvc;
using Sitecore;
using Sitecore.Mvc.Presentation;
using Glass.Mapper.Sc.Web.Mvc;


namespace VanLanschot.Foundation.Kernel.Controllers
{
    public class ControllerBase : GlassController
    {
        protected virtual ContentResult DataSourceNotConfiguredResult
        {
            get
            {
                if (Context.PageMode.IsExperienceEditor)
                {
                    var msg = new StringBuilder();
                    msg.AppendFormat("<div class=\"experience-editor-no-datasource-warning\">");
                    msg.AppendFormat("<strong>{0}</strong> - {1}", RenderingContext.Current.Rendering.RenderingItem.DisplayName, "Rendering datasource is not configured");
                    msg.AppendFormat("</div>");
                    return Content(msg.ToString());
                }

                return new ContentResult();
            }
        }
    }
}