using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WordOfTanks;


namespace Day7_Tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Tank[] TankP = new Tank[5];
            Tank[] TankT = new Tank[5];
            Tank[] VinT = new Tank[5];

            //создаем массивы танков Победителей
            for (int i = 0; i < TankP.Length; i++)
            {
                VinT[i] = new Tank();
            }

            //создаем массивы танков Pantera
            for (int i = 0; i < TankP.Length; i++)
            {
                TankP[i] = new Tank("Pantera");
                Thread.Sleep(200);
            }

            //создаем массивы танков T-34
            for (int i = 0; i < TankT.Length; i++)
            {
                TankT[i] = new Tank("T-34");
                Thread.Sleep(200);
            }

            //Сражение танков
            for (int i = 0; i < VinT.Length; i++)
            {
                Console.WriteLine($"Сражение номер - {i + 1}");
                Console.WriteLine("======================================================================================");
                Console.WriteLine();
                Console.Write($"Танк {i + 1}: ");
                TankP[i].PrintTank();
                Console.WriteLine();
                Console.Write($"Танк {i + 1}: ");
                TankT[i].PrintTank();
                Console.WriteLine();
                Console.WriteLine($"В сражение номер - {i + 1}, победил Танк: ");
                if (TankP[i] * TankT[i] == null)
                {
                    Console.WriteLine("Победителя нет!!!");
                }
                else
                {
                    VinT[i] = TankP[i] * TankT[i];
                    VinT[i].PrintTank();
                }
                Console.WriteLine("======================================================================================");
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
