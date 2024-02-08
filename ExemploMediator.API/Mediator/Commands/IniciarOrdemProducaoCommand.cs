using MediatR;

namespace ExemploMediator.API.Mediator.Commands
{
    public class IniciarOrdemProducaoCommand : IRequest
    {
        public int IdOP { get; set; }
        public string CodigoOP { get; set; }
    }
}
