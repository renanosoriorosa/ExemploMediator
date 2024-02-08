using MediatR;

namespace ExemploMediator.API.Mediator.Commands
{
    public class IniciarOrdemProducaoCommandHandler : IRequestHandler<IniciarOrdemProducaoCommand>
    {
        private readonly IMediator _mediator;
        private readonly ILogger<IniciarOrdemProducaoCommandHandler> _logger;

        public IniciarOrdemProducaoCommandHandler(IMediator mediator,
            ILogger<IniciarOrdemProducaoCommandHandler> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public Task Handle(IniciarOrdemProducaoCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Iniciado a OP");

            // busca op no banco

            // realiza regras de negocio

            // atualiza a op no banco

            //chama eventos
            _logger.LogInformation("Enviado eventos");

            _logger.LogInformation("OP Iniciada");

            return Task.CompletedTask;
        }
    }
}
