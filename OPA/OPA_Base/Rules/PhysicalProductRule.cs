using OPA.OPA_Base.Entities;
using OPA.OPA_Base.Interface;
using OPA.OPA_Base.RuleExtension;


namespace OPA.OPA_Base.Rules
{
   public class PhysicalProductRule :IRule
    {
        public string ExecuteRule(Order orderType)
        {
            return orderType.IsPhysicalProduct() ? GeneratePackagingSlip() : "Not a Physical Product";
        }

        private string GeneratePackagingSlip()
        {
            //logic comes here
            return "Generate A Packaging Slip for shipping";
        }
    }
}
