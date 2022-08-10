﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Jogo
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QteMovimentos = 0;
            Tab = tab;
        }

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}