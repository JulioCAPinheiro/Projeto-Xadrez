using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        private int linhas;
        private int colunas;
        private Peca[,] pecas;

        public int Linha { get => linhas; set => linhas = value; }
        public int Colunas { get => colunas; set => colunas = value; }
        internal Peca[,] Pecas { get => pecas; set => pecas = value; }

        public Tabuleiro()
        {

        }

        public Tabuleiro(int linhas, int colunas)
        {
            Linha = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
    }
}
