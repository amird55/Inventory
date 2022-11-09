namespace InventoryReportTest
{
    static class A
    {
        public static void Main(string[] args)
        {
            InventoryManager inventoryManager = new InventoryManager();

            inventoryManager.InventoryReport();

            Card[] cards = new Card[6];
            Board[] boards = new Board[6];
            for (int i = 1; i <= 6; i++)
            {
                cards[i - 1] = new Card($"{i}", $"{i}", ((30 + i) / 2) * i, inventoryManager);
                boards[i - 1] = new Board($"{i}", $"{8 - i}", ((100 + i) / 2) * i, inventoryManager);
            }

            inventoryManager.InventoryReport();
        }
    }
    
    public class Board
    {
        public string type;
        public string id;
        public double cost;
        public Board(string id, string type, double cost, InventoryManager IM)
        {
            this.id = id;
            this.type = type;
            this.cost = cost;
            
            IM.AddBoard(this);
        }
    }
    
    public class Card
    {
        public string type;
        public string id;
        public double cost;

        public Card(string id, string type, double cost, InventoryManager IM)
        {
            this.id = id;
            this.type = type;
            this.cost = cost;
            
            
            IM.AddCard(this);
        }
    }
}