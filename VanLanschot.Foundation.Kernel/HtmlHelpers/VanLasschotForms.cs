using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace VanLanschot.Foundation.Kernel.HtmlHelpers
{
    public static class VanLasschotForms
    {
        public static MvcForm BeginanLasschotForm(this HtmlHelper htmlHelper, string formId)
        {
            var rawUrl = htmlHelper.ViewContext.HttpContext.Request.RawUrl;
            var tagBuilder = new TagBuilder("form");
            tagBuilder.MergeAttribute("id", formId);
            tagBuilder.MergeAttribute("action", rawUrl);
            tagBuilder.MergeAttribute("method", HtmlHelper.GetFormMethodString(FormMethod.Post), true);
            htmlHelper.ViewContext.Writer.Write(tagBuilder.ToString(TagRenderMode.StartTag));
            var mvcForm = new MvcForm(htmlHelper.ViewContext);
            htmlHelper.ViewContext.FormContext.FormId = tagBuilder.Attributes["id"];
            return mvcForm;
        }
    }
}