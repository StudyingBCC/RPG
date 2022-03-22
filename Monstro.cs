using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuintas
{
    class Monstro
    {
        public int level { get; private set; }
        public string nome { get; private set; }
        public Status status { get; private set; }

        public Monstro(int level, string nome, Status status)
        {
            this.level = level;
            this.nome = nome;
            this.status = status;
        }

        public float Defesa()
        {
            Random random = new Random();
            float numRandom = (float)random.Next((int)this.status.sorte);
            float valorDoDefesa = (this.status.defesa + this.status.agilidade) * (1 + numRandom / 100);

            return valorDoDefesa;
        }

        public virtual void receberAtaque(float valorDoAtaque)
        {
            float totalDePontos = this.Defesa() - valorDoAtaque;

            if (totalDePontos < 0)
            {
                this.status.vida += totalDePontos;
            }
            else
            {
                Console.WriteLine("O monstro defendeu o ataque!");
            }

        }
    }
}
