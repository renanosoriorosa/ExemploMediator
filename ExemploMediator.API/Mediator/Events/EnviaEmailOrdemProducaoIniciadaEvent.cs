using ExemploMediator.API.Mediator.Commands;
using MediatR;

namespace ExemploMediator.API.Mediator.Events
{
    public class EnviaEmailOrdemProducaoIniciadaEvent : INotificationHandler<OrdemProducaoIniciadoEvent>
    {
        private readonly ILogger<OrdemProducaoIniciadoEvent> _logger;

        public EnviaEmailOrdemProducaoIniciadaEvent(ILogger<OrdemProducaoIniciadoEvent> logger)
        {
            _logger = logger;
        }

        public async Task Handle(OrdemProducaoIniciadoEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Preparando envio de emails de op inciada....");

            await Task.Delay(3000);

            _logger.LogInformation("Emails enviados com sucesso!");
        }
    }
}
