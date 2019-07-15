using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa uma data.
    /// </summary>
    public class Date : IComparable
    {
        protected int day;
        protected int month;
        protected int year;

        /// <summary>
        /// Dia.
        /// </summary>
        public int Day
        {
            get { return day; }
        }

        /// <summary>
        /// Mês.
        /// </summary>
        public int Month
        {
            get { return month; }
        }

        /// <summary>
        /// Ano.
        /// </summary>
        public int Year
        {
            get { return year; }
        }

        /// <summary>
        /// Objeto que representa uma data no formato dd/mm/aaaa.
        /// </summary>
        /// <param name="day">Dia.</param>
        /// <param name="month">Mês.</param>
        /// <param name="year">Ano.</param>
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        /// <summary>
        /// Objeto que representa uma data no formato dd/mm/aaaa.
        /// </summary>
        /// <param name="date">Data no formato dd/mm/aaaa,</param>
        public Date(string date)
        {
            string[] campos = date.Split(new[] {'/'}, StringSplitOptions.RemoveEmptyEntries);

            day = Convert.ToInt32(campos[0]);
            month = Convert.ToInt32(campos[1]);
            year = Convert.ToInt32(campos[2]);
        }

        /// <summary>
        /// Verifica se duas datas são iguais
        /// </summary>
        /// <param name="obj">Data a ser verificada.</param>
        /// <returns>True se as datas forem iguais. False caso contrário.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Date date2)
            {
                return day == date2.Day && month == date2.Month && year == date2.Year;
            }

            return false;
        }

        /// <summary>
        /// Retorna uma representação da data como string no formato dd/mm/aaaa.
        /// </summary>
        /// <returns>Data no formato dd/mm/aaaa.</returns>
        public override string ToString()
        {
            return String.Format("{0}/{1}/{2}", day, month, year);
        }

        /// <summary>
        /// Retorna um código hash referente a data representada.
        /// </summary>
        /// <returns><Hash da data.</returns>
        public override int GetHashCode()
        {
            string data = day.ToString() + month.ToString() + year.ToString();

            return Convert.ToInt32(data).GetHashCode();
        }

        /// <summary>
        /// Compara a instância atual com outra data informada. Verifica se esta é maior,
        /// menor ou igual.
        /// </summary>
        /// <param name="obj">Data a se comparada.</param>
        /// <returns>1 se a instância atual é maior que a informada, 0 caso sejam iguais e -1
        /// caso esta instância seja menor.
        /// </returns>
        /// <exception cref="ArgumentException">Quando o dado informado não é do tipo Date.</exception>
        public int CompareTo(object obj)
        {
            if (obj is Date date2)
            {
                if (EhMenorQueAtual(date2))
                {
                    return 1;
                }
             
                if (Equals(date2))
                {
                    return 0;
                }
                
                return -1;
            }
            
            throw new ArgumentException("O dado informado deve ser do tipo Date.");
        }

        /// <summary>
        /// Compara a data informada com a instância atual. Verifica se a informada é menor.
        /// </summary>
        /// <param name="date2">Data a ser comparada.</param>
        /// <returns>True caso a data informada seja menor que a instância atual. False caso contrário.</returns>
        private bool EhMenorQueAtual(Date date2)
        {
            return date2.Year < year ||
                   (date2.Year == year && date2.Month < month) ||
                   (date2.Year == year && date2.Month == month && date2.Day < day);
        }
    }
}