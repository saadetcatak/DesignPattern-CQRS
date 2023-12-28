using DesignPattern_CQRS.DAL.Context;
using DesignPattern_CQRS.MediatorDesignPattern.Commands;
using MediatR;

namespace DesignPattern_CQRS.MediatorDesignPattern.Handlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly SaleContext _context;

        public UpdateCustomerCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Customers.Find(request.CustomerID);
            values.Surname= request.Surname;        
            values.Name= request.Name;
            values.Department= request.Department;
            await _context.SaveChangesAsync();
        }
    }
}
