namespace Capitulo1_Biblioteca
{
    /// <summary>
    /// Classe que representa a distribuição de probabilidades (exata) da soma de dois dados.
    /// </summary>
    public class SomaDeDadosExata : SomaDeDados
    {
        
        /// <summary>
        /// Cria um objeto que representa a distribuição de probabilidades (exata)
        /// da soma de dois dados.
        /// </summary>
        public SomaDeDadosExata()
        {
            dist = new double[2*LADOS+1];

            for (int i = 1; i <= LADOS; i++)
            {
                for (int j = 1; j <= LADOS; j++)
                {
                    dist[i + j] += 1;
                }
            }

            for (int k = 2; k <= 2 * LADOS; k++)
            {
                dist[k] /= 36;
            }
        }

    }
}