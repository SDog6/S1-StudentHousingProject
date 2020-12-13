﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    class Tenant
    {
        private string name;
        private TenantSex sex;
        private int age;
        private int Rent = 0;

     
        public Tenant()
        {

        }
        
        public Tenant(string name, TenantSex sex, int age, int Rent)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.Rent = 0;
            this.Rent = Rent;
        }

        public int GetMoney()
        {
            return Rent;

        }
            public void RemoveTenant()
        {
            Rent = 0;

        }
        public string GetInfo()
        {
            return $"Tenant: {name}({sex}) is {age} years old \n and pays {Rent}$ rent a month ";
        }

    }
}