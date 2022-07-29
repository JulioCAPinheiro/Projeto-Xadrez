using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Peca
    {
        private Posicao posicao;
        private Cor cor;
        private int qteMovimentos;
        private Tabuleiro tab;

        internal Posicao Posicao { get => posicao; set => posicao = value; }
        protected Cor Cor { get => cor; set => cor = value; }
        public int QteMovimentos { get => qteMovimentos; set => qteMovimentos = value; }
        protected Tabuleiro Tab { get => tab; set => tab = value; }

        public Peca()
        {

        }
        public Peca(Posicao posicao,Tabuleiro tab, Cor cor)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            qteMovimentos = QteMovimentos = 0;
        }
    }
}
