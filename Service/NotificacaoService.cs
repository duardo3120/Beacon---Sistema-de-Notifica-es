using Entidades;
using Interfaces;
namespace Service
{
    public class NotificacaoService
    {
        public void Enviar(Evento evento, INotificacao notificacao)
        {
            // Codigo abaixo foi feito com i.a, de fato eu travei na hora do raciocinio
            string destinatario = evento.Destinatario;
            string mensagem = evento.GerarMensagem();
            notificacao.Enviar(destinatario, mensagem);
        }
    }
}