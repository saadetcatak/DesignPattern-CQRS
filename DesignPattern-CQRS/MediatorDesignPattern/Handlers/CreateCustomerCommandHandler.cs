using DesignPattern_CQRS.DAL.Context;
using DesignPattern_CQRS.DAL.Entities;
using DesignPattern_CQRS.MediatorDesignPattern.Commands;
using MediatR;

namespace DesignPattern_CQRS.MediatorDesignPattern.Handlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly SaleContext _context;

        public CreateCustomerCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            _context.Customers.Add(new Customer
            {
                Department = request.Department,
                Name = request.Name,
                Surname = request.Surname
            });
            await _context.SaveChangesAsync();
        }
    }
}
