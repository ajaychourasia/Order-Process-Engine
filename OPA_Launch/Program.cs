using System;
using OPA;
using OPA.OPA_Base.Entities;
using OPA.OPA_Base.Rules;

namespace OPA_Launch
{
   public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            string returnMessage = string.Empty;
            Console.WriteLine("Enter Order Type");
            int orderVal = int.Parse(Console.ReadLine());
            order.OrderType = orderVal;
            switch (orderVal)
            {
                case 1:
                    PhysicalProductRule phyProdRule = new PhysicalProductRule();
                    returnMessage = phyProdRule.ExecuteRule(order);
                    break;
                case 2:
                    BookRule bookRule = new BookRule();
                    returnMessage = bookRule.ExecuteRule(order);
                    break;
                case 3:
                    NewMembershipRule newMembership = new NewMembershipRule();
                    returnMessage = newMembership.ExecuteRule(order);
                    break;
                case 4:
                    UpgradeMemberShipRule upgradeMember = new UpgradeMemberShipRule();
                    returnMessage = upgradeMember.ExecuteRule(order);
                    break;
                case 5:
                    MembershipORUpgradeRule membershipORUpgrade = new MembershipORUpgradeRule();
                    returnMessage = membershipORUpgrade.ExecuteRule(order);
                    break;
                case 6:
                    VideoLearningRule videoLearning = new VideoLearningRule();
                    returnMessage = videoLearning.ExecuteRule(order);
                    break;
                case 7:
                    PhysicalProductORBookRule physicalProductORBookRule = new PhysicalProductORBookRule();
                    returnMessage = physicalProductORBookRule.ExecuteRule(order);
                    break;

            }
            Console.WriteLine("{0}", returnMessage);
            Console.Read();
        }
    }
}
