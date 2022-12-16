using System;
using System.Collections.Generic;
using System.IO;

namespace SH_file_handling_assignment
{
    public class Createfile
    {
            public void Create()
            {
                Console.Clear();
                Console.WriteLine("------ Create File ------\n");
                bool flag = true;
                List<string> textList = new List<string>();
                while (flag)
                {
                    Console.WriteLine("Write a line\n");

                    string temp = Console.ReadLine();

                    if (temp != "")
                    {
                        textList.Add(temp);
                        Console.WriteLine("\n1.Continue\n2.Save\n3.Exit");
                        string ch = Console.ReadLine();

                        if (ch == "1") continue;
                        else if (ch == "2")
                        {
                            flag = false;
                            FileCreation(textList);
                            Console.WriteLine("File Created! \n");
                            Console.WriteLine("\nPress enter to return to main menu!");
                            Console.ReadLine();
                        }
                        else if (ch == "3")
                        {
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input! Re-enter");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are not enter any text !\n");
                    }
                }
            }
            public void FileCreation(List<string> textList)
            {
                Console.WriteLine("\nName of the file:");
                string fileName = Console.ReadLine();

                string path = $@"C:\Users\anjit\source\repos\SH_C# Practice work\SH_file handling assignment\SH_file handling assignment\text\{fileName}.txt";

                try
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        foreach (var item in textList)
                        {
                            sw.WriteLine(item);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
       
            }
    }
}
