using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayisalLoto4
{
   public class Donem
    {
        public int DonemID;
        public string Hafta;
        public string Yil;

        public Donem(int DonemID, string Hafta, String Yil)
        {
            this.DonemID = DonemID;
            this.Hafta = Hafta;
            this.Yil = Yil;
        }
    }
}
