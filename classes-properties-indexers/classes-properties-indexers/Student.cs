using System;

namespace classes_properties_indexers
{
    class Student
    {
        public static int counter = 0;
        public Student() { data = new Student[counter]; }
        public string Surname { get; set; }
        public int Course { get; set; }

        public int GradeBook { get; set; }

        public string Subject { get; set; }

        public Student(string Surname, int Course, int GradeBook,string Subject)
        {
            this.Surname = Surname;
            this.Course = Course;
            this.GradeBook = GradeBook;
            this.Subject = Subject;
        }
        public int CheckNumber()
        {
            int n;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    return n;
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите корректные данные");
                }
            }
            while (true);
        }
        public string CheckString()
        {
            string name;
            uint countofInvalid = 0;
            string symbolInvalid = "1234567890/} {)(|@%$&*!?,.`~=-#";
            string enter = "";
            do
            {
                countofInvalid = 0;
                name = Console.ReadLine();
                if (name == enter)
                {
                    countofInvalid++;
                }
                foreach (char numb1 in name)
                {
                    foreach (char numb2 in symbolInvalid)
                        if (numb1 == numb2)
                        {
                            countofInvalid++;
                        }
                }
                if (countofInvalid > 0)
                {
                    Console.WriteLine("Имя введенно не корректно,ведите имя повторно");
                }
            }
            while (countofInvalid > 0);
            return name;
        }

        public Student[] data;

        public Student this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public virtual void Print()
        {
            if (data.Length != 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine($"Данные {i + 1} студента");
                    Console.WriteLine($"Фамилия = {data[i].Surname} Курс обучения = {data[i].Course} Номер зачетной книги = {data[i].GradeBook}");
                }
            }
            else
            {
                Console.WriteLine("\nСписок студентов пуст.\n");
            }
        }
        public virtual void PrintIndex()
        {
            Console.WriteLine("Введите индекс ");
            int i = CheckNumber();
            Console.WriteLine($"Фамилия = {data[i - 1].Surname} Course = {data[i - 1].Course} GradeBook = {data[i - 1].GradeBook}");
        }
        public virtual Student[] Insert()
        {
            Array.Resize(ref data, data.Length + 1);
            for (int i = data.Length - 1; i < data.Length; i++)
            {
                Console.WriteLine($"Введите даннык {i + 1 } студента");
                data[i] = new Student();
                Console.Write($"Введите фамилию студента:  ");
                data[i].Surname = CheckString();               
                Console.Write($"Введите номер курса: ");
                data[i].Course = CheckNumber();
                Console.Write($"Введите номер зачетной книги: ");
                data[i].GradeBook = CheckNumber();              
            }
            return data;
        }
        public virtual Student[] RemoveAt()
        {
            Console.WriteLine("Введите индекс:");
            int x = CheckNumber();
            data[x - 1] = null;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == null)
                {
                    data[i] = data[data.Length - 1];
                }
                Console.WriteLine("Студент удалён!");
            }
            Array.Resize(ref data, data.Length - 1);
            return data;
        }
    }
}
















