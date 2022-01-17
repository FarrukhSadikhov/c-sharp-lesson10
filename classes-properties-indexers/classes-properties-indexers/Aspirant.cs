using System;
using System.Collections.Generic;
using System.Text;

namespace classes_properties_indexers
{
    class Aspirant : Student
    {
        public override Student[] Insert()
        {
            Array.Resize(ref data, data.Length + 1);
            for (int i = data.Length - 1; i < data.Length; i++)
            {
                Console.WriteLine($"Введите даннык {i + 1 } аспирвнта");
                data[i] = new Student();
                Console.Write($"Введите фамилию:  ");
                data[i].Surname = CheckString();
                Console.Write($"Введите номер курса: ");
                data[i].Course = CheckNumber();
                Console.Write($"Введите номер зачетной книги: ");
                data[i].GradeBook = CheckNumber();
                Console.Write($"Введите предмет защиты кандидатской диссертации:  ");
                data[i].Subject = CheckString();
            }
            return data;
        }
        public override Student[] RemoveAt()
        {
            base.RemoveAt();
            return data;      
        }
        public override void Print()
        {
            if (data.Length != 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine($"Данные {i + 1} аспирант");
                    Console.WriteLine($"Фамилия = {data[i].Surname} Курс обучения = {data[i].Course} Номер зачетной книги = {data[i].GradeBook} Предмет защиты кандидатской диссертации = {data[i].Subject} ");
                }
            }
            else
            {
                Console.WriteLine("\nСписок аспирант пуст.\n");
            }
        }
        public override void PrintIndex()
        {
            base.PrintIndex();
        }    
    }
}
