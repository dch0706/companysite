using Sitecore.XConnect;
using VanLanschot.Feature.VolleyGroup.XConnect.Facets;

namespace VanLanschot.Feature.VolleyGroup.XConnect.Extensions
{
    public static class FacetExtensions
    {
        public static VolleyGroupFacet GetVolleyGroupFacet(this Contact c)
        {
            var facet = c.GetFacet<VolleyGroupFacet>(VolleyGroupFacet.DefaultFacetKey);
            return facet;
        }

    }
}