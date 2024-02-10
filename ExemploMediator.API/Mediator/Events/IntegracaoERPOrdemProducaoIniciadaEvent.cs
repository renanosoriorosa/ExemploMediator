using ExemploMediator.API.Mediator.Commands;
using MediatR;

namespace ExemploMediator.API.Mediator.Events
{
    public class IntegracaoERPOrdemProducaoIniciadaEvent : INotificationHandler<OrdemProducaoIniciadoEvent>
    {
        private readonly ILogger<OrdemProducaoIniciadoEvent> _logger;

        public IntegracaoERPOrdemProducaoIniciadaEvent(ILogger<OrdemProducaoIniciadoEvent> logger)
        {
            _logger = logger;
        }

        public async Task Handle(OrdemProducaoIniciadoEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Conectando com a fila RabbtMQ");

            await Task.Delay(16000);

            _logger.LogInformation("OP add na fila RabbitMQ");
        }
    }
}
