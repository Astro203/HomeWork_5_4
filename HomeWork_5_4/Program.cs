using System;

namespace HomeWork_5_4
{
    class Program
    {
        /// <summary>
        /// метод определяющий являются ли числа прогрессией
        /// </summary>
        /// <param name="Args"></param>
        /// <returns></returns>
        static string examinationForProgression(int[] Args)
        {
            string progression = "не является прогрессией";
            if (Args.Length > 1)
            {
                Array.Sort(Args); //сортировка массива
                         
                //проверка на арифметическую прогрессию
                int differense = Args[1] - Args[0];
                int i = 2;
                while ((i < Args.Length) && (Args[i] - Args[i - 1] == differense))
                {
                    i++;
                }
                if (i == Args.Length)
                {
                    progression = "арифметическая прогрессия";
                }

                //проверка на геометрическую прогрессию
                double factor = (double)Args[1]/Args[0];
                i = 2;
                while ((i < Args.Length) && ((double)Args[i]/Args[i - 1] == factor))
                {
                    i++;
                }
                if (i == Args.Length)
                {
                    progression = "геометрическая прогрессия";
                }
            }
            return progression;
        }
        static void Main(string[] args)
        {
            //Задание 4. Написание метода, определяющего, является ли последовательность чисел прогрессией

            Console.Write("Введите количество элементов последовательности: "); int number = int.Parse(Console.ReadLine());

            int[] subsequence = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Введите целое число: "); subsequence[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"Последовательность: {examinationForProgression(subsequence)}");
            Console.WriteLine("Числа могут быть введены не по возрастанию или убыванию, но составлять прогрессию");
        }
    }
}
