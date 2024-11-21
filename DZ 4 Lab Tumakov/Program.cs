using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_Lab_Tumakov
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 5.1");
            // Написать метод, возвращающий наибольшее из двух чисел. Входные
            // параметры метода – два целых числа.Протестировать метод.
            Console.WriteLine("Введите первое число:");
            int num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());
            int num = GetMax(num1, num2);
            Console.WriteLine($"Наибольшее число: {num}");
            Console.WriteLine("Упражнение 5.2");
            // Написать метод, который меняет местами значения двух передаваемых
            // параметров.Параметры передавать по ссылке. Протестировать метод.
            int a1 = 66;
            int a2 = 77;
            Console.WriteLine($"Перед обменом: a1 = {a1}, a2 = {a2}");
            Swap(ref a1, ref a2);
            Console.WriteLine($"После обмена: a1 = {a1}, a2 = {a2}");
            Console.WriteLine("Упражнение 5.3");
            // Написать метод вычисления факториала числа, результат вычислений
            // передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;
            // если в процессе вычисления возникло переполнение, то вернуть значение false.Для
            // отслеживания переполнения значения использовать блок checked.
            Console.WriteLine("Упражнение 5.4");
            // Написать рекурсивный метод вычисления факториала числа.
        }
    }
}
