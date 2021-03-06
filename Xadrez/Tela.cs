﻿using System;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    public class Tela
    {


        public Tela()
        {
        }

        public static void imprimirTabuleiro(Taboleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i +" ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("-");

                    }
                Console.Write(tab.peca(i, j) + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write(peca);

            }
            else
            {

                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }


        }
    }
}
