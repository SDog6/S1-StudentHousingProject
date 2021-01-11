using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    public class Rules
    {
        private static List<Rule> NewRuleList;

        public Rules()
        {
            NewRuleList = new List<Rule>();
            NewRuleList.Add(new Rule("No pets allowed inside the building"));
            NewRuleList.Add(new Rule("You cannot invite somebody else to live with you in your room"));
            NewRuleList.Add(new Rule("Parties are only allowed if discussed with with other tenants"));
        }

        public void AddRule(string newrule)
        {
            NewRuleList.Add(new Rule(newrule));
        }

        public List<Rule> GetAllRule()
        {
            return NewRuleList.ToList();
        }

        public void RemoveRule(int index)
        {
            NewRuleList.RemoveAt(index);
        }
    }
}
