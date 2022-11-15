using System;
using System.IO;
using System.Collections.Generic;


//file 1: cardDatatBase.txt => contains EmpID@@cardID@@processID@@Time@@CardCount

//file 2: PaymentDataBase.txt => contains EmpID@@Payment@@DateTime

//if file doesnt exists will create one automaticlly

class SaveFile {
    
    static string DataBaseDirPath = Directory.GetCurrentDirectory()+"\\AppDB";
    static string CardProcessPath = DataBaseDirPath + "\\CardDataBase.txt";
    static string PaymentPath = DataBaseDirPath + "\\PaymentDataBase.txt";

    static void Main() { //main example is commented:
            if(!File.Exists(CardProcessPath)){
                Directory.CreateDirectory(DataBaseDirPath);
                Console.WriteLine("created app db dir");
            }
    }
    //         AddLineToCardProcess("1234@@bhj");
    //         List<string> lines = GetAllLinesFilteredByCardId("1234");
    //         foreach(string line in lines){
    //             Console.WriteLine(line);
    //         }
    //     }


    public static void AddLineToCardProcess(string line){
        using (StreamWriter sw = File.AppendText(CardProcessPath)){
                sw.WriteLine(line);
                
            }
    }

    public static string[] GetAllLinesFromCardProcess(){
        return File.ReadAllLines(CardProcessPath);
    }

    public static  List<string> GetAllLinesFilteredByEmpId(string id){
        string[] lines = File.ReadAllLines(CardProcessPath);
        List<string> returnList = new List<string>();   
        foreach(string line in lines){
            string lineId = line.Split(new string[] {"@@"}, StringSplitOptions.None)[0];
            if(lineId == id){
                returnList.Add(line);
            }
        }
        return returnList;
    }

    public static  List<string> GetAllLinesFilteredByCardId(string id){
        string[] lines = File.ReadAllLines(CardProcessPath);
        List<string> returnList = new List<string>();   
        foreach(string line in lines){
            string lineId = line.Split(new string[] {"@@"}, StringSplitOptions.None)[0];
            if(lineId == id){
                returnList.Add(line);
            }
        }
        return returnList;
    }

    //#####################################################################

    public static void AddLineToPayment(string line){
        using (StreamWriter sw = File.AppendText(PaymentPath)){
                sw.WriteLine(line);
                
            }
    }

    public static string[] GetAllLinesFromPayment(){
        return File.ReadAllLines(PaymentPath);
    }

    public static  List<string> GetAllPaymentLinesFilteredByEmpId(string id){
        string[] lines = File.ReadAllLines(PaymentPath);
        List<string> returnList = new List<string>();   
        foreach(string line in lines){
            string lineId = line.Split(new string[] {"@@"}, StringSplitOptions.None)[0];
            if(lineId == id){
                returnList.Add(line);
            }
        }
        return returnList;
    }
    
}
