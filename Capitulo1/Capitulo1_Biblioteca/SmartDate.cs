using System;
using System.IO;
using System.Linq;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa uma data válida.
    /// </summary>
    public class SmartDate : Date
    {
        /// <summary>
        /// Objeto que representa uma data válida no formato dd/mm/aaaa.
        /// </summary>
        /// <param name="day">Dia.</param>
        /// <param name="month">Mês.</param>
        /// <param name="year">Ano.</param>
        /// <exception cref="InvalidDataException">Quando a data informada não é válida.</exception>
        public SmartDate(int day, int month, int year) : base(day, month, year)
        {
            if (!DataEhValida(day, month, year))
            {
                throw new InvalidDataException("Data informada não é válida.");
            }
        }

        /// <summary>
        /// Objeto que representa uma data no formato dd/mm/aaaa.
        /// </summary>
        /// <param name="date">Data no formato dd/mm/aaaa,</param>
        /// <exception cref="InvalidDataException">Quando a data informada não é válida.</exception>
        public SmartDate(string date) : base(date)
        {
            string[] campos = date.Split(new[] {'/'}, StringSplitOptions.RemoveEmptyEntries);

            int day = Convert.ToInt32(campos[0]);
            int month = Convert.ToInt32(campos[1]);
            int year = Convert.ToInt32(campos[2]);

            if (!DataEhValida(day, month, year))
            {
                throw new InvalidDataException("Data informada não é válida.");
            }
        }

        /// <summary>
        /// Verifica se a data informada é válida.
        /// </summary>
        /// <param name="day">Dia.</param>
        /// <param name="month">Mês.</param>
        /// <param name="year">Ano.</param>
        /// <returns>True caso a data seja seja válida. False caso contrário.</returns>
        private bool DataEhValida(int day, int month, int year)
        {
            return AnoEhValido(year) && MesEhValido(month) && DiaEhValido(day, month, year);
        }

        /// <summary>
        /// Verifica se o ano informado é válido.
        /// </summary>
        /// <param name="year">Ano a ser validado.</param>
        /// <returns>True caso o ano seja válido. False caso contrário.</returns>
        private bool AnoEhValido(int year)
        {
            return year >= 0;
        }

        /// <summary>
        /// Verifica se o mês informado é válido.
        /// </summary>
        /// <param name="month">Mês a ser validado.</param>
        /// <returns>True caso o mês seja válido. False caso contrário.</returns>
        private bool MesEhValido(int month)
        {
            return 1 <= month && month <= 12;
        }

        /// <summary>
        /// Verifica se o dia informado é válido.
        /// </summary>
        /// <param name="day">Dia.</param>
        /// <param name="month">Mês.</param>
        /// <param name="year">Ano.</param>
        /// <returns>True caso o mês seja válido. False caso contrário.</returns>
        private bool DiaEhValido(int day, int month, int year)
        {
            if (MesTem30Dias(month))
            {
                return 1 <= day && day <= 30;
            }

            if (MesTem31Dias(month))
            {
                return 1 <= day && day <= 31;
            }

            if (month == 2 && EhAnoBissexto(year))
            {
                return 1 <= day && day <= 29;
            }

            return month == 2 && 1 <= day && day <= 28;
        }

        /// <summary>
        /// Verifica se o mês informado tem 30 dias.
        /// </summary>
        /// <param name="month">Mês.</param>
        /// <returns>True caso o mês tenha 30 dias. False caso contrário.</returns>
        private bool MesTem30Dias(int month)
        {
            return new int[] {4, 6, 9, 11}.Contains(month);
        }

        /// <summary>
        /// Verifica se o mês informado tem 31 dias.
        /// </summary>
        /// <param name="month">Mês.</param>
        /// <returns>True caso o mês tenha 31 dias. False caso contrário.</returns>
        private bool MesTem31Dias(int month)
        {
            return new int[] {1, 3, 5, 7, 8, 10, 12}.Contains(month);
        }

        /// <summary>
        /// Verifica se o ano informado é bissexto.
        /// </summary>
        /// <param name="year">Ano.</param>
        /// <returns>True caso o ano seja bissexto. False caso contrário.</returns>
        private bool EhAnoBissexto(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) ||
                   (year % 4 == 0 && year % 100 == 0 && year % 400 == 0);
        }
    }
}