using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_1
{
    class ZabiljeskaPro : Zabiljeska
    {
        DateTime vrijemeUnosa = DateTime.Now;

        public ZabiljeskaPro(string autor, string tekst, Helper.Vaznost vaznost)
        {
            this.autor = autor;
            this.tekst = tekst;
            this.vaznost = vaznost;
            this.vrijemeUnosa = DateTime.Now;

        }

        public ZabiljeskaPro(string autor, string tekst, Helper.Vaznost vaznost, DateTime vrijemeUnosa)
        {
            this.autor = autor;
            this.tekst = tekst;
            this.vaznost = vaznost;
            this.vrijemeUnosa = vrijemeUnosa;

        }

        public override string ToString()
        {
            return base.ToString() + "Vrijeme: " + vrijemeUnosa;
        }
    }
}
