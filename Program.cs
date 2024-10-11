using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int db = 5;
                Random random = new Random();
                int[] tomb = new int[db];// 5db számot add

                for (int i = 0; i < db; i++)
                {
                    tomb[i] = random.Next(1, 101);//1-től 100-ig választ számokat
                }

                Console.WriteLine("A tömb számai: ");
                foreach (int szam in tomb)
                {
                    Console.Write(szam + " ");
                }
                Console.WriteLine();

                int legkisebb = tomb[0];
                int legnagyobb = tomb[0];

                for (int i = 1; i < tomb.Length; i++)// legnagyobb-legkisebb keresése
                {
                    if (tomb[i] < legkisebb)
                    {
                        legkisebb = tomb[i];
                    }
                    if (tomb[i] > legnagyobb)
                    {
                        legnagyobb = tomb[i];
                    }
                }

                Console.WriteLine("A legkisebb elem: " + legkisebb);
                Console.WriteLine("A legnagyobb elem: " + legnagyobb);
            }
        }

    }