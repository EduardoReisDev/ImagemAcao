using System;
using System.Collections.Generic;
using System.Text;
using ImagemAcao.Model;

namespace ImagemAcao.Armazenamento
{
    public class Armazenamento
    {
        public static Jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        public static string[][] Palavras =
        {
            //facil - 0
            new string [] {"Olho", "Lingua", "Chinelo", "Milho", "Penalti", "Bola", "Ping-pong" },

            //Med - 1
            new string [] {"Carteiro", "Amarelo", "Limão", "Abelha" },

            //Dif - 2
            new string [] {"Cisterna", "Lanterna", "Batman vs Superman", "Notebook" },

        };
    }
}
