using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLearn2_0
{
    class NewEmail
    {
        public string Email { get; private set; }
        public string Schet { get; private set; }
        public double Count { get; private set; }
        public NewEmail(string email){
            Email = email;
        }
        public NewEmail(string email,string schet, double count)
        {
            Schet = schet;
            Email = email+"@gmail.com";
            Count = count;
        }

    }
}
