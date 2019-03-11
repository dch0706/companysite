





#pragma warning disable CS1591
#pragma warning disable CS0108
//-----------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Team Development for Sitecore.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------

// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// Justification: This is generated code.

using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using JetBrains.Annotations;
using Sitecore.Globalization;
using Sitecore.Data;
using Sitecore.Data.Items;
using VanLanschot.Foundation.Kernel.Models;


// ReSharper disable UnusedMember.Global
// Justification: These generated models map to Sitecore fields.

// ReSharper disable UnusedAutoPropertyAccessor.Local
// Justification: Property is used by Glass / Castle.Core.

// ReSharper disable PartialTypeWithSinglePart
// Justification: Generated code needs to leave extension points.

namespace VanLanschot.Feature.Navigation
{
	/// <summary>
	/// <para>I_MenuItemGroup Interface</para>
	/// <para></para>
	/// <para>Path: /sitecore/templates/Feature/Navigation/_MenuItemGroup</para>
	/// <para>ID: 0fda0572-c655-4337-b60f-3ba934837eec</para>
	/// </summary>
	[SitecoreType(TemplateId=I_MenuItemGroupConstants.TemplateIdString)]
	[System.CodeDom.Compiler.GeneratedCode("Team Development for Sitecore - GlassV3Item.tt", "5.6")]
	public partial interface I_MenuItemGroup
		: IGlassBase
	{
	}

	[System.CodeDom.Compiler.GeneratedCode("Team Development for Sitecore - GlassV3Item.tt", "5.6")]
	public static partial class I_MenuItemGroupConstants
	{
		/// <summary>The template td raw value.</summary>
		public const string TemplateIdString =
			"0fda0572-c655-4337-b60f-3ba934837eec";

		/// <summary>The template id.</summary>
		public static readonly TemplateID TemplateId =
			new TemplateID(new ID(TemplateIdString));

		/// <summary>The template name.</summary>
		public const string TemplateName = "_MenuItemGroup";

	}

	/// <summary>
	/// <para>_MenuItemGroup</para>
	/// <para></para>
	/// <para>Path: /sitecore/templates/Feature/Navigation/_MenuItemGroup</para>
	/// <para>ID: 0fda0572-c655-4337-b60f-3ba934837eec</para>
	/// </summary>
	[SitecoreType(TemplateId=I_MenuItemGroupConstants.TemplateIdString)]
	[System.CodeDom.Compiler.GeneratedCode("Team Development for Sitecore - GlassV3Item.tt", "5.6")]
	public partial class _MenuItemGroup
		: GlassBase, I_MenuItemGroup
	{
	}
}
namespace VanLanschot.Feature.Navigation
{
	/// <summary>
	/// <para>I_LinkMenuItem Interface</para>
	/// <para></para>
	/// <para>Path: /sitecore/templates/Feature/Navigation/_LinkMenuItem</para>
	/// <para>ID: 8e94a7b3-c680-4a16-a929-7d20da9746e4</para>
	/// </summary>
	[SitecoreType(TemplateId=I_LinkMenuItemConstants.TemplateIdString)]
	[System.CodeDom.Compiler.GeneratedCode("Team Development for Sitecore - GlassV3Item.tt", "5.6")]
	public partial interface I_LinkMenuItem
		: IGlassBase
	{
		/// <summary>
		/// <para>The Menu Link field.</para>
		/// <para></para>
		/// <para>Field Type: General Link</para>
		/// <para>Field ID: 0f19a608-06fe-4713-9382-c2aa7f3ac38d</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[SitecoreField(I_LinkMenuItemConstants.Menu_LinkFieldName)]
		Link Menu_Link { get; set; }

	}

	[System.CodeDom.Compiler.GeneratedCode("Team Development for Sitecore - GlassV3Item.tt", "5.6")]
	public static partial class I_LinkMenuItemConstants
	{
		/// <summary>The template td raw value.</summary>
		public const string TemplateIdString =
			"8e94a7b3-c680-4a16-a929-7d20da9746e4";

		/// <summary>The template id.</summary>
		public static readonly TemplateID TemplateId =
			new TemplateID(new ID(TemplateIdString));

		/// <summary>The template name.</summary>
		public const string TemplateName = "_LinkMenuItem";

		public const string Menu_LinkFieldName = "Menu Link";

		public static readonly ID Menu_LinkFieldId =
			new ID("0f19a608-06fe-4713-9382-c2aa7f3ac38d");

	}

	/// <summary>
	/// <para>_LinkMenuItem</para>
	/// <para></para>
	/// <para>Path: /sitecore/templates/Feature/Navigation/_LinkMenuItem</para>
	/// <para>ID: 8e94a7b3-c680-4a16-a929-7d20da9746e4</para>
	/// </summary>
	[SitecoreType(TemplateId=I_LinkMenuItemConstants.TemplateIdString)]
	[System.CodeDom.Compiler.GeneratedCode("Team Development for Sitecore - GlassV3Item.tt", "5.6")]
	public partial class _LinkMenuItem
		: GlassBase, I_LinkMenuItem
	{
		/// <summary>
		/// <para>The Menu Link field.</para>
		/// <para></para>
		/// <para>Field Type: General Link</para>
		/// <para>Field ID: 0f19a608-06fe-4713-9382-c2aa7f3ac38d</para>
		/// <para>Custom Data: </para>
		/// </summary>
		[SitecoreField(I_LinkMenuItemConstants.Menu_LinkFieldName)]
		public virtual Link Menu_Link { get; set; }

	}
}