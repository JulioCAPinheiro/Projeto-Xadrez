using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Posicao
    {
        private int linha;
        private int coluna;
        public int Linha { get => linha; set => linha = value; }
        public int Coluna { get => coluna; set => coluna = value; }

        public Posicao()
        {

        }
        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return linha  +", " + coluna;
        }
    }
}
