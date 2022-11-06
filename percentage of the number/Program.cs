using System;
/*
Пользователь вводит с клавиатуры два числа. Первое
число — это значение, второе число процент, который
необходимо посчитать. Например, мы ввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.
*/

namespace percentage_of_the_number
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: ");
            float num1 = Convert.ToSingle(Console.ReadLine());
            float num2 = Convert.ToSingle(Console.ReadLine());
            float percent = num1 / 100 * num2;
            Console.WriteLine(percent);
            Console.ReadKey();
        }
    }
}
