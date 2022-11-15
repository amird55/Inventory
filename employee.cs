using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amirProject
{
    class employee
    {
        private int id;
        private string fullName;
        private string phone;
        private string email;
        private double salaryPerHour;
        //private double avgCardTime[];//for what?



        public void setID(int id)
        {
            this.id = id;
        }
        public int getID()
        {
            return id;
        }
        public void setFullName(string fullName)
        {
            this.fullName = fullName;
        }
        public string getFullName()
        {
            return fullName;
        }
        public void setPhone(string phone)
        {
            this.phone = phone;
        }
        public string getPhone()
        {
            return phone;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }

        public void setSalaryPerHour(double salaryPerHour)
        {
            this.salaryPerHour = salaryPerHour;
        }
        public double getSalaryPerHour()
        {
            return salaryPerHour;
        }

        public override string ToString() => $"{id}@@{fullName}@@{phone}@@{email}@@{salaryPerHour}";
        public employee(int id, string fullName, string phone, string email, double salaryPerHour)
        {
            this.id = id;
            this.fullName = fullName;
            this.phone = phone;
            this.email = email;
            this.salaryPerHour = salaryPerHour;
        } 
    }
}


