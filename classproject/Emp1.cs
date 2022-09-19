using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classproject
{
    public class Emp1
    {
        protected int id;
        private static int count = 0;
        protected string name;
        protected double bs, hra, da, pt,total, netpaid;
        protected double pf = 1200;
        public Emp1()
        {
            name = "";
            bs = 0.0;
            pt = 0.0;
        }
        public Emp1(string name, double bs, double pt, double pf)
        {
            count++;
            id = count;
            this.name = name;
            this.bs = bs;
            this.pt = pt;
            this.pf = pf;
        }
        public static int DisplayCount()
        {
            return count;
        }
        public override string ToString()
        {
            return $"Emp1 Id {id}\n Emp1 name {name}\n total salary{total} Netpaid {netpaid}";
        }
        public virtual void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da ;
            netpaid = total - (pf + pt);
        }
    }

    public class Manager : Emp1
    {
        private double ta;
        public Manager() : base()
        {
            ta = 0.0;
        }
        public Manager(string name, double bs, double pt, double pf,double ta) : base(name, bs, pt,pf)   
        {
            this.ta = ta;
        }
        public override void CalculateSalary()
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da + ta;
            netpaid = total - (pf + pt);
        }
        public override string ToString()
        {
            return $"Manager Id{id}\n Manager name={name}\n total salary={total}\n netpaid={netpaid}";
        }
    }
}
