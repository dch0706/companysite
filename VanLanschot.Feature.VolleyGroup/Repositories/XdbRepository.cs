using System;
using System.Linq;
using Sitecore.Analytics;
using Sitecore.Diagnostics;
using Sitecore.XConnect;
using Sitecore.XConnect.Client;
using Sitecore.XConnect.Client.Configuration;
using VanLanschot.Feature.VolleyGroup.XConnect.Extensions;
using VanLanschot.Feature.VolleyGroup.XConnect.Facets;

namespace VanLanschot.Feature.VolleyGroup.Repositories
{
    public class XdbRepository : IXdbRepository
    {
        public const string WebsiteSourceIdentifier = "website";

        public void SetVolleyGroupExternalId(string externalId)
        {
            using (var client = SitecoreXConnectClientConfiguration.GetClient())
            {
                try
                {
                    var source = WebsiteSourceIdentifier;

                    var reference = new IdentifiedContactReference(source, externalId);

                    var existingContact = client.Get(reference,
                        new ContactExpandOptions(VolleyGroupFacet.DefaultFacetKey));

                    if (existingContact == null)
                    {
                        var contact = new Contact(
                            new ContactIdentifier(source, externalId,
                                ContactIdentifierType.Known));

                        var customFacet = contact.GetVolleyGroupFacet() ?? new VolleyGroupFacet();

                        customFacet.ExternalId = externalId;

                        client.SetFacet(contact, customFacet);


                        client.AddContact(contact);
                        client.Submit();
                    }

                    Tracker.Current.Session.IdentifyAs(source, externalId);
                }
                catch (Exception ex)
                {
                    Log.Error(ex.Message, this);
                }
            }

        }

        public VolleyGroupFacet GetVolleyGroupFacetFromCurrentContact()
        {
            var anyIdentifier = Tracker.Current.Contact.Identifiers.FirstOrDefault();
            using (var client = SitecoreXConnectClientConfiguration.GetClient())
            {
                try
                {
                    if (anyIdentifier != null)
                    {
                        var contact = client.Get(new IdentifiedContactReference(anyIdentifier.Source, anyIdentifier.Identifier), new ContactExpandOptions(VolleyGroupFacet.DefaultFacetKey));
                        return contact.GetVolleyGroupFacet();
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(ex.Message, this);
                }

                return null;
            }
        }
    }
}