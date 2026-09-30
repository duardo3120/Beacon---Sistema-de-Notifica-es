namespace Entidades
{
    public class EventoAlerta : Evento
    {
        private string _motivo = string.Empty;
        public string Motivo
        {
            get { return _motivo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O motivo do alerta não pode ser vazio.");
                }
                _motivo = value;
            }
        }

        public EventoAlerta(string motivo, string descricao, string destinatario) : base(descricao, destinatario)
        {
            Motivo = motivo;
        }

        public override string GerarMensagem()
        {
            return $"Atenção: {Motivo}.";
        }
    }
}