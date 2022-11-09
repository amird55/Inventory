using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Xml.Schema;
internal class Program
{ 
    public static void Main(string[] args)
    {

    }
    public static void DistinguishedEmployee(Employee[] emp)
    {
        double[,] avgtimesperemp= new double[7,50];
        int[] maxplace= new int[7];
        for(int i = 0; i <7 ; i++)
        {
            double min = emp[0]. getCardTime(0);
            int minplace;
            for(int j=0; j<50; j++)
            {
                avgtimesperemp[i,j] = emp[j]. getCardTime(i);
                if (avgtimesperemp[i, j]< min)
                {
                    minplace = j;
                    min=avgtimesperemp[i,j];
                }

            }
            maxplace[i]=minplace;
        }
        int maxcount=0, maxcountplace;
        for(int place = 0; place < 7 ; place++)
        {
            int Countperemp=1;
            for(int check = 0; check < 7 ; check++)
            {
                if (maxplace[check] = maxplace[place])
                    Countperemp++;
            }
            if (Countperemp > maxcount)
            {
                maxcount=Countperemp;
                maxcountplace=place;
            }
        }
        Console.Write("the distinguished employee is: "+ emp[maxcountplace].getName());
    }
}