using System;

namespace _2._34
{
    class Program
    {
        static void Main(string[] args)
        {

            double znac1, znac2, znac3, znac4, znac5;

            Console.Write("Введите первое значение: ");
            znac1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе значение: ");
            znac2 = double.Parse(Console.ReadLine());
            Console.Write("Введите третье значение: ");
            znac3 = double.Parse(Console.ReadLine());

            if (znac3 > znac2)
            {
                znac4 = znac2 + 10 - znac3;
                znac5 = znac1 - 1;
            }
            else
            {
                znac4 = znac2 - znac3;
                znac5 = znac1;
            }
            Console.WriteLine("Разность равна " + znac5 + znac4);
            Console.ReadKey();
        }
    }
}