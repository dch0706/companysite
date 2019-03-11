using Sitecore.XConnect;
using Sitecore.XConnect.Collection.Model;
using Sitecore.XConnect.Schema;
using VanLanschot.Feature.VolleyGroup.XConnect.Facets;

namespace VanLanschot.Feature.VolleyGroup.XConnect
{
    public class ContactCustomModel
    {
        public static XdbModel Model { get; } = BuildModel();

        private static XdbModel BuildModel()
        {
            var xdbModelBuilder = new XdbModelBuilder("VanLanschot.Feature.VolleyGroup.XConnect.ContactCustomModel", new XdbModelVersion(1, 0));

            xdbModelBuilder.ReferenceModel(CollectionModel.Model);
            xdbModelBuilder.DefineFacet<Contact, VolleyGroupFacet>(VolleyGroupFacet.DefaultFacetKey);
            return xdbModelBuilder.BuildModel();
        }
    }
}