using System;
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
                case '/': operacao.resultado = divisao(operacao);break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public decimal soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        public decimal subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public decimal multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        //Adicionado função de divisão
        public decimal divisao(Operacoes operacao)
        {
            if(operacao.valorB == 0){
                Console.WriteLine("Divisão por zero não é permitida");
                Environment.Exit(1);
            }
            return operacao.valorA / operacao.valorB;
        }
       
    }
}
