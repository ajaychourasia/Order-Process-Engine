using OPA.OPA_Base.Entities;
using OPA.OPA_Base.Interface;
using OPA.OPA_Base.RuleExtension;

namespace OPA.OPA_Base.Rules
{
   public class NewMembershipRule :IRule
    {
        public string ExecuteRule(Order orderType)
        {
            return orderType.IsNewMember() ? ActivateMemberhip() : "Member Already Exsist";
        }

        private string ActivateMemberhip()
        {
            //logic comes here
            return "Member Activated Successfully";
        }
    }
}
