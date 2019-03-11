using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using VanLanschot.Feature.VolleyGroup.Repositories;

namespace VanLanschot.Feature.VolleyGroup.Rules.Conditions
{
    public class HasVolleyGroupIdentifierCondition<T> :WhenCondition<T> where T: RuleContext
    {
        protected override bool Execute(T ruleContext)
        {
            var volleyGroupFacet = new XdbRepository().GetVolleyGroupFacetFromCurrentContact();

            return volleyGroupFacet != null && !string.IsNullOrEmpty(volleyGroupFacet.ExternalId);
        }
    }
}