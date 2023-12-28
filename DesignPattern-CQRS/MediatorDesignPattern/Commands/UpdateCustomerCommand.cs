using MediatR;

namespace DesignPattern_CQRS.MediatorDesignPattern.Commands
{
    public class UpdateCustomerCommand:IRequest
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
    }
}
