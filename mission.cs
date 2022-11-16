using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace amirProject
{
    class mission
    {
        // mission string template: "CardID@ProccessID@EmpID@Time@CardCount"

        public int empId;
        private DateTime start;
        private DateTime end;
        private int cardID;
        private int processID;
        private int quantity;
        public void setEmpId(int empId)
        {
            this.empId = empId;
        }
        public int getEmpId()
        {
            return empId;
        }
        public void setStart(DateTime start)
        {
            this.start = start;
        }
        public DateTime getStart()
        {
            return start;
        }
        public void setEnd(DateTime end)
        {
            this.end = end;
        }
        public DateTime getEnd()
        {
            return end;
        }
        public void setCardId(int cardId)
        {
            this.cardID = cardId;
        }
        public int getCardId()
        {
            return cardID;
        }
        public void setProcessID(int processID)
        {
            this.processID = processID;
        }
        public int getProcessID()
        {
            return processID;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getQuantity()
        {
            return quantity;
        }
        public mission(int empId, DateTime start, DateTime end, int cardId, int processID, int quantity)
        {
            this.empId=empId;
            this.start = start;
            this.end = end;
            this.cardID=cardId;
            this.processID=processID;
            this.quantity = quantity;

        }
        public override string ToString() => $"{cardID}@@{processID}@@{empId}@@{missiontDurtion}@@{quantity}";

        public double missiontDurtion() => (end - start).TotalHours;
    }
}