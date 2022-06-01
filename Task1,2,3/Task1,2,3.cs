using System;

namespace task123
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1

            Console.WriteLine("Введите число");
            int count = int.Parse(Console.ReadLine()); // Получаю число введеное пользователем.
            if (count % 2 == 0) // проверяю четное оно ил нет
            {
                Console.WriteLine("введенное число четное");
            }
            else
            {
                Console.WriteLine("введенное число нечетное");
            }
            #endregion

            #region Задание 2

            Console.WriteLine("Добро пожаловать! Сколько карт у Вас на руках ? \n");
            int numberOfCard = int.Parse(Console.ReadLine()); // input количества карт
            Console.WriteLine("Введите номиналы карт поочередно 2,3,4,5,6,7,8,9,10,J,Q,K,T");
            int sumOfCardDignity = 0; // переменная для подсчета суммы достоинств карт.
            string card; // переменная для инпута номинала карты.

            for (int i = 1; i <= numberOfCard; i++) // Цикл подсчета суммы номиналов 
            {
                if (i == 1)        // if для логичного общения с пользователем.
                {
                    Console.WriteLine("Введите номинал карты");
                    card = Console.ReadLine(); // Записываю номинал введенный пользователем в переменную
                }
                else
                {
                    Console.WriteLine("Введите номинал следующей карты");
                    card = Console.ReadLine();
                }                                                                                         
                    switch (card)  // проверяю введеный номинал и считаю сумму карт.
                    {
                        case "2":
                            sumOfCardDignity = sumOfCardDignity + 2;
                            break;
                        case "3":
                            sumOfCardDignity = sumOfCardDignity + 3;
                            break;
                        case "4":
                            sumOfCardDignity = sumOfCardDignity + 4;
                            break;
                        case "5":
                            sumOfCardDignity = sumOfCardDignity + 5;
                            break;
                        case "6":
                            sumOfCardDignity = sumOfCardDignity + 6;
                            break;
                        case "7":
                            sumOfCardDignity = sumOfCardDignity + 7;
                            break;
                        case "8":
                            sumOfCardDignity = sumOfCardDignity + 8;
                            break;
                        case "9":
                            sumOfCardDignity = sumOfCardDignity + 9;
                            break;
                        case "10":
                            sumOfCardDignity = sumOfCardDignity + 10;
                            break;
                        case "J":
                            sumOfCardDignity = sumOfCardDignity + 10;
                            break;
                        case "Q":
                            sumOfCardDignity = sumOfCardDignity + 10;
                            break;
                        case "K":
                            sumOfCardDignity = sumOfCardDignity + 10;
                            break;
                        case "T":
                            Console.WriteLine("Выберите номинал Туза 1 или 11");
                            int ace = int.Parse(Console.ReadLine()); // инпут значения туза в перменную
                            sumOfCardDignity = sumOfCardDignity + ace;
                            break;
                    }
               
            }
            Console.WriteLine($"Сумма ваших карт = {sumOfCardDignity}");

            #endregion
          
            #region Задание 3

            Console.WriteLine("Введите число для проверки");
            int number = int.Parse(Console.ReadLine()); // input числа для провери
            int j = 2;
            bool search = true;
            if (number != 1) // проверка еденицы
            {
                while (j < number) // алгоритм проверки простого числа
                {
                    if (number % j == 0)
                    {
                        search = false;
                        break;
                    }
                    else
                    {
                        search = true;
                        j++;
                    }
                }
                if (search == true)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число не является простым");
                }
            }
            else
            {
                Console.WriteLine("Число не является ни простым не составным");
            }
            #endregion



















        }
    }
}