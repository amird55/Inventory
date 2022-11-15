using System;
using System.IO;
using System.Collections.Generic;

class SaveFile {
    
    static string DataBaseDirPath = Directory.GetCurrentDirectory()+"\\AppDB";
    static string CardProcessPath = DataBaseDirPath + "\\DataBase.txt";

    static void Main() {
            if(!File.Exists(CardProcessPath)){
                Directory.CreateDirectory(DataBaseDirPath);
                Console.WriteLine("created app db dir");
                // using (StreamWriter sw = File.CreateText(CardProcessPath)){
                //     sw.WriteLine("hey how are tou");
                // }
            }
            else{
                // Console.WriteLine("got to the read part");
                // string[] readText = File.ReadAllLines(CardProcessPath);
                // // foreach(string s in readText){
                // //     Console.WriteLine(s);
                // }
            }
            List<string> lines = GetAllLinesFilteredByCardId("2233");
            foreach(string line in lines){
                Console.WriteLine(line);
            }
        }


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
            string lineId = line.Split(new string[] {"@@"}, StringSplitOptions.None)[1];
            if(lineId == id){
                returnList.Add(line);
            }
        }
        return returnList;
    }
    }



    // public static void addProcessTime(string compID, string empID, double proccessTime){
    //     // string filePath = "\\AppDB\\DataBase.txt";

    // }

    //TODO:
        //file 1
        //1: Gets a component's ID and returns all making times 
        //2: gets an Employee's ID and returns all making times
        // EmpID-CardID-ProcessID-Time-CardCount
        

        //file 2:
        //1: Gets a Employee's ID and returns all past Payments and Dates 
        // EmpID-Payment-DateTime (example of a row)



    // public static bool SaveProcessTime(double processTime) {}

    // public static double GetProcessTime() {}

    // public static bool AddUpdatePayment() {}

    // public static double getPayment() {}



