
namespace PaoNaChapa.Heranca
{
    /// <summary>
    /// Classe genérica para pagamentos com cartão
    /// </summary>
    public abstract class PagamentoCartao
    {
        /// <summary>
        /// Método para que o usuário informe as credencias do cartão
        /// </summary>
        public void InserirCredenciais() => ValidarCredenciais(Apresentacao.InformarCredenciaisCartao());

        /// <summary>
        /// Toda operação com cartão terá a validação de credenciais, no entanto o tipo de operação (crédito/débito) altera a forma com que o cartão é validado
        /// </summary>
        /// <param name="senha">Senha do cartão</param>
        /// <returns>Se as credenciais estão corretas</returns>
        protected abstract bool ValidarCredenciais(string senha);

        /// <summary>
        /// Finaliza a transação, a operação (crédito/débito) define a estrutura lógica
        /// </summary>
        /// <returns>Se a trasação foi ou não aceita</returns>
        protected abstract bool CompletarPagamento();
    }
}
