using System.Collections;
using System;
using System.Runtime.Intrinsics.Arm;

class NewOne{
    public void ShowFilesDirectories(){
            // to get folders
            // IEnumerable<String> listOfDirectories=Directory.EnumerateDirectories("stores");
            // foreach(var i in listOfDirectories)
            //     Console.WriteLine(i);

            // to get files in specific folder
            // IEnumerable<String> listOfFiles=Directory.EnumerateFiles("stores");
            // foreach(var i in listOfFiles)
            //     Console.WriteLine(i);

            // to get all the files in every folders
            // IEnumerable<String> allFilesInAllDirectories=Directory.EnumerateFiles("stores","*.*",SearchOption.AllDirectories);
            // foreach(var j in allFilesInAllDirectories)
            //     System.Console.WriteLine(j);
            
            // to find files uniquely
            List<String> myFile=new List<string>();
            
            IEnumerable<String> findFile=Directory.EnumerateFiles("stores","*",SearchOption.AllDirectories);
            foreach(var j in findFile){
                if(j.EndsWith("s2.txt"))
                    myFile.Add(j);
            }
            foreach(var f in myFile)
                System.Console.WriteLine(f);

    }
}