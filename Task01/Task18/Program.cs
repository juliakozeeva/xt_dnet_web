using System;

namespace Task18
{
    class NoPositive
    {
        static void Main(string[] args)
        {            
            CreateArray();

            Console.ReadLine();
        }

        static void CreateArray()
        {
            int[,,] array = new int[4, 2, 3];
            Random r = new Random();

            Console.WriteLine($"Массив до обнуления: ");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i,j,k] = r.Next(-100, 100);
                        Console.Write(array[i, j, k]+ " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            ChangeElements(array);
        }

        static void ChangeElements (int[,,] arr)
        {
            Console.WriteLine($"Массив после обнуления: ");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                            Console.Write(arr[i, j, k] + " ");
                        }  
                        else
                        {
                            Console.Write(arr[i, j, k] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
