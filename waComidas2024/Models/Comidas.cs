using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace waComidas2024.Models
{
    public class Comidas
    {
        public int codcom { get; set; }
        public string comcom { get; set; }
        public string diacom { get; set; }
        public string fechcom { get; set; }
        public string autor { get; set; }
        public Comidas() { }
        public Comidas(int codcom, string comcom, string diacom, string fechcom, string autor)
        {
            this.codcom = codcom;
            this.comcom = comcom;
            this.diacom = diacom;
            this.fechcom = fechcom;
            this.autor = autor;
        }
    }
}