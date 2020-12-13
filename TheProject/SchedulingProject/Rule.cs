using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    public class Rule
    {
        private string rule;

        public Rule(string rule)
        {
            this.rule = rule;
        }

        public string GetInfo()
        {
            return $"- {rule}"; 
        }

        public static implicit operator Rule(Rules v)
        {
            throw new NotImplementedException();
        }
    }
}
