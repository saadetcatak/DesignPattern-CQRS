using MediatR;

namespace DesignPattern_CQRS.MediatorDesignPattern.Commands
{
    public class RemoveCustomerCommand:IRequest
    {
        public int Id { get; set; }
        public RemoveCustomerCommand(int id)
        {
            Id = id;
        }

        
    }
}
