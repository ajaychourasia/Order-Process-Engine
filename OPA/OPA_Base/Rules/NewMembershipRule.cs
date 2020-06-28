using OPA.OPA_Base.Entities;
using OPA.OPA_Base.Interface;
using OPA.OPA_Base.RuleExtension;

namespace OPA.OPA_Base.Rules
{
   public class NewMembershipRule :IRule
    {
        public string ExecuteRule(Order orderType)
        {
            //check for null
            return orderType.IsNewMember() ? ActivateMemberhip() : "Member Already Exsist";
        }

        private string ActivateMemberhip()
        {
            try
            {

                //TODO : Similar to REST API we can return Response code. 
                //logic comes here
                return "Member Activated Successfully";
            }
            catch (System.Exception)
            {
                //Log this Error
                throw;
            }
           
        }
    }
}
