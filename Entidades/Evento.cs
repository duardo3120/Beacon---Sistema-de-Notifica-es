namespace Entidades
{
    public abstract class Evento
    {

        //Usei i.a para gerar o código de forma mais rápida, mas não sei se é a melhor forma de fazer isso, a ideia minha foi proteger que ninguem possa alterar os dados
        private string _descricao = string.Empty;
        public string Descricao
        {
            get => _descricao;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A descrição do evento não pode ser nula ou vazia.");
                _descricao = value;
            }
        }

        //Usei i.a para gerar o código de forma mais rápida, mas não sei se é a melhor forma de fazer isso, a ideia minha foi proteger que ninguem possa alterar os dados
        private string _destinatario = string.Empty;
        public string Destinatario
        {
            get => _destinatario;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O destinatário do evento não pode ser nulo ou vazio.");
                _destinatario = value;
            }
        }

        public Evento(string descricao, string destinatario)
        {
            Descricao = descricao;
            Destinatario = destinatario;
        }

        public abstract string GerarMensagem();
    }
}