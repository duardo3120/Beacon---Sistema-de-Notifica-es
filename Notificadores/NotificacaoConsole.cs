namespace Notificadores
{
    public class NotificacaoConsole : Interfaces.INotificacao
    {
        public void Enviar(string destinatario, string mensagem)
        {
            Console.WriteLine($"[LOG] {destinatario}: {mensagem}");
        }
    }
}