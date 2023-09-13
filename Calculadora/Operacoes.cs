using System;
namespace Calculadora
{
    public class Operacoes
    {
        //Alterado int para long, erro na operação 2147483647 + 2 necessita de tipo long
        public long valorA {get;set;}
        public char operador { get; set; }
        public long valorB { get; set; }
        public decimal resultado { get; set; }

    }
}
