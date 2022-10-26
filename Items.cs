using System;

namespace Pritim
{
    class Process
    {
        private double StartTime;
        private double EndTime;

        public Process(double StartTime, double EndTime)
        {
            this.StartTime = 0.0;
            this.EndTime = EndTime;
        }
        private void setStart(double StartTime)
        {
            this.StartTime = StartTime;
        }

        private void setEnd(double EndTime)
        {
            this.EndTime = EndTime;
        }
    }

        class Component
    {
        private int Id;
        private string Name;
        private int DeliveryTime;
        private double Price;

        public Component(Component other)
        {
            this.Id = other.GetId();
            this.Name = other.GetName();
            this.DeliveryTime = other.GetDeliveryTime();
            this.Price = other.GetPrice();
        }

        public Component(int id, string name, int DeliveryTime, double price)
        {
            this.Id = id;
            this.Name = name;
            this.DeliveryTime = DeliveryTime;
            this.Price = price;
        }


        public int GetId()
        { return this.Id; }
        public string GetName()
        { return this.Name; }
        public int GetDeliveryTime()
        { return this.DeliveryTime; }
        public double GetPrice()
        { return this.Price; }
        public void SetId(int value)
        {
            this.Id = value;
        }
        public void SetName(string value)
        {
            this.Name = value;
        }
        public void SetDeliveryTime(int value)
        {
            this.DeliveryTime = value;
        }
        public void SetPrice(int value)
        {
            this.Price = value;
        }

        public string ToString()
        {
            return "component identifier " + this.Id 
            + " name " + this.Name 
            + " takes " + this.DeliveryTime 
            + " days to get delivered and costs " + this.Price + " shekels";
        }
        
    }

    class Card
    {
        private int Id;
        private string Name;
        private Component [] Components;
        private double Price;
        private Process[] Process;

        public Card(Card other)
        {
            this.Id = other.GetId();
            this.Name = other.GetName();
            this.Components = other.GetComponents();
            this.Price = other.GetPrice();
            //this.Process = other.GetProcess();
        }

        public Card(int Id, string Name, Component[] Components, double Price, Process Process)
        {
            this.Id = Id;
            this.Name = Name;
            this.Components = Components;
            this.Price = Price;
            //this.Process[] = Process;
        }

        public Card(int Id, string Name, Component[] Components, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Components = Components;
            this.Price = Price;
            this.Process[] = new Process[3];
        }

        public void SetWeldTimes(double S_Time, double E_Time)
        {
            this.Process[0] = new Process(S_Time, E_Time);
        }

        public void SetPinTimes(double S_Time, double E_Time)
        {
            this.Process[1] = new Process(S_Time, E_Time);
        }

        public void SetCheckTimes(double S_Time, double E_Time)
        {
            this.Process[2] = new Process(S_Time, E_Time);
        }

        public string ToString()
        {
            string s1 = "";
            for (int i=0;i<this.Components.Length;i++)
            {
                s1 += this.Components[i].GetName()+" ";
            }
            string s2 = "";
            /*for(int i=0;i<this.Process.Length;i++)
            {
                s2 += this.Process[i].ToString();
            }*/
            return "card identifier number is " + this.Id
            + " name "+this.Name
            +" Component list "+s1
            +" price "+this.Price;
        }

        public int GetId()
        { return this.Id; }
        public string GetName()
        { return this.Name; }
        public Component[] GetComponents()
        { return this.Components; }
        public double GetPrice()
        { return this.Price; }

        public void SetId(int value)
        {
            this.Id = value;
        }
        public void SetName(string value)
        {
            this.Name = value;
        }
        public void SetComponents(Component[] a)
        { this.Components = a; }
        public void SetPrice(int value)
        {
            this.Price = value;
        }

        public 
    }


    class Kits
    {
        private int Id;
        private string Name;
        private Component[] Components;
        private Card[] Cards;
        private string DueDate;

        public Kits(int Id, string Name, Component[] Components, Card[] Cards, string DueDate)
        {
            this.Id = Id;
            this.Name = Name;
            this.Components = Components;
            this.Cards = Cards;
            this.DueDate = DueDate;
        }
        public Kits(Kits other)
        {
            this.Id = other.GetId();
            this.Name = other.GetName();
            this.Components = other.GetComponents();
            this.Cards = other.GetCards();
            this.DueDate = other.GetDueDate();
        }


        public int GetId()
        { return this.Id; }
        public string GetName()
        { return this.Name; }
        public Component[] GetComponents()
        { return this.Components; }
        public Card[] GetCards()
        { return this.Cards; }
        public string GetDueDate()
        { return this.DueDate; }

        public void SetId(int value)
        {
            this.Id = value;
        }
        public void SetName(string value)
        {
            this.Name = value;
        }
        public void SetComponents(Component[] a)
        { this.Components=a; }
        public void SetCards(Card[] a)
        { this.Cards=a; }
        public void SetDueDate(string a)
        {  this.DueDate= a; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
