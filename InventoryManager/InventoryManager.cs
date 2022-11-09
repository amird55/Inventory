using System;
using System.Collections.Generic;
using System.IO;

namespace InventoryReportTest
{
    public class InventoryManager
    {
        private LinkedList<Card> _cardsSold = new LinkedList<Card>();
        private LinkedList<Board> _boardsSold = new LinkedList<Board>();

        private LinkedList<Card> _cardsStored = new LinkedList<Card>();
        private LinkedList<Board> _boardsStored = new LinkedList<Board>();

        public InventoryManager()
        {
        }

        public InventoryManager(string dbPath)
        {
            LoadComponents(dbPath);
        }

        public void SellCard(Card c)
        {
            _cardsSold.AddLast(c);
            _cardsStored.Remove(c);
        }

        public void SellBoard(Board b)
        {
            _boardsSold.AddLast(b);
            _boardsStored.Remove(b);
        }

        public void AddCard(Card c)
        {
            _cardsStored.AddLast(c);
        }

        public void AddBoard(Board b)
        {
            _boardsStored.AddLast(b);
        }


        private void LoadComponents(string dbPath)
        {
            // TODO: complete this
        }

        public void InventoryReport()
        {
            string path = $".\\InventoryReport\\{DateTime.Now: yyyy-MM-dd hhmmss}.log";

            FileInfo file = new FileInfo(path);
            file.Directory.Create(); // If the directory already exists, does nothing
            var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            var streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine($"Inventory report as of {DateTime.Now: yyyy-MM-dd hh:mm:ss}:");

            streamWriter.WriteLine("Stored Cards:");
            double cardSum = 0;
            foreach (Card card in _cardsStored)
            {
                streamWriter.WriteLine($"card type {card.type}, id: {card.id}, cost: {card.cost}₪");
                cardSum += card.cost;
            }
            streamWriter.WriteLine($"Card sum: {cardSum}₪\n");

            streamWriter.WriteLine("Stored Boards:");
            double boardSum = 0;
            foreach (Board board in _boardsStored)
            {
                streamWriter.WriteLine($"board type {board.type}, id: {board.id}, cost: {board.cost}₪");
                boardSum += board.cost;
            }
            streamWriter.WriteLine($"Board sum: {boardSum}₪\n");

            streamWriter.WriteLine($"Total sum: {boardSum + cardSum}₪");
            streamWriter.Close();
        }
    }
}