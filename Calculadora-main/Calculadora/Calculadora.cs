﻿using System;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public long soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public long subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public long multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
       
    }
}
