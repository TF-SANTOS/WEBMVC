namespace Financas.WEBMVC.Controllers
{
    public class FinançasContext
    {
        public object Receitas { get; internal set; }
        public object Movimentacao{ get; internal set; }
        public object Ajuste { get; internal set; }
        public object Despesa { get; internal set; }
    }
}
