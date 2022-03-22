using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuintas
{
    class Status
    {
        public float forca { get; set; }
        public float defesa { get; set; }
        public float agilidade { get; set; }
        public float sorte { get; set; }
        public float vida { get; set; }
        public float mana { get; set; }

        public Status(float forca, float defesa, float agilidade, float sorte, float vida, float mana)
        {
            this.forca = forca;
            this.defesa = defesa;
            this.agilidade = agilidade;
            this.sorte = sorte;
            this.vida = vida;
            this.mana = mana;
        }

    }
}
