using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD_CLASSES_04._12
{
    public class Produto
    {
        public string Nome{get;set;}
        public double Preço{get;set;}
        public int Quantidade{get;set;}

        public double ValorTotal()
        {
            return Preço* Quantidade;
        }

        public string ExibirProdutos()
        {
            return $"Nome: {Nome}; Preço: {Preço.ToString("F2")} Quantidade: {Quantidade}";
        }

       
    }
}