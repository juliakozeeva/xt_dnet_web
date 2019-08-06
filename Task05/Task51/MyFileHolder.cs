using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Task51
{    
    public class MyFileHolder 
    {
        public static void CreatePath()
        {
            if (!Directory.Exists(GlobalVar.pathToBackup))
            {
                Directory.CreateDirectory(GlobalVar.pathToBackup);
            }

            if (!Directory.Exists(GlobalVar.pathToCatalog))
            {
                Directory.CreateDirectory(GlobalVar.pathToCatalog);
            }
            
            DirectoryInfo txtFiles = new DirectoryInfo(GlobalVar.pathToCatalog);
            if (Directory.EnumerateDirectories(GlobalVar.pathToCatalog, "*", SearchOption.AllDirectories).Count() == 0 && 
                Directory.EnumerateFiles(GlobalVar.pathToCatalog, "*.*", SearchOption.AllDirectories).Count() == 0)
            {
                Console.WriteLine("Folder is empty.");
            }
            else
            {
                Console.WriteLine("Text files located in this folder and in its subfolders:");
                HierarchicalItem.getTreeStructure(txtFiles);
            }

            Watcher.MonitorDirectory(txtFiles);            
        }
    }        
}
