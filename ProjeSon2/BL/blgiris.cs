using ProjeSon2.DAL;
using ProjeSon2.ENTİTYLAYER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon2.BL
{
    internal class blgiris
    {
        internal void girisbilgi (string girisKullanici, string girisSifre)
        {
            (new dalgiris()).elgiris(new elgiris(girisKullanici, girisSifre));
        }
    }
}
