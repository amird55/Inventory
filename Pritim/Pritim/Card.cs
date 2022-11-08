using System;
using System.Collections.Generic;
using System.Text;

namespace Pritim
{
    class Card
    {
        private int Id;
        private string Name;
        private Component[] Components;
        private Process[] Process;

        public Card(Card other)
        {
            this.Id = other.GetId();
            this.Name = other.GetName();
            this.Components = other.GetComponents();
            this.Process = other.GetProcesses();
        }
        public Card(int Id, string Name, Component[] Components,Process[] Process)
        {
            this.Id = Id;
            this.Name = Name;
            this.Components = Components;
            this.Process = Process;
        }
        public Card(int Id, string Name, Component[] Components)
        {
            this.Id = Id;
            this.Name = Name;
            this.Components = Components;
            this.Process = new Process[3];
        }

        public TimeSpan GetTotalWorkTime()
        {
            TimeSpan temp = new TimeSpan(0);
            temp = temp.Add(this.Process[0].CalcTime());
            temp = temp.Add(this.Process[1].CalcTime());
            temp = temp.Add(this.Process[2].CalcTime());
            return temp;
        }

        public Double GetTotalWorkTimeHours()
        {
            TimeSpan temp = new TimeSpan(0);
            temp = temp.Add(this.Process[0].CalcTime());
            temp = temp.Add(this.Process[1].CalcTime());
            temp = temp.Add(this.Process[2].CalcTime());
            return temp.TotalHours;
        }

        public double AssemblyCost(double Salary)
        {
            return Salary * this.GetTotalWorkTimeHours();
        }

        public double TotalAssemblyCost(double Salary)
        {
            double TotalP = 0;
            for(int i=0;i<this.Components.Length;i++)
            {
                TotalP += this.Components[i].GetPrice();
            }
            return (Salary * this.GetTotalWorkTimeHours())+TotalP;
        }

        public void SetWeldTimes(DateTime S_Time, DateTime E_Time)
        {
            this.Process[0] = new Process(S_Time, E_Time);
        }
        public void SetPinTimes(DateTime S_Time, DateTime E_Time)
        {
            this.Process[1] = new Process(S_Time, E_Time);
        }
        public void SetCheckTimes(DateTime S_Time, DateTime E_Time)
        {
            this.Process[2] = new Process(S_Time, E_Time);
        }

        public string ToString()
        {
            string s1 = "";
            for (int i = 0; i < this.Components.Length; i++)
            {
                s1 += this.Components[i].GetName() + " ";
            }
            string s2 = "";
            for(int i=0;i<this.Process.Length;i++)
            {
                s2 += this.Process[i].ToString();
            }
            return "card identifier number is " + this.Id
            + " name " + this.Name
            + " Component list " + s1;
        }

        public int GetId()
        { return this.Id; }
        public string GetName()
        { return this.Name; }
        public Component[] GetComponents()
        { return this.Components; }
        public Process[] GetProcesses()
        {return this.Process;}
        public void SetId(int value)
        { this.Id = value; }
        public void SetName(string value)
        { this.Name = value; }
        public void SetComponents(Component[] a)
        { this.Components = a; }
        public void SetProcesses(Process[] a)
        { this.Process = a; }

    }
}
