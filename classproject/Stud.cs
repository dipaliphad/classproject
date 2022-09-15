using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classproject
{
    public class Stud
    {
        private string name;
        private int roolno;
        private int s1, s2, s3;
        public int total;
        public double per;

        public Stud(string name, int roolno, int s1, int s2, int s3)
        {
            this.name = name;
            this.roolno = roolno;
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            
        }
        public void Percentage()
        {
            total = s1+s2+s3;
            per = (total/3);
        }
        public string DisplayValue()
        {
            return $"Student Details is:   {name}/ {roolno}/ {per}";
        }
    }
}
