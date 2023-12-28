using DesignPattern_CQRS.DAL.Context;
using DesignPattern_CQRS.MediatorDesignPattern.Queries;
using DesignPattern_CQRS.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern_CQRS.MediatorDesignPattern.Handlers
{
    public class GetCountCustomerQueryHandler : IRequestHandler<GetCountCustomerQuery, GetCountCustomerQueryResult>
    {
        private readonly SaleContext _context;

        public GetCountCustomerQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task<GetCountCustomerQueryResult> Handle(GetCountCustomerQuery request, CancellationToken cancellationToken)
        {

            var customerCount = await _context.Customers.CountAsync();
            return new GetCountCustomerQueryResult
            {
                Count = customerCount,
            };

        }
    }
}

