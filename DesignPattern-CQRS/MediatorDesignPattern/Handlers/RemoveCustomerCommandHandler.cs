using DesignPattern_CQRS.DAL.Context;
using DesignPattern_CQRS.MediatorDesignPattern.Commands;
using MediatR;

namespace DesignPattern_CQRS.MediatorDesignPattern.Handlers
{
    public class RemoveCustomerCommandHandler : IRequestHandler<RemoveCustomerCommand>
    {
        private readonly SaleContext _context;

        public RemoveCustomerCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveCustomerCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Customers.Find(request.Id);
            _context.Customers.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
