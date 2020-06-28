using OPA.OPA_Base.Entities;
using OPA.OPA_Base.Interface;
using OPA.OPA_Base.RuleExtension;
using System.Net.Mail;

namespace OPA.OPA_Base.Rules
{
   public class MembershipORUpgradeRule : IRule
    {
        public string ExecuteRule(Order orderType)
        {
            return orderType.IsNewMemberORUpgrade() ? EmailActivation() : "Upgrade not Aplicable";
        }

        private string EmailActivation()
        {
            try
            {
                //logic comes here
                MailMessage mail = new MailMessage();
                mail.Subject = "Membership Activation/Upgrade";
                mail.Body = "Your Membership Upgraded";
                mail.To.Add("xyx@gmail.com");
                //SmtpClient smpt = new SmtpClient();
                //smpt.Send(mail);
                return "Email sent successfully for Activation/Upgrade";
            }
            catch (System.Exception)
            {
                //Log exception here
                throw;
            }
           
        }
    }
}
