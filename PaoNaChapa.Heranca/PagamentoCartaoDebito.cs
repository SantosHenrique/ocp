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
        protected override bool ValidarCredenciais(string senha)
        {
            return true;
        }

        protected override bool CompletarPagamento()
        {
            return true;
        }
    }
}
