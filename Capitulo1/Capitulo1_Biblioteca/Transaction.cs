using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa uma transação.
    /// </summary>
    public class Transaction : IComparable
    {
        private string who;
        private Date when;
        private double amount;

        /// <summary>
        /// O dono da transação.
        /// </summary>
        public string Who
        {
            get { return who; }
        }

        /// <summary>
        /// Data da transação.
        /// </summary>
        public Date When
        {
            get { return when; }
        }

        /// <summary>
        /// Quantia da transação.
        /// </summary>
        public double Amount
        {
            get { return amount; }
        }

        /// <summary>
        /// Objeto que representa uma transação.
        /// </summary>
        /// <param name="who">Dono da transação.</param>
        /// <param name="when">Data da transação.</param>
        /// <param name="amount">Quantia da transação.</param>
        public Transaction(string who, Date when, double amount)
        {
            this.who = who;
            this.when = when;
            this.amount = amount;
        }

        /// <summary>
        /// Objeto que representa uma transação.
        /// </summary>
        /// <param name="transaction">String no formato "who when amount"</param>
        public Transaction(string transaction)
        {
            transaction = transaction.Trim();
            int posicaoAmount = transaction.LastIndexOf(' ');
            int posicaWhen = transaction.Substring(0, posicaoAmount).Trim().LastIndexOf(' ');

            string who = transaction.Substring(0, posicaWhen).Trim();
            string when = transaction.Substring(posicaWhen + 1, posicaoAmount - posicaWhen - 1).Trim();
            string amount = transaction.Substring(posicaoAmount + 1);

            this.who = who;
            this.when = new Date(when);
            this.amount = Convert.ToDouble(amount);
        }

        /// <summary>
        /// Verifica se duas transações são iguais.
        /// </summary>
        /// <param name="obj">transação a ser comparada.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Transaction tr)
            {
                return tr.Who.Equals(who) && tr.When.Equals(when) && tr.Amount.Equals(amount);
            }

            return false;
        }

        /// <summary>
        /// Retorna uma representação do objeto como string.
        /// </summary>
        /// <returns>String no formato "who when amount".</returns>
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", who, when, amount);
        }

        /// <summary>
        /// Retorna um hash para a transação.
        /// </summary>
        /// <returns>Hash da transação.</returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        /// Compara a instância atual com outra transação informada. Verifica se
        /// esta é maior, menor ou igual.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object obj)
        {
            if (obj is Transaction tr)
            {
                int amountComp = amount.CompareTo(tr.Amount);

                if (amountComp != 0)
                {
                    return amountComp;
                }

                int whenComp = when.CompareTo(tr.When);

                if (whenComp != 0)
                {
                    return whenComp;
                }

                return who.CompareTo(tr.Who);
            }
            
            throw new ArgumentException("O dado informado deve ser do tipo Transaction.");
        }
    }
}