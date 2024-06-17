using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{
    public class Spells
    {
        public string Magia { get; set; }
        public string Tipo { get; set; }
        public int Dano { get; set; }

        public Spells(string magia, string tipo, int dano)
        {
            Magia = magia;
            Tipo = tipo;
            Dano = dano;
        }
    }
}