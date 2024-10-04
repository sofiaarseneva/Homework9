using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). 
            //После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.
            Console.WriteLine("Программа \"Калькулятор\"\n");
            try
            {
                Console.WriteLine("Введите первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции: \n\t1 – сложение,\n\t2 – вычитание,\n\t3 – произведение,\n\t4 – частное");
                int k = Convert.ToInt32(Console.ReadLine());
                double result = 0;

                switch (k)
                {
                    case 1:
                        result = a + b;
                        Console.WriteLine("Сумма введенных чисел равна {0}", result);
                        break;
                    case 2:
                        result = a - b;
                        Console.WriteLine("Разность введенных чисел равна {0}", result);
                        break;
                    case 3:
                        result = a * b;
                        Console.WriteLine("Произведение введенных чисел равнo {0}", result);
                        break;
                    case 4:
                        //если идет попытка деления на 0, создаем исключение
                        if (b == 0)
                        {
                            throw new Exception("Попытка деления на 0!");
                        }
                        result = a / b;
                        Console.WriteLine("Частное введенных чисел равнo {0}", result);
                        break;
                    default:
                        Console.WriteLine("Нет операции с указанным номером");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
