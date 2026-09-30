using Entidades;
using Interfaces;
using Notificadores;
using Service;

public class Menu
{
    private readonly NotificacaoService _notificacaoService;

    public Menu(NotificacaoService notificacaoService)
    {
        _notificacaoService = notificacaoService;
    }

    public void ExibirMenu()
    {
        Console.WriteLine("Bem vindo ao sistema de notificações!");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Enviar notificação");
        Console.WriteLine("2 - Sair");

        while (true)
        {
            Console.WriteLine("Bem vindo ao sistema de notificações!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Enviar notificação");
            Console.WriteLine("2 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite o tipo de Evento(1 - Pagamento, 2 - Promocao):");
                    string tipoEvento = Console.ReadLine() ?? "";

                    Console.WriteLine("Digite o canal que deseja enviar a notificação(1 - Email, 2 - SMS, 3 - Console)");
                    string tipoCanal = Console.ReadLine() ?? "";

                    Console.WriteLine("Informe os dados necessários");
                    string destinatario = Console.ReadLine() ?? "";

                    Evento eventoEscolhido = null;
                    INotificacao canalEscolhido = null;

                    if (tipoEvento == "1")
                    {
                        Console.WriteLine("Digite o valor do pagamento:");
                        double valorPagamento = double.Parse(Console.ReadLine() ?? "0");

                        eventoEscolhido = new EventoPagamento(valorPagamento, "Pagamento via Menu", destinatario);
                    }
                    else if (tipoEvento == "2")
                    {
                        Console.WriteLine("Digite o valor do desconto:");
                        int promocao = int.Parse(Console.ReadLine());

                        eventoEscolhido = new EventoPromocao(promocao, "Desconto via menu", destinatario);


                    }

                    if (tipoCanal == "1")
                    {
                        canalEscolhido = new NotificacaoEmail();
                    }
                    else if (tipoCanal == "2")
                    {
                        canalEscolhido = new NotificacaoSMS();
                    }
                    else if (tipoCanal == "3")
                    {
                        canalEscolhido = new NotificacaoConsole();
                    }

                    _notificacaoService.Enviar(eventoEscolhido, canalEscolhido);
                    break;

                case "2":
                    Console.WriteLine("Saindo do sistema...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }


    }
}