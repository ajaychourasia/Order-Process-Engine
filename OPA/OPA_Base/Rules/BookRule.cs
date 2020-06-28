using OPA.OPA_Base.Entities;
using OPA.OPA_Base.Interface;
using OPA.OPA_Base.RuleExtension;

namespace OPA.OPA_Base.Rules
{
    public class BookRule :IRule
    {
        public string ExecuteRule(Order orderType)
        {
            return orderType.IsBookOrder() ? GenerateDuplicatePackagingSlip() : "Not a book Order";
        }

        private string GenerateDuplicatePackagingSlip()
        {
            try
            {
                //logic comes here
                return "A Duplicate Packaging Slip for Royality department Generated sucessfully";
            }
            catch (System.Exception)
            {
                //Log exception here
                throw;
            }
            
        }
    }
}
