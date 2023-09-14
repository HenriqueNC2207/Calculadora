using System;
using System.Collections;
using System.Collections.Generic;


namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            //Stack para guardar resultado das operações
            Stack<string> stack = new Stack<string>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();

            //Removido o operador = da validação abaixo, que ocasionava exceção InvalidOperationException na linha 27, pois a fila já estava vazia.
            while (filaOperacoes.Count > 0)
            {
                Operacoes operacao = filaOperacoes.Peek();
                calculadora.calcular(operacao);

                //Remove da fila operação já processada
                filaOperacoes.Dequeue();

                //Armazena string da expressão e seu resultado
                string resultado = string.Format("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);
                Console.WriteLine();
                Console.WriteLine(resultado);
                Console.WriteLine();
                //Adiciona ao stack o resultado da operação processada
                stack.Push(resultado);

                //Imprime as operações a serem processadas após cada processamento
                if(filaOperacoes.Count > 0) {
                        Console.WriteLine("Operações a serem processadas:");
                        foreach(Operacoes listaFila in filaOperacoes){
                            Console.WriteLine("{0} {1} {2}", listaFila.valorA, listaFila.operador, listaFila.valorB);
                        }
                }
                //Organiza e imprime pilha de resultados após a realização da fila
                else{
                    Console.WriteLine("Resultados dos cálculos:");
                    string[] arrayFromStack = stack.ToArray();
                    //Organiza a pilha na ordem dos processamentos
                    Array.Reverse(arrayFromStack);
                    foreach(string result in arrayFromStack){
                        Console.WriteLine(result);
                    }
                }
                
            }

          
           
        }
    }
}
