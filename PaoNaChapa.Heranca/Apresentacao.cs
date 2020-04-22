using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PaoNaChapa.Heranca
{
    internal class Apresentacao
    {
        private enum EMenu
        {
            [Description("Adicionar itens ao carrinho")]
            Um = 1,
            [Description("Remover itens do carrinho")]
            Dois = 2

        }
        public Apresentacao()
        {
            Console.WriteLine("Seja bem vindo à Pão na Chapa");
            ExecutarFluxo();
        }

        private void ExibirMenu()
        {
            Console.WriteLine("Escolha uma das opções: ");
            Dictionary<int, string> menu = ConverterMenu();
            foreach (var item in menu)
                Console.WriteLine($"{item.Key} - {item.Value}");
            Console.WriteLine("0 - Sair");
        }

        private void ExecutarFluxo()
        {
            int resposta;
            do
            {
                ExibirMenu();
                resposta = int.Parse(Console.ReadLine());
            } while (resposta != 0);
        }

        private Dictionary<int, string> ConverterMenu()
        {
            Dictionary<int, string> menu = new Dictionary<int, string>();
            foreach (EMenu item in Enum.GetValues(typeof(EMenu)))
                menu.Add((int)item, Utilidade.GetDescricaoEnum(item));
            return menu;
        }
    }
}
