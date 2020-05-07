using System.ComponentModel;

namespace PaoNaChapa.Heranca
{
    /// <summary>
    /// Todo Enum do projeto estará aqui
    /// </summary>
    public class Enuns
    {
        /// <summary>
        /// Controla os itens do menu que serão apresentados ao usuário
        /// </summary>
        public enum EMenu
        {
            [Description("Adicionar itens ao carrinho")]
            Um = 1,
            [Description("Remover itens do carrinho")]
            Dois = 2,
            [Description("Caixa")]
            Tres = 3
        }

        /// <summary>
        /// Controla os itens do menu de pagamento
        /// </summary>
        public enum EMenuPagamento
        {
            [Description("Cartão - Débito")]
            Um = 1,
            [Description("Dinheiro")]
            Dois = 2,
            [Description("Marcar na conta")]
            Tres = 3
        }

        /// <summary>
        /// Representa os tipos de menu
        /// </summary>
        public enum ETipoMenu
        {
            Padrao = 1,
            Pagamento = 2
        }
    }
}
