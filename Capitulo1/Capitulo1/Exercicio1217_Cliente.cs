using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.17
    /// </summary>
    public class Exercicio1217_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insira o racional A: ");
                RacionalRobusto racionalA = LerRacionalRobusto();
                Console.WriteLine("Insira o racional B: ");
                RacionalRobusto racionalB = LerRacionalRobusto();
                
                Console.WriteLine("A + B = {0}", racionalA.Mais(racionalB));
                Console.WriteLine("A - B = {0}", racionalA.Menos(racionalB));
                Console.WriteLine("A * B = {0}", racionalA.Vezes(racionalB));
                Console.WriteLine("A / B = {0}", racionalA.DivididoPor(racionalB));
                Console.WriteLine("A == B? {0}", racionalA.Equals(racionalB));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private static RacionalRobusto LerRacionalRobusto()
        {
            Console.Write("Digite o numerador: ");
            int numerador = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o denominador: ");
            int denominador = Convert.ToInt32(Console.ReadLine());
            
            return new RacionalRobusto(numerador, denominador);
        }
    }
}