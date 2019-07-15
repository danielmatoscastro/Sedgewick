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

        /// <summary>
        /// Retorna uma string dizendo o dia da semana representado (em inglês).
        /// Supõe que a data é maior ou igual que 01/01/2001.
        /// </summary>
        /// <returns>Dia da semana.</returns>
        public string DayOfTheWeek()
        {
            string[] diasDaSemana = new string[]
                {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

            int totalDias = DiasDesde01012001();

            return diasDaSemana[totalDias % 7];

        }

        /// <summary>
        /// Calcula o número de dias desde 01/01/2001.
        /// </summary>
        /// <returns>Dias desde 01/01/2001.</returns>
        private int DiasDesde01012001()
        {
            int totalDias = 0;

            for (int ano = 2001; ano < year; ano++)
            {
                if (EhAnoBissexto(ano))
                {
                    totalDias += 366;
                }
                else
                {
                    totalDias += 365;
                }
            }

            for (int mes = 1; mes < month; mes++)
            {
                if (MesTem30Dias(mes))
                {
                    totalDias += 30;
                }else if (MesTem31Dias(mes))
                {
                    totalDias += 31;
                }else if (EhAnoBissexto(year))
                {
                    totalDias += 29;
                }
                else
                {
                    totalDias += 28;
                }
            }

            totalDias += day;

            return totalDias;
        }
        
    }
}