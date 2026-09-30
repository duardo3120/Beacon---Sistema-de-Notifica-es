namespace Entidades
{
    public class EventoPagamento : Evento
    {
        private double _valor;
        public double Valor
        {
            get { return _valor; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O valor do pagamento deve ser maior que zero.");
                }
                _valor = value;
            }
        }

        public EventoPagamento(double valor, string descricao, string destinatario) : base(descricao, destinatario)
        {
            Valor = valor;
        }

        public override string GerarMensagem()
        {
            return $"Pagamento de R${Valor} confirmado,";
        }
    }
}