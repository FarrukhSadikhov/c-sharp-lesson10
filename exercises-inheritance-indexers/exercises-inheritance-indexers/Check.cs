using System;
using System.Collections.Generic;
using System.Text;

namespace exercises_inheritance_indexers
{
    class Check
    {
       public decimal sum; 

       public virtual decimal Sum
        {
            get
            {
                return sum;
            }
            set
            {
                sum = value;
            }
        }
       public virtual uint Id{ get; set; }

       public DateTime CreatedDate { get; set; }

        public virtual void PrintSum(decimal y)
        {
            sum = y;
            Console.WriteLine(Sum);            
        }
        public virtual void PrintId()
        {
            Console.WriteLine(Id);
        }
        public virtual void PrintDate()
        {
            Console.WriteLine(CreatedDate.ToString());
        }
        public virtual void InterestAccrual(decimal Sum)
        {
            decimal x = Convert.ToDecimal(Console.ReadLine());

            decimal percent = (sum * 0.10M) * x / 12;
            sum = sum + percent;
            Console.WriteLine(sum);
        }
        public uint CheckNumber()
        {
            uint n;
            do
            {
                if (UInt32.TryParse(Console.ReadLine(), out n))
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
    }
    class IndividualAccount : Check
    {
        protected string accounttype = "Депозит";
        public string AccountType
        {
            get { return accounttype; }
        }        
        public  void CashMoney()
        {
            decimal x = Convert.ToDecimal(Console.ReadLine());
             Sum = Sum - x;
            Console.WriteLine(Sum);
        }
        public override void InterestAccrual(decimal Sum)
        {
            base.InterestAccrual(Sum);
        }
    }
    class EntityAccount : Check
    {
        public override void InterestAccrual(decimal Sum)
        {
            decimal z = Convert.ToDecimal(Console.ReadLine());

            decimal percent = (sum * 0.05M) * z / 12;
            sum = sum + percent;
            Console.WriteLine(sum);
        }
        public override void PrintDate()
        {
            base.PrintDate();
        }
        public override void PrintId()
        {
            base.PrintId();
        }
        public override void PrintSum(decimal y)
        {
            base.PrintSum(y);
        }
    }

}
