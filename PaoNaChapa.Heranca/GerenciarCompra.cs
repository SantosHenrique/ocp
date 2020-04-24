using System;
using System.Linq;

namespace PaoNaChapa.Heranca
{
    /// <summary>
    /// Gerenciador de compras da aplicação
    /// </summary>
    internal class GerenciarCompra
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
                case 1:
                    resposta = ManipularCarrinho(true);
                    saldoCarrinho += resposta;
                    break;
                case 2:
                    resposta = ManipularCarrinho(false);
                    saldoCarrinho += resposta;
                    break;
                case 3:
                    Console.WriteLine("ENTREI NO 3");
                    ConfirmarCaixa();
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
        /// <returns></returns>
        private int ManipularCarrinho(bool adicionar) => adicionar ? 1 : -1;

        private bool ConfirmarCaixa()
        {
            string resposta = string.Empty;
            bool? irParaCaixa = null;
            string[] sim = { "s", "sim" };
            string[] nao = { "n", "nao" };
            do
            {
                resposta = Apresentacao.ConfirmarCaixa().ToLower().Replace("~", "");
                if (sim.Contains(resposta) || nao.Contains(resposta))
                    irParaCaixa = sim.Contains(resposta);
                else
                    Console.WriteLine("Opçao inválida! Informe Sim ou Não.");
            } while (!irParaCaixa.HasValue);
            if (irParaCaixa.Value)
                Console.WriteLine("Chamar pagamento");
            else
                Console.WriteLine("Chamar pagamento");

            return irParaCaixa.Value;
        }
    }
}
