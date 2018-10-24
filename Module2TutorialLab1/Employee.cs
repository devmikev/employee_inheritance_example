using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2TutorialLab1
{
    class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }


        public Employee(string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        public string getName()
        {
            return this.Name;
        }

        private static int employeeCount = 1;

        public int getEmployeeID()
        {
            return this.ID;
        }

        public string toString()
        {
            return this.ID + " " + this.Name;
        }

        public virtual string employeeStatus()
        {
            return toString() + " is in the company's system";
        }


    }
}
