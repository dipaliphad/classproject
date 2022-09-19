using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classproject
{
    //public class Emp
    //{
    //    protected int id;
    //    private static int count=0;
    //    protected double basicsalary, hra, da, pt, pf, total, netpaid;
    //    protected string name;
       
    //    public Emp(double basicsalary, double pt, string name)
    //    {
    //        count++;
    //        id = count;
    //        this.basicsalary = basicsalary;
    //        this.pt= pt;      
    //        this.name = name;
    //    }
    //    public static int DisplayCount()
    //    {
    //        return count;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Emp Id={id}\n emp name={name}\n total salary={total}\n Net paid={netpaid}"; 
    //    }
    //    public class Manager:Emp
    //    {
    //        private double ta;
    //    public Manager():base()
    //        {
    //            ta = 0.0;
    //        }
    //        public Manager(double basicsalary, double pt, int id, string name, double ta):base(basicsalary,pt, id, name)
    //        {
    //            this.ta = ta;
    //        }
    //        public virtual void CalculateSalary()
    //        {
    //            hra = basicsalary * 0.40;
    //            da = basicsalary * 0.20;
    //            pf = basicsalary * 0.12;
    //            total = basicsalary + hra + da + ta;
    //            netpaid = total - (pf - pt);
    //        }
    //        public override string ToString()
    //        {
    //            return $"Manager details:\n id={id}\n Manager name={name}\n total salary={total}\n Net paid={netpaid}";
    //        }
          
    //    //public double GetHRA()
    //    //{
    //    //    double hra = basicsalary / 100 * 40;
    //    //    return hra;
    //   // }
    //    //public double CalculateDA()
    //    //{
    //    //    da = basicsalary / 100 * 20;
    //    //    return da;
    //    //}
      
    //    //public double CalculatePF()
    //    //{
    //    //    pf = basicsalary / 100 * 12;
    //    //    return pf;
    //    //}
    //    //public double CalculateNetpaid()
    //    //{
    //    //    netpaid = total - pf - pt;
    //    //    return netpaid;
    //    //}

      
    //}
       
    //    }

}
