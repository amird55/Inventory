using System;
using System.Collections.Generic;
using System.Text;

namespace Pritim
{
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

        /*public Component[,] GetComponents2()
        {
            int Len = 0;
            for(int i=0;i<this.Components.Length-1;i++)
            {
                for(int j=i+1;j<this.Components.Length;j++)
                {
                    if(this.Components[i].GetId()==this.Components[j].GetId())
                    {
                        Len++;
                        break;
                    }
                }
            }
            Component[,] temp= new Component[this.Components.Length-Len,2];

            int count = 0;
            for(int i=0;i<this.Components.Length;i++)
            {
                bool exist = false;
                for(int j=0;j<i;j++)
                {
                    if (this.Components[j].GetId() == temp[i, 1].GetId())
                    {
                        temp[i, 2]++;
                        exist = true;
                        break;
                    }
                }
                if(!exist)
                {
                    temp[]
                }
            }
        }*/

        public Card[] GetCards()
        { return this.Cards; }
        public string GetDueDate()
        { return this.DueDate; }

        public void SetId(int value)
        { this.Id = value; }
        public void SetName(string value)
        { this.Name = value; }
        public void SetComponents(Component[] a)
        { this.Components = a; }
        public void SetCards(Card[] a)
        { this.Cards = a; }
        public void SetDueDate(string a)
        { this.DueDate = a; }
    }
}
