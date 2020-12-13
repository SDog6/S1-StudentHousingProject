using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    class Tenants
    {
        private Tenant[] newTenantArray;

        public Tenants()
        {
            newTenantArray = new Tenant[4];
        }
        public Tenant[] ReturnTenantArray()
        {
            return newTenantArray;
        }

        public int GetRevenue()
        {
            int amount;
            amount = newTenantArray[0].GetMoney() + newTenantArray[1].GetMoney() + newTenantArray[2].GetMoney() + newTenantArray[3].GetMoney();
            return amount;
        }
    }
}
