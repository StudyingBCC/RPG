using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuintas
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro capitaoAmerica = new Guerreiro("Capitao America", 33, 99, new Status(0, 10, 10, 10, 100, 10));
            Aranha homemAranha = new Aranha(10, "Homem Aranha", new Status(10, 10, 10, 10, 100, 10));

            Espada esacalibur = new Espada(new Status(100, 0, -10, 20, 0, 0));
            Escudo sctum = new Escudo(new Status(50, 100, 10, 30, 0, 0));

            capitaoAmerica.PegarArmaNaMaoEsquerda(esacalibur);
            capitaoAmerica.PegarEscudoNaMaoDireita(sctum);

            Console.WriteLine("SPIDERMAN: VIDA (" + homemAranha.status.vida + ")");
            capitaoAmerica.Atacar(homemAranha);
            Console.WriteLine("SPIDERMAN: VIDA (" + homemAranha.status.vida + ")");


            Mago doutorEstranho = new Mago("Doutor Estranho", 33, 99, new Status(0, 10, 10, 10, 100, 10));
            Goblin thanos = new Goblin(10, "Thanos", new Status(10, 10, 10, 10, 100, 10));

            Adaga madeira= new Adaga(new Status(100, 0, -10, 20, 0, 0));
            Escudo broquel = new Escudo(new Status(50, 100, 10, 30, 0, 0));

            doutorEstranho.PegarArmaNaMaoEsquerda(madeira);
            doutorEstranho.PegarEscudoNaMaoDireita(broquel);

            Console.WriteLine("Thanos: VIDA (" + thanos.status.vida + ")");
            doutorEstranho.Atacar(thanos);
            Console.WriteLine("Thanos: VIDA (" + thanos.status.vida + ")");
        }
    }
}
