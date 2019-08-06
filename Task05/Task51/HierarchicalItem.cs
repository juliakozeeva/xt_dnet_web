using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task51
{
    public static class HierarchicalItem
    {
        public static string ScanFolder(DirectoryInfo directory, string indentation = "\t", int maxLevel = -1, int deep = 0)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(string.Concat(Enumerable.Repeat(indentation, deep)) + directory.Name);

            if (maxLevel == -1 || maxLevel < deep)
            {
                foreach (var subdirectory in directory.GetDirectories())
                    builder.Append(ScanFolder(subdirectory, indentation, maxLevel, deep + 1));
            }

            foreach (var file in directory.GetFiles())
                builder.AppendLine(string.Concat(Enumerable.Repeat(indentation, deep + 1)) + file.Name);

            return builder.ToString();
        }

        public static void getTreeStructure (DirectoryInfo directory)
        {
            string treeStructure = ScanFolder(directory);
            Console.WriteLine(treeStructure);
        }
    }
}
