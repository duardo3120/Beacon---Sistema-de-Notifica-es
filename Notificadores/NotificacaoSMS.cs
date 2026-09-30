namespace Notificadores
{
    public class NotificacaoSMS : Interfaces.INotificacao
    {
        public void Enviar(string destinatario, string mensagem)
        {
            // Lógica para enviar notificação por SMS
            Console.WriteLine($"[SMS], Para: {destinatario} | {mensagem}");
        }
    }
}