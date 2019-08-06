using System;
using System.IO;

namespace Task51
{
    public static class GlobalVar
    {
        public static string pathToBackup = @"C:\backup\";

        public static string PathToBackup
        {
            get => pathToBackup;
            private set { pathToBackup = value; }
        }
        public static string pathToCatalog = "../../../task5_test";
        public static string PathToCatalog
        {
            get => pathToCatalog;
            private set { pathToCatalog = value; }
        }

    }
    public class Start
    {
        public enum AppStates
        {
            Observation = 1,
            RollbackChanges = 2,
            Exit = 3,
            Default = 0
        }
        AppStates state = AppStates.Default;
        public AppStates State
        {
            get => state;
            set
            {
                state = value;
                StateAction(state);
            }
        }
        public void Loop()
        {
            while (state == AppStates.Default)
            {
                Console.Write("Which mode do you want to enable 1-3?");
                Console.WriteLine(Environment.NewLine + string.Join("\n", menuHelp));
                var key = Console.ReadKey();
                Console.WriteLine(Environment.NewLine);
                State = Parse(key.KeyChar);
            }
        }

        string[] menuHelp = new string[]  {
            "1. Observation",
            "2. Rollback changes",
            "3. Exit"
        };

        public static AppStates Parse(char ch)
        {
            switch (ch)
            {
                case '1':
                    return AppStates.Observation;
                case '2':
                    return AppStates.RollbackChanges;
                case '3':
                    return AppStates.Exit;
                default:
                    return AppStates.Default;
            }
        }

        void StateAction(AppStates state)
        {
            switch (state)
            {
                case AppStates.Observation:
                    MyFileHolder.CreatePath();
                    break;
                case AppStates.RollbackChanges:
                    Rollback.RollbackChanges();
                    break;
                case AppStates.Exit:
                    break;
                case AppStates.Default:
                    Console.WriteLine("Incorrect input.");
                    Console.WriteLine(Environment.NewLine);
                    break;
                default:
                    break;
            }
        }
    }
}
