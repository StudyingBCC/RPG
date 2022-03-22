using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuintas
{
    class Mago : Heroi
    {
        public Mago(string nome, int idade, int level, Status status) : base(nome, idade, level, status)
        {

        }

        public void CuraDoMago(Heroi heroi) 
        {
            if (this.status.mana <= 10)
            {
                Console.WriteLine("Sem Mana!");
                return;
            }
            Random random = new Random();
            float randomNum = (float)random.Next(1, (int)this.status.sorte); 
            double div = (1 + randomNum / 100.0);
            int vidaQnt = ((int)div);
            heroi.status.vida += heroi.status.vida * vidaQnt; 
            this.status.mana -= 10;
            Console.WriteLine("Houve uma cura de {0}", vidaQnt);
            Console.WriteLine("Ainda há {0} de mana", this.status.mana);
        }
    }
}
