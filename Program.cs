
using System;
using tabuleiro;
using xadrez;

namespace JogoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {

                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem: ");
                    Posicao oringem = Tela.LerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino  = Tela.LerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(oringem, destino);
                }
                Tela.imprimirTabuleiro(partida.tab);

            }
            catch (Exception ex) {
            
                Console.WriteLine(ex.ToString());
            
            }
            Console.ReadLine();

        }
    }

}
