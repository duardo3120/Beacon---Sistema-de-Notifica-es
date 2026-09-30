namespace Entidades
{
    public class EventoPromocao : Evento
    {
        private int _desconto;
        public int Desconto
        {
            get { return _desconto; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O desconto não pode ser negativo.");
                }
                _desconto = value;
            }
        }

        public EventoPromocao(int desconto, string descricao, string destinatario) : base(descricao, destinatario)
        {
            Desconto = desconto;
        }

        public override string GerarMensagem()
        {
            return $"Você tem {Desconto}% de desconto,";
        }
    }
}