using System;
using System.Collections.Generic;
using System.Text;

namespace PaoNaChapa.Heranca
{
    /// <summary>
    /// Responsável pelas transações com o cartão de débito
    /// </summary>
    public class PagamentoCartaoDebito : PagamentoCartao
    {
        /// <summary>
        /// Validar as credencias de forma específica para cartão de débito
        /// </summary>
        /// <param name="senha">Senha</param>
        /// <returns>True caso obtenha sucesso na validação</returns>
        protected override bool ValidarCredenciais(string senha)
        {
            return true;
        }

        /// <summary>
        /// Finalizar o pagamento, específico para cartão de débito
        /// </summary>
        /// <returns>True em caso de sucesso</returns>
        protected override bool CompletarPagamento()
        {
            return true;
        }
    }
}
