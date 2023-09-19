namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

            

            Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы");
            Console.WriteLine("Здравствуйте вас приветствует умный калькулятор ,выберите операцию ,которую хотите использовать:");

            int a = Convert.ToInt32(Console.ReadLine());


                switch (a)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите первое число");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            int c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Сумма чисел равна:");
                            Console.WriteLine(b + c);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Введите первое число");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            int c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Вычетание чисел :");
                            Console.WriteLine(c - b);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Введите первое число");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            int c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Умножение чисел :");
                            Console.WriteLine(b * c);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Введите первое число");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            int c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Деление первое на второе :");
                            if (b == 0 || c == 0)
                            {
                                Console.WriteLine("Деление на 0 нельзя!Введите другое число");
                            }
                            else
                            {

                                Console.WriteLine(b / c);
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Введите первое число");
                            int b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите в степень ,которую хотите возвести");
                            int c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Возведение в степень : {Math.Pow(b, c)}");


                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Введите первое число");
                            int b = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Квадратный корень:");
                            Console.WriteLine(Math.Sqrt(b));

                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Введите первое число");
                            int b = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("1% от числа равен");
                            Console.WriteLine(b * 0.01);
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("Введите первое число");
                            int b = Convert.ToInt32(Console.ReadLine());

                            int c = 1;
                            for (int i = 1; i <= b; i++)
                            {
                                c = c * i;
                            }
                            Console.WriteLine("Результат:" + " " + c);
                        }
                        break;
                    case 9:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
                        Console.WriteLine("Не хотите ли вы продолжить?   y/n  ");
                        string y = Console.ReadLine();
                        if (y.ToLower() == "y")
                {
                    Console.Clear();
                    continue;
                }
                        else if (y.ToLower() == "n")
                            Environment.Exit(0);
                        else
                        {
                            Console.WriteLine("Ошибка,попробуйте еще раз.");
                            Environment.Exit(0);
                        }
                } while (true) ;


            }
            }
        }
