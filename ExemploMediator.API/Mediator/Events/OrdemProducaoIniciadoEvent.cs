using MediatR;

namespace ExemploMediator.API.Mediator.Events
{
    public class OrdemProducaoIniciadoEvent : INotification 
    { 
        public int IdOP { get; set; }
        public string CodigoOP { get; set; }
    }
}
