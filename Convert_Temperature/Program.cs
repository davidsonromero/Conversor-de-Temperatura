using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a teperatura");
            double temp = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Selecione uma opção: \n1- Celsius para Fahrenheit \n2- Fahrenheit para Celsius \n3- Celsius para Kelvin \n4- Kelvin para Celsius \n5- Fahrenheit para Kelvin \n6- Kelvin para Fahrenheit");
            int scale = Convert.ToInt32(Console.ReadLine());
            switch (scale) {
                case 1:
                    CtoF(temp);
                    break;
                case 2:
                    FtoC(temp);
                    break;
                case 3:
                    CtoK(temp);
                    break;
                case 4:
                    KtoC(temp);
                    break;
                case 5:
                    FtoK(temp);
                    break;
                case 6:
                    KtoF(temp);
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    Main(args);
                    break;
            }
        }

        public static void CtoF(double temp) {
            double newTemp = (temp * 9 / 5) + 32;
            Console.WriteLine(newTemp);
            Console.ReadKey();
        }

        public static void FtoC(double temp)
        {
            double newTemp = (temp - 32) * 5 / 9;
            Console.WriteLine(newTemp);
            Console.ReadKey();
        }

        public static void CtoK(double temp)
        {
            double newTemp = temp + 273.15;
            Console.WriteLine(newTemp);
            Console.ReadKey();
        }

        public static void KtoC(double temp)
        {
            double newTemp = temp - 273.15;
            Console.WriteLine(newTemp);
            Console.ReadKey();
        }

        public static void FtoK(double temp)
        {
            double newTemp = ((temp - 32) * 5 / 9) + 273.15;
            Console.WriteLine(newTemp);
            Console.ReadKey();
        }

        public static void KtoF(double temp)
        {
            double newTemp = ((temp - 273.15) * 9 / 5) + 32;
            Console.WriteLine(newTemp);
            Console.ReadKey();
        }
    }
}
