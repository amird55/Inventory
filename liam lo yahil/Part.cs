using System;
using System.Collections.Generic;
using System.Text;


namespace liam_lo_yahil
{
    class Part
    {
        
        public static IDictionary<int, int> ziv(int idkit, int amount) //traget[id of card,amount]
           {
            kits[] kit =3 new kits[4];
            kit[0] = new kits();
            kit[1] = new kits();
            kit[2] = new kits();
            kit[3] = new kits();
            cards[] card = new cards[4];
            card[0] = new cards();
            card[1] = new cards();
            card[2] = new cards();
            card[3] = new cards();


            IDictionary<int, int> totalparts = new Dictionary<int, int>();
            IDictionary<int, int> totalparts2 = new Dictionary<int, int>();
            totalparts2.Add(999, 777);


            if (storage.getAmountKit(idkit) < amount)

            {
                int[,] cardsArr = kit[idkit].getCards();
                int[,] partsArr = kit[idkit].getParts();

                for (int i = 0; i < cardsArr.GetLength(0); i++)
                {
                    int leftCards = storage.getAmountCards(cardsArr[i,0]) - cardsArr[i,1];
                    if (leftCards < 0)
                    {
                        int[,] partsCards = card[cardsArr[i,0]].getParts();
                        
                        for (int k = 0; k < partsCards.GetLength(0); k++)
                        {
                            totalparts[partsCards[k,0]] = partsCards[k,1] * (leftCards * -1);

                        }
                        for (int j = 0; j < partsArr.GetLength(0); j++)
                        {
                            if (totalparts.ContainsKey(partsArr[j,0]))
                            {
                                totalparts[partsArr[j,0]] += partsArr[j,1];

                            }
                            else
                            {
                                totalparts[partsArr[j,0]] = partsArr[j,1];

                            }
                        }

                    }
                }
                if (totalparts == null)
                {
                    for (int i = 0; i < partsArr.GetLength(1); i++)
                    {

                        if (storage.getAmountParts(partsArr[i,0]) - partsArr[i,1] < 0)
                        {
                            totalparts[partsArr[i,0]] = partsArr[i,1] - storage.getAmountParts(partsArr[i,0]);
                        }



                    }
                    return totalparts;


                }
                else
                {


                    foreach (KeyValuePair<int, int> item in totalparts)
                    {
                        if (item.Value - storage.getAmountParts(item.Key) > 0)
                        {
                            totalparts2[item.Key] = item.Value - storage.getAmountParts(item.Key);
                        }
                        else
                        {
                            totalparts.Remove(item);
                        }
                    }



                }











            }
            return totalparts2;






        }



    }
}
