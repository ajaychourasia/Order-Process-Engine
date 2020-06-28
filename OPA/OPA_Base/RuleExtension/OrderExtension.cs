using OPA.OPA_Base.Entities;

namespace OPA.OPA_Base.RuleExtension
{

    /// <summary>
    /// Extention method can be added as as require with exsisitng or new upcoming rules 
    /// </summary>
   public static class OrderExtension
    {
        public static bool IsPhysicalProduct(this Order order)
        {
           // return on logic base , default TRUE
            return true;
        }

        public static bool IsBookOrder(this Order order)
        {
            return true;
        }

        public static bool IsNewMemberORUpgrade(this Order order)
        {
            return true;
        }
        public static bool IsNewMember(this Order order)
        {
            return true;
        }
        public static bool IsPhysicalProductORBook(this Order order)
        {
            return true;
        }

        public static bool IsVideoLearning(this Order order)
        {
            return true;
        }
        public static bool IsMemberUpgraded(this Order order)
        {
            return true;
        }
    }
    
}
