using System;
namespace Calculadora
{
    public class Operacoes
    {
        //Alterado int para decimal, erro na operação 2147483647 + 2 é causado pelo tipo int. Tipo decimal é mais coerente para a calculadora, correspondendo também ao tipo já definido ao resultado.
        public decimal valorA {get;set;}
        public char operador { get; set; }
        public decimal valorB { get; set; }
        public decimal resultado { get; set; }

    }
}
