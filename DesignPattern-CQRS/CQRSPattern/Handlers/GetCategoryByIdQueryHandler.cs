using DesignPattern_CQRS.CQRSPattern.Queries;
using DesignPattern_CQRS.CQRSPattern.Results;
using DesignPattern_CQRS.DAL.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DesignPattern_CQRS.CQRSPattern.Handlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly SaleContext _context;

        public GetCategoryByIdQueryHandler(SaleContext context)
        {
            _context = context;
        }
        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query)
        {
            var values = _context.Categories.Find(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryID = values.CategoryID,
                CategoryName = values.CategoryName
            };
        }
    }
}
