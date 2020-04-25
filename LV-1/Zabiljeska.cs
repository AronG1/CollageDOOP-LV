using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_1
{
    class Zabiljeska : IComparable
    {
        public string tekst { get; set;  }

        public string autor { get; protected set; }

        public Helper.Vaznost vaznost { get; protected set; }

        private string GetTekst()
        {
            return this.tekst;
        }

        public void SetTekst(string value)
        {
            tekst = value;
        }

        public Zabiljeska(string autor, string tekst, Helper.Vaznost vaznost)
        {
            this.autor = autor;
            this.tekst = tekst;
            this.vaznost = vaznost;
        }

        public Zabiljeska(string autor, string tekst)
        {
            this.autor = autor;
            this.tekst = tekst;
            this.vaznost = Helper.Vaznost.Nevazno;
        }

        public Zabiljeska(string autor)
        {
            this.autor = autor;
            this.tekst = "Nema teksta";
            this.vaznost = Helper.Vaznost.Nevazno;
        }

        public Zabiljeska()
        {
            this.autor = "Javnost/Glasine";
            this.tekst = "Nema teksta";
            this.vaznost = Helper.Vaznost.Nevazno;
        }

        public override string ToString()
        {
            return "Custom Autor: " + this.autor + ", Tekst: " + this.tekst;
        }

        public int CompareTo(Zabiljeska zabiljeska)
        {
            if (zabiljeska == null) return -1;
            return (this.autor == zabiljeska.autor && this.tekst == zabiljeska.tekst && this.vaznost == zabiljeska.vaznost) ? 1 : 0;
        }

        public int CompareTo(object obj)
        {
            if(obj is Zabiljeska && obj != null)
            {
                Zabiljeska z = (Zabiljeska)obj;
                return (this.autor == z.autor && this.tekst == z.tekst && this.vaznost == z.vaznost) ? 1 : 0;
            }
            return -1;
        }
    }
}
