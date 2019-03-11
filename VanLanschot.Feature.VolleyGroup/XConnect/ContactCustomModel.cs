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
            var xdbModelBuilder = new XdbModelBuilder("ContactCustomModel", new XdbModelVersion(1, 0));

            xdbModelBuilder.DefineFacet<Contact, VolleyGroupFacet>(VolleyGroupFacet.DefaultFacetKey);

            xdbModelBuilder.ReferenceModel(CollectionModel.Model);

            return xdbModelBuilder.BuildModel();
        }
    }
}