using System.Linq;
using Sitecore.Analytics;
using Sitecore.Rules;
using Sitecore.Rules.Conditions;
using VanLanschot.Feature.VolleyGroup.Repositories;
using VanLanschot.Feature.VolleyGroup.XConnect.Extensions;

namespace VanLanschot.Feature.VolleyGroup.Rules.Conditions
{
    public class HasVolleyGroupIdentifierCondition<T> :WhenCondition<T> where T: RuleContext
    {
        private readonly IXdbRepository _xdbRepository;

        //public HasVolleyGroupIdentifierCondition(IXdbRepository xdbRepository)
        //{
        //    _xdbRepository = xdbRepository;
        //}
        protected override bool Execute(T ruleContext)
        {
            var volleyGroupFacet = new XdbRepository().GetVolleyGroupFacetFromCurrentContact();

            return volleyGroupFacet != null && !string.IsNullOrEmpty(volleyGroupFacet.ExternalId);
        }
    }
}