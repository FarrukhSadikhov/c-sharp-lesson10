using System;

namespace exercises_inheritance_indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualAccount account = new IndividualAccount();
            EntityAccount entity = new EntityAccount();
            bool finish = true;
            do
            {
                Console.WriteLine("выберите действия");
                Console.WriteLine("1 Счет физического лица");
                Console.WriteLine("2 Счет юридического лица");
                Console.WriteLine("");
                string number = Console.ReadLine();
                try
                {
                    switch (number)
                    {
                        case "1":
                            Console.WriteLine("Поздравляем вы открыли счёт физического лица");                           
                            Console.WriteLine("Дата открытия счета:");
                            account.CreatedDate = DateTime.Now;
                            account.PrintDate();
                            Console.WriteLine($"Вид счета -{account.AccountType}");
                            Console.WriteLine("Введите ваш номер счета:");
                            account.Id = Convert.ToUInt32(Console.ReadLine());
                            Console.WriteLine("Данный момент счет пуст" );     
                            Console.WriteLine("Какую сумму хотите добавить: ");
                            decimal y = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Баланс:");
                            account.PrintSum(y);
                            Console.WriteLine("Начисление годовых процентов состовляет 10%");                           
                            Console.WriteLine("Чтобы узнать сколько начислится процeнт за период в месяцах нажмите: 1\nснять деньги нажмите: 2");
                            number = Console.ReadLine();
                            do
                            {
                                if (number == "1")
                                {
                                    Console.Write("введите число месяцев:");
                                    account.InterestAccrual(y);

                                    break;
                                }
                                if (number == "2")
                                {
                                    Console.WriteLine("Какую сумму хотите снять: ");
                                     account.CashMoney();
                                   
                                    break;
                                }
                                else { Console.WriteLine("Ошибка!!!Введите 1 или 2"); }
                                break;
                            } while (true);                           
                           break;
                        case "2":
                            Console.WriteLine("Поздравляем вы открыли счёт юридического лица");
                            Console.WriteLine("Дата открытия счета:");
                            entity.CreatedDate = DateTime.Now;
                            entity.PrintDate();
                            Console.WriteLine("Введите ваш номер счета:");
                            entity.Id = Convert.ToUInt32(Console.ReadLine());
                            Console.WriteLine("Данный момент счет пуст");
                            Console.WriteLine("Какую сумму хотите добавить: ");
                            decimal x = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Баланс:");
                            entity.PrintSum(x);
                            Console.WriteLine("Начисление годовых процентов состовляет 5%");
                            Console.WriteLine("Чтобы узнать сколько начислится процeнт за период в месяцах нажмите: 1");
                            number = Console.ReadLine();                            
                            do{
                                if (number == "1")
                                {                                   
                                    Console.Write("введите число месяцев:");
                                    entity.InterestAccrual(x);
                                    break;
                                }                              
                                else { Console.WriteLine("Ошибка!!!Введите 1 или 2"); }
                                break;
                            } while (true);
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка!!!Введите одно из выше указанных действий");
                }
            }
            while (finish == true);
        }
    }
}
