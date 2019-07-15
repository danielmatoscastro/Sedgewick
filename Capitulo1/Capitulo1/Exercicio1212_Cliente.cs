using System;
using Capitulo1_Biblioteca;

namespace Capitulo1_Cliente
{
    /// <summary>
    /// Cliente para o exercício 1.2.12.
    /// </summary>
    public class Exercicio1212_Cliente
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o dia: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o mês: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o ano: ");
                int year = Convert.ToInt32(Console.ReadLine());
                
                SmartDate smartDate = new SmartDate(day, month, year);
                
                Console.WriteLine("Data: {0}", smartDate);
                Console.WriteLine("Dia da semana: {0}", smartDate.DayOfTheWeek());
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
    }
}