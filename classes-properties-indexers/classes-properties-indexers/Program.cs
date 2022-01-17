﻿using System;

namespace classes_properties_indexers
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Aspirant aspirant = new Aspirant();
            bool finish = true;
            do
            {
                Console.WriteLine("выберите действия");
                Console.WriteLine("1 Добавить");
                Console.WriteLine("2 Удаление");
                Console.WriteLine("3 Количество");
                Console.WriteLine("4 Cписок");
                Console.WriteLine("5 Даннык (студента) или (аспиранта) по порядковому индексу");
                Console.WriteLine("6 Выход из приложения");
                Console.WriteLine("Выберите одно из выше указанных действий: ");
                string number = Console.ReadLine();
                try
                {
                    switch (number)
                    {
                        case "1":
                            Console.WriteLine("студента нажмите: 1\nаспирант нажмите: 2");
                            number = Console.ReadLine();
                            do
                            {
                                if (number == "1")
                                {
                                    student.Insert();
                                    break;
                                }
                                if (number == "2")
                                {
                                    aspirant.Insert();
                                    break;
                                }
                                else { Console.WriteLine("Ошибка!!!Введите 1 или 2"); }
                                break;
                            } while (true);                        
                            break;
                        case "2":
                            Console.WriteLine("студента нажмите: 1\nаспирант нажмите: 2");
                            number = Console.ReadLine();
                            do
                            {
                                if (number == "1")
                                {
                                    student.RemoveAt();
                                    break;
                                }
                                if (number == "2")
                                {
                                    student.RemoveAt();
                                    break;
                                }
                                else { Console.WriteLine("Ошибка!!!Введите 1 или 2"); }
                                break;
                            } while (true);
                             break;
                        case "3":
                            Console.WriteLine("студента нажмите: 1\nаспирант нажмите: 2");
                            number = Console.ReadLine();
                            do
                            {
                                if (number == "1")
                                {
                                    Console.WriteLine($"\nКоличество студентов {student.data.Length}\n");
                                    break;
                                }
                                if (number == "2")
                                {
                                    Console.WriteLine($"\nКоличество студентов {student.data.Length}\n");
                                    break;
                                }
                                else { Console.WriteLine("Ошибка!!!Введите 1 или 2"); }
                                break;
                            } while (true);                          
                            break;
                        case "4":
                            Console.WriteLine("студента нажмите: 1\nаспирант нажмите: 2");
                            number = Console.ReadLine();
                            do
                            {
                                if (number == "1")
                                {
                                    student.Print();
                                    break;
                                }
                                if (number == "2")
                                {
                                    aspirant.Print();

                                    break;
                                }
                                else { Console.WriteLine("Ошибка!!!Введите 1 или 2"); }
                                break;
                            } while (true);                          
                            break;
                        case "5":
                            Console.WriteLine("студента нажмите: 1\nаспирант нажмите: 2");
                            number = Console.ReadLine();
                            do
                            {
                                if (number == "1")
                                {
                                    student.PrintIndex();
                                    break;
                                }
                                if (number == "2")
                                {
                                    aspirant.PrintIndex();
                                    break;
                                }
                                else { Console.WriteLine("Ошибка!!!Введите 1 или 2"); }
                                break;
                            } while (true);
                            
                            
                            break;
                        case "6":
                            Console.WriteLine("Выход из приложения");
                            finish = false;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка!!!Введите одно из выше указанных действий");
                }
            }
            while (finish == true);
            Console.ReadKey();




        }
    }
} 

  
