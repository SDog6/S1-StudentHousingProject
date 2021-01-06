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
