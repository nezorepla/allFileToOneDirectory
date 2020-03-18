using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace allFileInDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo d = new DirectoryInfo(@"D:\eski samsung pc\sources\Vuze Downloads");
            //FileInfo[] Files = d.GetFiles("*.mp4");
            //string path = @"C:\Program Files (x86)";

            DirectoryInfo root = new DirectoryInfo(@"..\..\..\..\..\..\..\..\..\..\");
            DirectoryInfo[] directoryList = root.GetDirectories();
            ulong FreeBytesAvailable;
            ulong TotalCapacity;
            ulong TotalFreeBytes;








            string path = @"D:\vuze";
            string dest = @"D:\eski samsung pc\sources\new_2\t\";
            int i = 1;
            string all = "i;info.Name +;info.Extension;info.LastAccessTime ; info.LastWriteTime ;info.Length; info.DirectoryName;info.CreationTime";
            string n="";
            // try            {
            string[] allfiles = Directory.GetFiles(path, "*.mp4", SearchOption.AllDirectories);

            foreach (var file in allfiles)
            {
                FileInfo info = new FileInfo(file);
                // if (info.Extension.ToLower() == ".mkv" | info.Extension.ToLower() == ".mp4" | info.Extension.ToLower() == ".avi"| info.Extension.ToLower() == ".mpg" | info.Extension.ToLower()== ".flv")
                {
                      

                  /*      Console.WriteLine(i.ToString() + ";" + info.Name + ";" + info.Extension.ToLower() + ";" + info.LastAccessTime + ";" + info.LastWriteTime + ";"
                             + info.Length.ToString() + ";" + info.DirectoryName + ";" + info.CreationTime.ToLongTimeString());
                    all += i.ToString() + ";" + info.Name + ";" + info.Extension.ToLower() + ";" + info.LastAccessTime + ";" + info.LastWriteTime + ";"
                       + info.Length.ToString() + ";" + info.DirectoryName + ";" + info.CreationTime.ToLongTimeString() + System.Environment.NewLine;
                        */
                      
               try{
                        n = info.Name.ToString();
                     
                           File.Move(file, dest + n);
                      /*   if (n.Substring(1, 1) == "-")
                    {
                        File.Move(file, dest + n.Substring(2, n.Length - 2));  
                        Console.WriteLine(n.Substring(2,n.Length-2));
                    }

                   if (info.Name.ToString().Substring(2, 1) == "-")
                    {
                        File.Move(file, dest + n.Substring(3, n.Length - 3));
                        Console.WriteLine(n.Substring(3, n.Length - 3));
                    } 
                    if (info.Name.ToString().Substring(3, 1) == "-")
                    {
                        File.Move(file, dest + n.Substring(4, n.Length - 4));
                        Console.WriteLine(n.Substring(4, n.Length - 4));
                    } 
                    */

                    //  
  }            catch{}
                    i++;
                    // }
                }
            }
            // 

            //File.WriteAllText(dest  + "ALLFILES_vuze2.csv", all, Encoding.GetEncoding("ISO-8859-1"));
            Console.ReadKey();
        }
    }
}
