using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuintas
{
    class Heroi
    {
        public string nome { get; private set; }
        public int idade { get; private set; }
        public int level { get; private set; }
        public Status status { get; private set; }
        public Escudo maoDireita { get; private set; }
        public Armas maoEsquerda { get; private set; }

        public Heroi(string nome, int idade, int level, Status status)
        {
            this.nome = nome;
            this.idade = idade;
            this.level = level;
            this.status = status; 
        }

        public void PegarArmaNaMaoEsquerda(Armas arma)
        {

            if (this.maoEsquerda != null)
            {
                this.status.forca -= this.maoEsquerda.status.forca;
                this.status.agilidade -= this.maoEsquerda.status.agilidade;
                this.status.sorte -= this.maoEsquerda.status.sorte;
            }

            this.maoEsquerda = arma;
            this.status.forca += arma.status.forca;
            this.status.agilidade += arma.status.agilidade;
            this.status.sorte += arma.status.sorte;
        }

        public void PegarEscudoNaMaoDireita(Escudo escudo)
        {

            if (this.maoDireita != null)
            {
                this.status.forca -= this.maoDireita.status.forca;
                this.status.agilidade -= this.maoDireita.status.agilidade;
                this.status.sorte -= this.maoDireita.status.sorte;
            }

            this.maoDireita = escudo;
            this.status.defesa += escudo.status.defesa;
            this.status.agilidade += escudo.status.agilidade;
            this.status.sorte += escudo.status.sorte;
        }

        public void Atacar(Monstro monstro)
        {
            Random random = new Random();
            float numRandom = (float)random.Next((int)this.status.sorte);
            float valorDoAtaque = this.status.forca + this.status.agilidade * (1 + numRandom / 100);

            monstro.receberAtaque(valorDoAtaque);

        }
    }
}
