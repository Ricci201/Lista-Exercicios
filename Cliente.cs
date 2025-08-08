using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios
{
    public class Cliente
    {
        private string v;

        public string? Nome { get; set; }

        public Cliente(string v)
        {
            this.v = v;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}";
        }
    }
}
