using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_Rais_Fazylov
{
    internal class Program
    {
        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            // Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,
            // которые нужно поменять местами. Вывести на экран получившийся массив.
            Random random = new Random();
            int[] num = new int[20];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(1, 101);
            }
            Console.WriteLine("массив:");
            PrintArray(num);
            Console.WriteLine("Введите два числа из массива:");
            int fnum = int.Parse(Console.ReadLine());
            int snum = int.Parse(Console.ReadLine());
            int fin = Array.IndexOf(num, fnum);
            int sin = Array.IndexOf(num, snum);
            if (fin != -1 && sin != -1)
            {
                int temp = num[fin];
                num[fin] = num[sin];
                num[sin] = temp;
                Console.WriteLine("Массив после обмена:");
                PrintArray(num);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.WriteLine("Задание 2");
            // Написать метод, где в качества аргумента будет передан массив (ключевое слово
            // params). Вывести сумму элементов массива(вернуть). Вывести(ref) произведение
            // массива.Вывести(out) среднее арифметическое в массиве.
            Console.WriteLine("Задание 3");
            // Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать
            // изображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль
            // должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке. Если
            // пользователь ввёл не цифру, то программа должна выпасть в исключение.Программа
            // завершает работу, если пользователь введёт слово: exit или закрыть(оба варианта
            // должны сработать) -консоль закроется.
            while (true)
            {
                Console.WriteLine("Введите число (или 'exit' для выхода):");
                string i = Console.ReadLine();
                if (i.Equals("exit", StringComparison.OrdinalIgnoreCase) || i.Equals("закрыть", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                try
                {
                    int num1 = int.Parse(i);
                    if (num1 >= 0 && num1 <= 9)
                    {
                        DrawDigit(num1);
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine("Ошибка: Число должно быть от 0 до 9.");
                        System.Threading.Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка");
                }
            }
        }
        static void DrawDigit(int num1)
        {
            string[] a = {
            "####\n#  #\n#  #\n#  #\n####",
            "   #\n   #\n   #\n   #\n   #",
            "####\n   #\n####\n#   \n####",
            "####\n   #\n####\n   #\n####",
            "#  #\n#  #\n####\n   #\n   #",
            "####\n#   \n####\n   #\n####",
            "####\n#   \n####\n#  #\n####",
            "####\n   #\n   #\n   #\n   #",
            "####\n#  #\n####\n#  #\n####",
            "####\n#  #\n####\n   #\n####" 
        };
            Console.WriteLine($"Вы ввели число: {num1}");
            Console.WriteLine(a[num1]);
        }

    }

}

