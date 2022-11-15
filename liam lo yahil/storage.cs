using System;
using System.Collections.Generic;
using System.Text;

namespace liam_lo_yahil
{
    
    class storage
    {
        public static int getAmountKit(int kitid)
        {
            return 2;
        }
        public static int getAmountCards(int cardid)
        {
            switch (cardid){
                case 1:
                    return 1;
                   
                case 2:
                    return 2;
                   
                case 3:
                    return 2;
                    
                default:
                    return 4;
                    


            }

        }
        public static int getAmountParts(int partid)
        {
            switch (partid)
            {
                case 10:
                    return 1;
                    
                case 20:
                    return 2;
                    
                case 30:
                    return 2;
                    
                default:
                    return 4;
                    


            }


        }



    }
}
