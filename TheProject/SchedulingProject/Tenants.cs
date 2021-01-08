using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    class Tenants
    {
        private static Tenant[] newTenantArray;

        public Tenants()
        {
            newTenantArray = new Tenant[4];
            newTenantArray[0] = new Tenant("Leo", (TenantSex)0, 20, 550);
            newTenantArray[1] = new Tenant("unoccupied", (TenantSex)0, 0, 0);
            newTenantArray[2] = new Tenant("unoccupied", (TenantSex)0, 0, 0);
            newTenantArray[3] = new Tenant("unoccupied", (TenantSex)0, 0, 0);
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
