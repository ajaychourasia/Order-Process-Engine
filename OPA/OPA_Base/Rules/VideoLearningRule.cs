using OPA.OPA_Base.Entities;
using OPA.OPA_Base.Interface;
using OPA.OPA_Base.RuleExtension;


namespace OPA.OPA_Base.Rules
{
   public class VideoLearningRule : IRule
    {
        public string ExecuteRule(Order orderType)
        {
            return orderType.IsVideoLearning() ? AddFreeVideo() : "Not Applicable for free Add";
        }

        private string AddFreeVideo()
        {
            try
            {
                //logic comes here
                return "First Aid Vedio Added Successfully";
            }
            catch (System.Exception)
            {
                //Log Exception here
                throw;
            }
           
        }
    }
}
