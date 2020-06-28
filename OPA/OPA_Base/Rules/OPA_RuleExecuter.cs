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
    ///  Applied SOLID principal
    /// </summary>
   public class OPA_RuleExecuter : IOPA_RuleExecuter
    {
        // Get List of rule
        List<IRule> _rules = new List<IRule>();
        public OPA_RuleExecuter(List<IRule> _rules)
        {
            foreach (var rule in _rules)
            {
                _rules.Add(rule);
               
            }
 
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
