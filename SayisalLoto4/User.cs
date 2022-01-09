using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalLoto4
{
    public class User
    {
        public int KisiID;
        public string TC_No;
        public string Ad;
        public string Soyad;
        public User(int KisiID, string TC_No, string Ad, string Soyad)
        {
            this.KisiID = KisiID;
            this.TC_No = TC_No;
            this.Ad = Ad;
            this.Soyad = Soyad;
        }
    }
}
