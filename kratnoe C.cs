using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // кратное С
            Random ran = new Random();
            Console.WriteLine("Введите кол-во строк");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int m = int.Parse(Console.ReadLine());
            int[,] roll = new int[n, m];
            Console.WriteLine("Исходный массив");
            for (int i=0; i<n; i++)
            {
                Console.WriteLine(" ");
                for(int k=0; k<m; k++)
                {
                    roll[i, k] = ran.Next(1, 10);
                    Console.Write(roll[i, k] + " ");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите кратное");
            int c = int.Parse(Console.ReadLine());
            int[] asd = new int[n * m];
            Console.WriteLine("Новый массив");
            for (int i=0; i<n; i++)
                for(int k=0; k<m; k++)
                    if(roll[i,k]%c==0)
                    {
                        asd[i] = roll[i, k];
                        Console.WriteLine(asd[i] + " ");
                    }

            Console.ReadKey();
        }
    }
}
