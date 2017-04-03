using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLearn2_0
{
    class strDread
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public double Balance { get; private set; }
        public string AccountNumber { get; private set; }
        public strDread[] dream { get; private set; }

    public strDread(string fn, string ln, string an, double b)
        {
            FirstName = fn;
            LastName = ln;
            Balance = b;
            AccountNumber = an;
        }
        public strDread()
        {
            retstr();
        }
    public void  retstr()
        {
            strDread[] str =
            {
               new strDread("Том", "Смит", "132CK", 100.23),
new strDread("Том", "Смит", "132CD", 10000.00),
new strDread("Ральф", "Джонс", "436CD", 1923.85),
new strDread("Ральф", "Джонс", "454MM", 987.132),
new strDread("Тед", "Краммер", "897CD", 3223.19),
new strDread("Ральф", "Джонс", "434CK", -123.32),
new strDread("Capa", "Смит", "543MM", 5017.40),
new strDread("Capa", "Смит", "547CD", 34955.79),
new strDread("Capa", "Смит", "843CK", 345.00),
new strDread("Альберт", "Смит", "445CK", -213.67),
new strDread("Бетти", "Краммер","968MM",5146.67),
new strDread("Карл", "Смит", "078CD", 15345.99),
new strDread("Дженни", "Джонс", "108CK", 10.98)
};
            dream= str;
        }

            
        }


    
    class dread
    {
       
            public double[] gener()
            {
                double[] mass;
                mass = new double[10];
                Random f = new Random();
                for (int i = 0; i < 10; i++)
                {
                mass[i] = f.Next(5,10)-f.NextDouble();
                }
                foreach (double m in mass)
                {
                    Console.Write(m + "  ");
                }
                Console.WriteLine();


                return mass;
            
        }

    }
}
