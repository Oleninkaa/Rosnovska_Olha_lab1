using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть послідовність цілих чисел ↓");
            string[] input = Console.ReadLine().Split(' ');
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            Count s = new Count(array);

            Console.WriteLine("\n" + "Належність елемента:");
            Console.WriteLine(s.Is_in(9) + "\n");//належність елемента


            Console.WriteLine("Дана послідовність рівна {5, 6, 7, 8, 9}:");
            int[] list = new int[] { 5, 6, 7, 8, 9 };
            Console.WriteLine(s.Is_equal(list));//чи рівні послідовності

            Console.WriteLine("\n" + "Максимум:");
            Console.WriteLine(s.Max());

            Console.WriteLine("\n" + "Мінімум:");
            Console.WriteLine(s.Min());


            s.My_Type();
            Console.WriteLine("\n" + "Локальнi максимуми: ");
            for (int i = 0; i < s.loc_max().Length; i++) { Console.WriteLine(s.loc_max()[i] + " "); }

            Console.WriteLine("\n" + "Локальнi мiнiмуми: ");
            for (int i = 0; i < s.loc_min().Length; i++) { Console.WriteLine(s.loc_min()[i] + " "); }

            Console.WriteLine("\n" + "Екстремуми: ");
            for (int i = 0; i < s.extremes().Length; i++) { Console.WriteLine(s.extremes()[i] + " "); }

            Console.WriteLine("\n" + "Найбiльша пiдпослiдовнiсть: ");
            for (int i = 0; i < s.max_subsequence().Length; i++) { Console.WriteLine(s.max_subsequence()[i] + " "); }

            Console.WriteLine("\n" + "Найменша пiдпослiдовнiсть: ");
            for (int i = 0; i < s.min_subsequence().Length; i++) { Console.WriteLine(s.min_subsequence()[i] + " "); }

            s.ToJson("new.json");
            var json_array = Count.FromJson("test.json");
            Console.WriteLine("\n" + "Масив з json-файлу: ");
            for (int i = 0; i < json_array.array.Length; i++) { Console.Write(json_array.array[i] + " "); }
        }
    }
}
