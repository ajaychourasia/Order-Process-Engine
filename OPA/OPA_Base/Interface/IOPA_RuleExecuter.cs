using OPA.OPA_Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPA.OPA_Base.Interface
{
    interface IOPA_RuleExecuter
    {
        string ExecuteRuleByOrder(Order order);
    }
}
