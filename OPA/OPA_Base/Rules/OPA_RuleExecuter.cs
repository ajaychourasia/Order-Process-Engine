using OPA.OPA_Base.Entities;
using OPA.OPA_Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA.OPA_Base.Rules
{
    /// <summary>
    ///  Applied SOLID proncipal
    /// </summary>
   public class OPA_RuleExecuter : IOPA_RuleExecuter
    {
        List<IRule> _rules = new List<IRule>();
        public OPA_RuleExecuter()
        {
            _rules.Add(new BookRule());
            _rules.Add(new PhysicalProductRule());
            _rules.Add(new NewMembershipRule());
            _rules.Add(new UpgradeMemberShipRule());
            _rules.Add(new MembershipORUpgradeRule());
            _rules.Add(new VideoLearningRule());
            _rules.Add(new PhysicalProductORBookRule());

        }

        public string ExecuteRuleByOrder(Order order)
        {
            foreach (var rule in _rules)
            {
                rule.ExecuteRule(order);
            }
            return "Rule validted Sucessfully";
        }
    }
}
