using DesignPattern_CQRS.DAL.Context;
using DesignPattern_CQRS.MediatorDesignPattern.Queries;
using DesignPattern_CQRS.MediatorDesignPattern.Results;
using MediatR;

namespace DesignPattern_CQRS.MediatorDesignPattern.Handlers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, GetCustomerByIdQueryResult>
    {
        private readonly SaleContext _context;

        public GetCustomerByIdQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task<GetCustomerByIdQueryResult> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Customers.FindAsync(request.Id);

            return new GetCustomerByIdQueryResult
            {
                CustomerID = values.CustomerID,
                Name = values.Name,
                Surname = values.Surname,
                Department = values.Department,
            };
        }
    }
}
