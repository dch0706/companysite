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
    public partial interface IGlassBase
    {
        /// <summary>Gets or sets the Sitecore display name.</summary>
        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        string DisplayName { get; set; }

        /// <summary>Gets the Sitecore Id.</summary>
        [SitecoreId]
        Guid Id { get; }

        /// <summary>Gets the Sitecore item.</summary>
        [SitecoreItem]
        Item InnerItem { get; }

        /// <summary>Gets the Sitecore Language.</summary>
        [SitecoreInfo(SitecoreInfoType.Language)]
        Language Language { get; set; }

        /// <summary>Gets the Sitecore name.</summary>
        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }

        /// <summary>Gets the Url to this item.</summary>
        [SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get; }

        /// <summary>Gets the item version.</summary>
        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

        [SitecoreChildren(InferType = true, IsLazy = true)]
        IEnumerable<IGlassBase> Children { get; set; }

        [SitecoreParent(InferType = true, IsLazy = true)]
        IGlassBase Parent { get; set; }
    }
}