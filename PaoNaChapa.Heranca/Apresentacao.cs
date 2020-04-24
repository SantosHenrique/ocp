using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PaoNaChapa.Heranca
{
    /// <summary>
    /// Interface do usuário
    /// </summary>
    internal class Apresentacao
    {
        /// <summary>
        /// Controla os itens do menu que serão apresentados ao usuário
        /// </summary>
        private enum EMenu
        {
            [Description("Adicionar itens ao carrinho")]
            Um = 1,
            [Description("Remover itens do carrinho")]
            Dois = 2,
            [Description("Caixa")]
            Tres = 3
        }

        public Apresentacao()
        {
            Console.WriteLine("Seja bem vindo à Pão na Chapa");
        }

        /// <summary>
        /// Exibe o menu para o usuário
        /// </summary>
        public void ExibirMenu()
        {
            Console.WriteLine("Escolha uma das opções: ");
            Dictionary<int, string> menu = ConverterMenu();
            foreach (var item in menu)
                Console.WriteLine($"{item.Key} - {item.Value}");
            Console.WriteLine("0 - Sair");
        }

        /// <summary>
        /// Mantém a apresentação das informações para o usuário
        /// </summary>
        public static void ExecutarFluxo(Apresentacao apresentacao)
        {
            int resposta;
            GerenciarCompra gerenciarCompra = new GerenciarCompra();
            int saldoCarrinho = 0;
            do
            {
                apresentacao.ExibirMenu();
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
            foreach (EMenu item in Enum.GetValues(typeof(EMenu)))
                menu.Add((int)item, Utilidade.GetDescricaoEnum(item));
            return menu;
        }

        public static string ConfirmarCaixa()
        {
            Console.WriteLine("Tem certeza que deseja finalizar a compra? (Sim/Não)");
            string resposta = Console.ReadLine();
            return resposta;
        }
    }
}
