using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classproject
{
    internal class Emp
    {
        private int id;
        private static int count=0;
        public int empid;
        private double basicsalary;
        private double da;
        private double total;
        private int pt = 200;
        private double pf;
        private double netpaid;
        public string empname;

        public Emp(double basicsalary ,int empid, string empname)
        {
            count++;
            id = count;
            this.basicsalary = basicsalary;
            this.empid = empid;
            this.empname = empname;
        }
        public static int DisplayCount()
        {
            return count;
        }
        public double GetHRA()
        {
            double hra = basicsalary / 100 * 40;
            return hra;
        }
        public double CalculateDA()
        {
            da = basicsalary / 100 * 20;
            return da;
        }
        public double CalculateTotalSalary()
        {
            total = basicsalary + da;
            return total;
        }
        public double CalculatePF()
        {
            pf = basicsalary / 100 * 12;
            return pf;
        }
        public double CalculateNetpaid()
        {
            netpaid = total - pf - pt;
            return netpaid;
        }

        public string Print()
        {
            return $" emp details:\n Id={id}\n empid={empid}\n empname={empname}\n basicsalary={basicsalary}";
        }
    }

}
