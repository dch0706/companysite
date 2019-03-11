using Sitecore.XConnect;

namespace VanLanschot.Feature.VolleyGroup.XConnect.Facets
{
    [FacetKey(DefaultFacetKey)]
    public class VolleyGroupFacet : Facet
    {
        public const string DefaultFacetKey = "VolleyGroupFacet";

        public string ExternalId { get; set; }

    }
}