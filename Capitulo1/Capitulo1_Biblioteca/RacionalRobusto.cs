using System;

namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa um racional robusto em relação a overflow.
    /// </summary>
    public class RacionalRobusto
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
        /// Objeto que representa um racional robusto em relação a overflow.
        /// </summary>
        /// <param name="numerador">Numerador da fração.</param>
        /// <param name="denominador">Denominador da fração.</param>
        public RacionalRobusto(int numerador, int denominador)
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
        /// <exception cref="OverflowException">Lançada quando um dos membros da fração resulta
        /// resulta em overflow.
        /// </exception>
        public RacionalRobusto Mais(RacionalRobusto b)
        {    
            long denominadorResultado = this.denominador * b.denominador;
            long numeradorResultado = (b.denominador * this.numerador) + (this.denominador * b.numerador);

            AssertOverflow(numeradorResultado, denominadorResultado);
            
            return new RacionalRobusto((int) numeradorResultado, (int) denominadorResultado);
        }

        /// <summary>
        /// Teste se algum membro da fração é maior que Int32.MaxValue.
        /// </summary>
        /// <param name="numeradorResultado">Numerador da fração.</param>
        /// <param name="denominadorResultado">Denominador da fração.</param>
        /// <exception cref="OverflowException">Lançãda se ocorreu overflow.</exception>
        private static void AssertOverflow(long numeradorResultado, long denominadorResultado)
        {
            if (numeradorResultado > Int32.MaxValue || denominadorResultado > Int32.MaxValue)
            {
                throw new OverflowException("Overflow ao realizar a operação.");
            }
        }

        /// <summary>
        /// Subtrai o racional informado da instância atual.
        /// </summary>
        /// <param name="b">Racional da ser subtraído.</param>
        /// <returns>O resultado da subtração.</returns>
        /// <exception cref="OverflowException">Lançada quando um dos membros da fração resulta
        /// resulta em overflow.
        /// </exception>
        public RacionalRobusto Menos(RacionalRobusto b)
        {
            long denominadorResultado = this.denominador * b.denominador;
            long numeradorResultado = (b.denominador * this.numerador) - (this.denominador * b.numerador);
            
            AssertOverflow(numeradorResultado, denominadorResultado);
            
            return new RacionalRobusto((int) numeradorResultado, (int) denominadorResultado);
        }

        /// <summary>
        /// Multiplica a instância atual pelo racional informado.
        /// </summary>
        /// <param name="b">Racional a ser multiplicado.</param>
        /// <returns>O resultado da multiplicação.</returns>
        /// <exception cref="OverflowException">Lançada quando um dos membros da fração resulta
        /// resulta em overflow.
        /// </exception>
        public RacionalRobusto Vezes(RacionalRobusto b)
        {
            long denominadorResultado = this.denominador * b.denominador;
            long numeradorResultado = this.numerador * b.numerador;
            
            AssertOverflow(numeradorResultado, denominadorResultado);
            
            return new RacionalRobusto((int) numeradorResultado, (int) denominadorResultado);
        }

        /// <summary>
        /// Divide a instância atual pelo racional informado.
        /// </summary>
        /// <param name="b">Racional pelo qual a instância atual será dividida.</param>
        /// <returns>O resultado da divisão.</returns>
        /// <exception cref="OverflowException">Lançada quando um dos membros da fração resulta
        /// resulta em overflow.
        /// </exception>
        public RacionalRobusto DivididoPor(RacionalRobusto b)
        {
            long denominadorResultado = this.denominador * b.numerador;
            long numeradorResultado = this.numerador * b.denominador;
            
            AssertOverflow(numeradorResultado, denominadorResultado);
            
            return new RacionalRobusto((int) numeradorResultado, (int) denominadorResultado);
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
            if (obj is RacionalRobusto b)
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