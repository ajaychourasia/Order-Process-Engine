using OPA.OPA_Base.Entities;

namespace OPA.OPA_Base.Interface
{
    /// <summary>
    /// Base Interface for Rule Engine
    /// </summary>
    public interface IRule
    {
       string ExecuteRule(Order orderType);
    }
}
