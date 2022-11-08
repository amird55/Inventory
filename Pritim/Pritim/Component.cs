using System;
using System.Collections.Generic;
using System.Text;

namespace Pritim
{
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
        { this.Id = value; }
        public void SetName(string value)
        { this.Name = value; }
        public void SetDeliveryTime(int value)
        { this.DeliveryTime = value; }
        public void SetPrice(int value)
        { this.Price = value; }

        public string ToString()
        {
            return "component identifier " + this.Id
            + " name " + this.Name
            + " takes " + this.DeliveryTime
            + " days to get delivered and costs " + this.Price + " shekels";
        }

    }
}
