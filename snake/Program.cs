using System;
using System.Threading;
using System.Threading.Tasks;

namespace Shiqvlizi.SnakeGame
{
    internal partial class Program
    {
        static void Main()
        {
            int[,] mapp = new int[20, 20];
            string[,] map = new string[20, 40];
            for (int n = 0; n < 40; n++)
            {
                map[0, n] = "=";
            }
            for (int j = 0; j < 40; j++)
            {
                for (int i = 1; i < 20; i++)
                {
                    map[i, j] = "█";
                }
            }
            map[10, 20] = " ";
            while (true)
            {
                for (int k = 0; k < 20; k++)
                {
                    Console.WriteLine();
                    for (int m = 0; m < 40; m++)
                    {

                        Console.Write(map[k, m]);
                    }
                }
                Thread.Sleep(1000);
            }
        }

        static void MyMain()
        {

        }
    }
}
