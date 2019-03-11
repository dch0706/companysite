using System;
using Sitecore.XConnect;
using VanLanschot.Feature.VolleyGroup.XConnect.Facets;

namespace VanLanschot.Feature.VolleyGroup.Repositories
{
    public interface IXdbRepository
    {
        void SetVolleyGroupExternalId(string externalId);
        VolleyGroupFacet GetVolleyGroupFacetFromCurrentContact();
        Contact GetXConnectContactbyId(ContactIdentifier identifier);
    }
}