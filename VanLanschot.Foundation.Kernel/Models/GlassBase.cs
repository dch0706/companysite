using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;
using Sitecore.Globalization;

namespace VanLanschot.Foundation.Kernel.Models
{
    /// <summary>An entity mapped by Glass</summary>
    [GeneratedCode("Team Development for Sitecore - GlassV3Header.tt", "5.6")]
    public abstract class GlassBase : IGlassBase
    {
        /// <summary>Gets or sets the Sitecore display name.</summary>
        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        public virtual string DisplayName { get; set; }

        /// <summary>Gets the Sitecore Id.</summary>
        [SitecoreId]
        public virtual Guid Id { get; private set; }

        /// <summary>Gets the Sitecore item.</summary>
        [SitecoreItem]
        public virtual Item InnerItem { get; private set; }

        /// <summary>Gets the Sitecore Language.</summary>
        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get; set; }

        /// <summary>Gets the Sitecore name.</summary>
        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string ItemName { get; set; }

        /// <summary>Gets the Url to this item.</summary>
        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }

        /// <summary>Gets the item version.</summary>
        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }
        [SitecoreChildren(InferType = true, IsLazy = true)]
        public virtual IEnumerable<IGlassBase> Children { get; set; }

        [SitecoreParent(IsLazy = true)]
        public virtual IGlassBase Parent { get; set; }
    }
}