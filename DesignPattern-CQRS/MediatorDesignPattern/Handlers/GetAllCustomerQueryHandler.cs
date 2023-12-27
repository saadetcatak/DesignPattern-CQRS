using DesignPattern_CQRS.DAL.Context;
using DesignPattern_CQRS.MediatorDesignPattern.Queries;
using DesignPattern_CQRS.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern_CQRS.MediatorDesignPattern.Handlers
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, List<GetAllCustomerQueryResult>>
    {
        private readonly SaleContext _context;

        public GetAllCustomerQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllCustomerQueryResult>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _context.Customers.Select(x => new GetAllCustomerQueryResult
            {
                CustomerID = x.CustomerID,
                Department = x.Department,
                Name = x.Name,
                Surname = x.Surname
            }).ToListAsync();
        }
    }
}
