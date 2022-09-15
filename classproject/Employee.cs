using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classproject
{
    public class Employee
    {
        private string empname;
        private int empid, basicsalary;
        private int pt=200;
        private double pf;
        private double allowances;
        private double total;
        private double netpaid;

        public  Employee(double pf, int empid,int basicsalary, double allowances, string empname)
        {
            
            this.empname = empname;
            this.empid = empid;
            this.basicsalary = basicsalary;
            this.allowances = allowances;
        }
        public double CalculateTotalSalary()
        {
            total = basicsalary + allowances;
            return total;
        }
        public double CalculateNetpaid()
        {
            netpaid = total - pf - pt;
            return netpaid;
        }

        public string DisplayValue()
        {
            return $"empId={empid}\n name={empname}\n basicsalary={basicsalary}\n allowances={allowances} ";
        }





        //string companyName, name, qualification, gender;
        //int age, salary;

        //public void AssignValue()
        //{
        //    companyName = "linecraft";
        //    name = "sam";
        //    qualification = "BE IT";
        //    gender = "male";
        //    age = 30;
        //    salary = 70000;   
        //}
        //public string DisplayValue()
        //{
        //    return $"Employee Details is: {companyName}/ {name}/ {qualification}/ {gender}/ {age}/ {salary}";
        //}
    }
}
