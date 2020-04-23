using System;

namespace PaoNaChapa.Heranca
{
    /// <summary>
    /// Gerenciador de compras da aplicação
    /// </summary>
    internal class GerenciarCompra
    {
        /// <summary>
        /// Manipular o carrinho de compras
        /// </summary>
        /// <param name="adicionar">Indica se o usuário adicionou ou removeu um item do carrinho</param>
        /// <returns></returns>
        private int ManipularCarrinho(bool adicionar) => adicionar ? 1 : -1;

        /// <summary>
        /// Executar funcionalidade de acordo com a escolha do usuário
        /// </summary>
        /// <param name="opcao">Opção do menu, selecionada pelo usuário</param>
        /// <param name="saldoCarrinho">Saldo do carrinho</param>
        /// <returns></returns>
        public int DefinirAcao(int opcao, ref int saldoCarrinho)
        {
            int resposta = opcao;
            switch (opcao)
            {
                case 1:
                    resposta = ManipularCarrinho(true);
                    break;
                case 2:
                    resposta = ManipularCarrinho(false);
                    break;
                default: break;
            }
            saldoCarrinho += resposta;
            if (saldoCarrinho < 0)
                resposta = saldoCarrinho = 0;
            return resposta;
        }
    }
}
