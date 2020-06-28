using OPA.OPA_Base.Entities;
using OPA.OPA_Base.Interface;
using OPA.OPA_Base.RuleExtension;


namespace OPA.OPA_Base.Rules
{
    public class PhysicalProductORBookRule : IRule
    {
        public string ExecuteRule(Order orderType)
        {
            return orderType.IsPhysicalProductORBook() ? GenerateCommissionToAgent() : "Not Applicable to Generate Commission";
        }

        private string GenerateCommissionToAgent()
        {
            //logic comes here
            return "First Aid Vedio Added Successfully";
        }
    }
}
