# Calculadora
Case para Engenharia de Software JR

Aplicação está com o .net 7.0, favor alterar de acordo com a versão do setup usado.

Itens para corrigir e implemetar no codigo:
  1. Aplicação só está processando o primeiro item da fila infinitamente.
     
       Aplicação não removia da fila após cada processamento, assim, apresentava processamento infinito. Adicionado código que remove operação da fila.
  2. Implementado a funcionalidade de divisão.
  3. Aplicação não está calculando a penultima operação corretamente.

       Operação estava incorreta, pois tipo definido para os campos era int, o valor 2147483647 é o valor máximo que um inteiro de 32 bits (tipo int em C#) pode armazenar
     
     	Saída esperada no console:
     
     		14 - 8 = 6
     
     		5 * 6 = 30
     
     		2147483647 + 2 = 2147483649
     
     		18 / 3 = 6

  4. Implemente uma funcionalidade para imprimir toda a lista de operaçõoes a ser processada após cada calculo realizado.

       Função implementada
     
       Saída:
     
            2 + 3 = 5
     
            Operações a serem processadas:
            14 - 8
            5 * 6
            2147483647 + 2
            18 / 3
     
  5. Crie uma nova pilha (Stack) para guardar o resultado de cada calculo efetuado e imprima a pilha ao final

        Função implementada
     
       Saída:
     
           Resultados dos cálculos:
     
             2 + 3 = 5
             14 - 8 = 6
             5 * 6 = 30
             2147483647 + 2 = 2147483649
             18 / 3 = 6


Obs2: Aplicação também realizada em python - https://github.com/HenriqueNC2207/Calculadora.py
