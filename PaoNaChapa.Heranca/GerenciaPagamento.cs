
namespace PaoNaChapa.Heranca
{
    public class GerenciaPagamento
    {
        public GerenciaPagamento()
        {
            Executar();
        }

        private void Executar()
        {
            int resposta = new Apresentacao(false).ExibirMenu((int)Enuns.ETipoMenu.Pagamento);

        }

        private void DefinirAcao(int opcao)
        {
            switch (opcao)
            {
                case (int)Enuns.EMenuPagamento.Debito:break;
                case (int)Enuns.EMenuPagamento.Dinheiro:break;
                case (int)Enuns.EMenuPagamento.Marcar:break;
                default:break;
            }
        }
    }
}
