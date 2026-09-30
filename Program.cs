using Service;


class Program
{
    static void Main(string[] args)
    {
        NotificacaoService notificacaoService = new NotificacaoService();
        Menu menu = new Menu(notificacaoService);

        menu.ExibirMenu();
    }
}