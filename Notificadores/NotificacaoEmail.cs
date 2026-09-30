namespace Notificadores
{
    public class NotificacaoEmail : Interfaces.INotificacao
    {
        public void Enviar(string destinatario, string mensagem)
        {
            Console.WriteLine($"[EMAIL], Para: {destinatario} | {mensagem}");
        }
    }
}