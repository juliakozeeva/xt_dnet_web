using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task51
{
    public class Watcher 
    {
        public static void MonitorDirectory(DirectoryInfo testDir)
        {
            Console.WriteLine("Observation mode set.");

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = testDir.FullName;
            watcher.NotifyFilter = NotifyFilters.LastAccess
                     | NotifyFilters.LastWrite
                     | NotifyFilters.FileName
                     | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.Error += new ErrorEventHandler(OnError);
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

            CopyFile();

            Console.WriteLine("Press 'q' to quit the sample.");
            while (Console.Read() != 'q') ;            
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            CopyFile();
            Console.WriteLine("{1}: {0}", e.Name, e.ChangeType);
            
        }
        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            CopyFile();
            Console.WriteLine($"{e.OldName} renamed to {e.Name}");

        }

        private static void OnError(object source, ErrorEventArgs e)
        {
            Console.WriteLine("The FileSystemWatcher has detected an error");
            if (e.GetException().GetType() == typeof(InternalBufferOverflowException))
            {
                Console.WriteLine(("The file system watcher experienced an internal buffer overflow: " + e.GetException().Message));
            }
        }

        private static void CopyFile()
        {
            DateTime dt = DateTime.Now;
            string pathDate = GlobalVar.pathToBackup + "\\" + dt.ToString().Replace(":", "."); //folder name cannot contain ":"
            DirectoryInfo dirDate = new DirectoryInfo(pathDate);
            dirDate.Create();
            foreach (string dirPath in Directory.GetDirectories(GlobalVar.pathToCatalog, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(GlobalVar.pathToCatalog, pathDate));
            }
            foreach (string filePath in Directory.GetFiles(GlobalVar.pathToCatalog, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(filePath, filePath.Replace(GlobalVar.pathToCatalog, pathDate), true);
            }
        }
    }
}
