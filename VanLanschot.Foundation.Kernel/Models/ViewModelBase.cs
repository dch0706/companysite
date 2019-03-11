using Glass.Mapper.Sc;
using Sitecore;
using Sitecore.Mvc.Presentation;

namespace VanLanschot.Foundation.Kernel.Models
{
    public abstract class ViewModelBase<TValue> : RenderingModel where TValue : class
    {
        public virtual TValue GlassItem { get; set; }

        public bool IsExperienceEditor => Context.PageMode.IsExperienceEditor;

        public bool IsPreview => Context.PageMode.IsPreview;

        public override void Initialize(Rendering rendering)
        {
            base.Initialize(rendering);
            var sitecoreContext = new SitecoreContext();
            GlassItem = sitecoreContext.CreateType<TValue>(RenderingContext.Current.Rendering.Item);
        }
    }
}