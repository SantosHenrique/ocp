using System;

namespace PaoNaChapa.Heranca
{
    /// <summary>
    /// Inicia o projeto
    /// </summary>
    public class Programa
    {
        /// <summary>
        /// Responsável por iniciar a interface do usuário
        /// </summary>
        public static void Main()
        {
            GerenciaCompra.ExecutarFluxo(new Apresentacao(true));
        }
    }
}
