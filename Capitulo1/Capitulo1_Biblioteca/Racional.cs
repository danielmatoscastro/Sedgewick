using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa um número racional
    /// </summary>
    public class Racional
    {
        /// <summary>
        /// Numerador da fração.
        /// </summary>
        private long numerador;
        
        /// <summary>
        /// Denominador da fração.
        /// </summary>
        private long denominador;

        /// <summary>
        /// Objeto imutável que representa um número racional.
        /// </summary>
        /// <param name="numerador">Numerador da fração.</param>
        /// <param name="denominador">Denominador da fração.</param>
        public Racional(int numerador, int denominador)
        {
            int mdc = MaximoDivisorComum.Mdc(numerador, denominador);
            numerador /= mdc;
            denominador /= mdc;
            
            this.numerador = numerador;
            this.denominador = denominador;
        }

        /// <summary>
        /// Soma a instância atual a outro número racional.
        /// </summary>
        /// <param name="b">Racional a ser somado.</param>
        /// <returns>O resultado da soma.</returns>
        public Racional Mais(Racional b)
        {
            long denominadorResultado = this.denominador * b.denominador;
            long numeradorResultado = (b.denominador * this.numerador) + (this.denominador * b.numerador);
            
            return new Racional((int) numeradorResultado, (int) denominadorResultado);
        }

        /// <summary>
        /// Subtrai o racional informado da instância atual.
        /// </summary>
        /// <param name="b">Racional da ser subtraído.</param>
        /// <returns>O resultado da subtração.</returns>
        public Racional Menos(Racional b)
        {
            long denominadorResultado = this.denominador * b.denominador;
            long numeradorResultado = (b.denominador * this.numerador) - (this.denominador * b.numerador);
            
            return new Racional((int) numeradorResultado, (int) denominadorResultado);
        }

        /// <summary>
        /// Multiplica a instância atual pelo racional informado.
        /// </summary>
        /// <param name="b">Racional a ser multiplicado.</param>
        /// <returns>O resultado da multiplicação.</returns>
        public Racional Vezes(Racional b)
        {
            long denominadorResultado = this.denominador * b.denominador;
            long numeradorResultado = this.numerador * b.numerador;
            
            return new Racional((int) numeradorResultado, (int) denominadorResultado);
        }

        /// <summary>
        /// Divide a instância atual pelo racional informado.
        /// </summary>
        /// <param name="b">Racional pelo qual a instância atual será dividida.</param>
        /// <returns>O resultado da divisão.</returns>
        public Racional DivididoPor(Racional b)
        {
            long denominadorResultado = this.denominador * b.numerador;
            long numeradorResultado = this.numerador * b.denominador;
            
            return new Racional((int) numeradorResultado, (int) denominadorResultado);
        }

        /// <summary>
        /// Retorna um hash para a instância atual;
        /// </summary>
        /// <returns>Hash.</returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        /// Verifica se a instância atual é igual ao racional informado.
        /// </summary>
        /// <param name="obj">Racional a ser comparado com a instância atual.</param>
        /// <returns>True se os racionais forem iguais. False caso contrário.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Racional b)
            {
                return this.numerador == b.numerador && this.denominador == b.denominador;
            }

            return false;
        }

        /// <summary>
        /// Retorna uma representação do objeto como string.
        /// </summary>
        /// <returns>Representação do racional como string.</returns>
        public override string ToString()
        {
            return String.Format("{0}/{1}", numerador, denominador);
        }
    }
}