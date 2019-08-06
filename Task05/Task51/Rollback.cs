using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Task51
{
    public class Rollback 
    {
        public static void RollbackChanges()
        {
            DirectoryInfo dirLog = new DirectoryInfo(GlobalVar.pathToBackup);
            HierarchicalItem.getTreeStructure(dirLog);

            string pathDate = CheckDatetime();

            try
            {
                DirectoryInfo dirToCatalog = new DirectoryInfo(GlobalVar.pathToCatalog);
                foreach (FileInfo file in dirToCatalog.EnumerateFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in dirToCatalog.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
                foreach (var dir in Directory.GetDirectories(pathDate, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dir.Replace(pathDate, GlobalVar.pathToCatalog));
                }
                foreach (var item in Directory.GetFiles(pathDate, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(item, item.Replace(pathDate, GlobalVar.pathToCatalog), true);
                }

                Console.WriteLine("Rollback completed.");

            }
            catch (DirectoryNotFoundException dirEx)
            {
                Console.WriteLine("Directory not found: " + dirEx.Message);
                Console.WriteLine("Enter the correct date and time to roll back the changes.");
            }


        }

        static string CheckDatetime()
        {
            Console.WriteLine("Select the date with time for which the rollback should be performed:");

            while (true)
            {
                string inputDate = Console.ReadLine();

                if (DateTime.TryParseExact(inputDate, "dd.MM.yyyy HH.mm.ss", null, DateTimeStyles.None, out DateTime dt))
                    return inputDate = GlobalVar.pathToBackup + "\\" + dt.ToString().Replace(':', '.');
                else
                    Console.WriteLine("Enter the correct date and time to roll back the changes.");
            }
        }
    }
}
