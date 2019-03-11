using System;
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

                    var existingContact = client.Get<Contact>(reference, new ContactExpandOptions() { });

                    if (existingContact == null)
                    {
                        var contact = new Sitecore.XConnect.Contact(
                            new ContactIdentifier(source, externalId,
                                ContactIdentifierType.Known));

                        var customFacet = contact.GetVolleyGroupFacet() ?? new VolleyGroupFacet();

                        customFacet.ExternalId = externalId;

                        client.SetFacet(contact, customFacet);


                        client.AddContact(contact);
                        client.Submit();
                    }
                    else
                    {
                        var volleyGroupFacet = existingContact.GetVolleyGroupFacet();
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(ex.Message, this);
                }
            }

        }
    }
}