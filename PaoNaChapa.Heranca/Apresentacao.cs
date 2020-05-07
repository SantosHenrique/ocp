using System;
using System.Collections.Generic;

namespace PaoNaChapa.Heranca
{
    /// <summary>
    /// Interface do usuário
    /// </summary>
    internal class Apresentacao
    {
        public Apresentacao()
        {
            Console.WriteLine("Seja bem vindo à Pão na Chapa");
        }

        /// <summary>
        /// Exibe o menu para o usuário
        /// </summary>
        public void ExibirMenu(int tipo)
        {
            Console.WriteLine("Escolha uma das opções: ");
            Dictionary<int, string> menu = ConverterMenu();
            foreach (var item in menu)
                Console.WriteLine($"{item.Key} - {item.Value}");
            if (tipo == (int)Enuns.ETipoMenu.Padrao)
                Console.WriteLine("0 - Sair");
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
                apresentacao.ExibirMenu((int)Enuns.ETipoMenu.Padrao);
                resposta = int.Parse(Console.ReadLine());
                if (resposta != 0)
                    apresentacao.ExibirCarrinho(gerenciarCompra.DefinirAcao(resposta, ref saldoCarrinho), saldoCarrinho);
            } while (resposta != 0 && resposta != 3);
        }

        /// <summary>
        /// Informar situação do carrinho de compras para o usuário
        /// </summary>
        /// <param name="ultimaQtdCarrinho">Indica se o carrinho foi incrementado ou decrementado</param>
        /// <param name="saldoCarrinho">Saldo do carrinho</param>
        private void ExibirCarrinho(int ultimaQtdCarrinho, int saldoCarrinho)
        {
            if (ultimaQtdCarrinho == 0)
                Console.WriteLine("O carrinho não sofreu alterações.");
            else
            {
                string palavraChave = ultimaQtdCarrinho > 0 ? "adicionado" : "removido";
                Console.WriteLine($"Item {palavraChave} com sucesso!");
            }
            Console.WriteLine($"Saldo: {saldoCarrinho}");
        }

        /// <summary>
        /// Converte o EMenu em um dicionário, para construção do menu
        /// </summary>
        /// <returns>Dicionário com um inteiro e uma string</returns>
        private Dictionary<int, string> ConverterMenu()
        {
            Dictionary<int, string> menu = new Dictionary<int, string>();
            foreach (Enuns.EMenu item in Enum.GetValues(typeof(Enuns.EMenu)))
                menu.Add((int)item, Utilidade.GetDescricaoEnum(item));
            return menu;
        }

        /// <summary>
        /// Perguntar ao usuário se desa prosseguir com a operação em questão
        /// </summary>
        /// <returns>Resposta do usuário</returns>
        public static string ConfirmarCaixa()
        {
            Console.WriteLine("Tem certeza que deseja finalizar a compra? (Sim/Não)");
            return Console.ReadLine();
        }

        /// <summary>
        /// Interface para que o usuário informe as credenciais do cartão, a princípio apenas a senha
        /// </summary>
        /// <returns>Retornar senha</returns>
        public static string InformarCredenciaisCartao()
        {
            Console.WriteLine("Favor informar a senha");
            return Console.ReadLine();
        }

        public static void ValidarCredenciais() => Console.WriteLine("Verificando credenciais...");
        public static void CompletarTransacao() => Console.WriteLine("Transação aceita! Agradecemos pela sua compra.");

    }
}
