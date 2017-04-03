using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLearn2_0
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            //генерация массива бд
            dread basis = new dread();
            double[] mass = basis.gener();
            //создание запросов
            var MoreFive = from n in mass
                           where n > 5
                           where n < 10
                           orderby n
                           select Math.Sqrt(n);
            
            //обработка запроса
            foreach(var i in MoreFive)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine();

            strDread f = new strDread();
    
            foreach ( strDread n in f.dream)
            {
                Console.WriteLine("{0}, {1}\tHoмep счета: {2}, {3}",
n.LastName, n.FirstName,
n.AccountNumber, n.Balance);
            }
            Console.WriteLine("____________________________");
            var StrZapr = from n in f.dream
                          orderby n.LastName, n.FirstName, n.Balance
                          where n.Balance != 0
                          select n;
            foreach (strDread n in StrZapr)
            {
                Console.WriteLine("{0}, {1}\tHoмep счета: {2}, {3}",
n.LastName, n.FirstName,
n.AccountNumber, n.Balance);
            }


            var EmailAdr = from n in f.dream
                           from z in mass
                           where n.Balance > 0
                           where (z > 1 && z < 6)
                           orderby n.AccountNumber
                           select new NewEmail(n.LastName,n.AccountNumber, z);
            foreach(var nz in EmailAdr)
            {
                Console.WriteLine(nz.Email + "  "+nz.Schet+"  " + nz.Count);
            }



        }
    }
}
