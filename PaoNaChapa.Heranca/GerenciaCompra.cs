using System;
using System.Linq;

namespace PaoNaChapa.Heranca
{
    /// <summary>
    /// Gerenciador de compras da aplicação
    /// </summary>
    internal class GerenciaCompra
    {
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
                case (int)Enuns.EMenu.Um:
                    resposta = ManipularCarrinho(true);
                    saldoCarrinho += resposta;
                    break;
                case (int)Enuns.EMenu.Dois:
                    resposta = ManipularCarrinho(false);
                    saldoCarrinho += resposta;
                    break;
                case (int)Enuns.EMenu.Tres:
                    if (ConfirmarCaixa())
                    {
                        GerenciaPagamento gP = new GerenciaPagamento();
                    }
                    break;
                default: break;
            }

            if (saldoCarrinho < 0)
                resposta = saldoCarrinho = 0;

            return resposta;
        }

        /// <summary>
        /// Manipular o carrinho de compras
        /// </summary>
        /// <param name="adicionar">Indica se o usuário adicionou ou removeu um item do carrinho</param>
        /// <returns>Quantidade de item que será adicionada ou removida do carrinho</returns>
        private int ManipularCarrinho(bool adicionar) => adicionar ? 1 : -1;

        /// <summary>
        /// Veririfcar se o usuário reamente deseja finalizar a compra
        /// </summary>
        /// <returns>True para finalizar compra e false para não finalizar</returns>
        private bool ConfirmarCaixa()
        {
            bool? irParaCaixa = null;
            string[] sim = { "s", "sim" };
            string[] nao = { "n", "nao" };
            do
            {
                string resposta = Apresentacao.ConfirmarCaixa().ToLower().Replace("~", "");
                if (sim.Contains(resposta) || nao.Contains(resposta))
                    irParaCaixa = sim.Contains(resposta);
                else
                    Console.WriteLine("Opçao inválida! Informe Sim ou Não.");
            } while (!irParaCaixa.HasValue);
            return irParaCaixa.Value;
        }

        /// <summary>
        /// Mantém a apresentação das informações para o usuário
        /// </summary>
        public static void ExecutarFluxo(Apresentacao apresentacao)
        {
            int resposta;
            GerenciaCompra gerenciarCompra = new GerenciaCompra();
            int saldoCarrinho = 0;
            do
            {
                resposta = apresentacao.ExibirMenu((int)Enuns.ETipoMenu.Padrao);
                if (resposta != 0)
                    apresentacao.ExibirCarrinho(gerenciarCompra.DefinirAcao(resposta, ref saldoCarrinho), saldoCarrinho);
            } while (resposta != 0 && resposta != 3);
        }
    }
}
