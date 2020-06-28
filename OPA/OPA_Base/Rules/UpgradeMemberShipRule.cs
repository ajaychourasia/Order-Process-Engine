using OPA.OPA_Base.Entities;
using OPA.OPA_Base.Interface;
using OPA.OPA_Base.RuleExtension;

namespace OPA.OPA_Base.Rules
{
   public class UpgradeMemberShipRule :IRule
    {
        public string ExecuteRule(Order orderType)
        {
            return orderType.IsMemberUpgraded() ? UpgradeMemberhip() : "Upgrade not Aplicable";
        }

        private string UpgradeMemberhip()
        {
            //logic comes here
            return "Member Upgraded Successfully";
        }
    }
}
