using DesignPattern_CQRS.CQRSPattern.Results;
using DesignPattern_CQRS.DAL.Context;

namespace DesignPattern_CQRS.CQRSPattern.Handlers
{
    public class GetCategoryQueryHandler
    {
        private readonly SaleContext _context;

        public GetCategoryQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public List<GetCategoryQueryResult> Handle()
        {
            var values=_context.Categories.Select(x=>new GetCategoryQueryResult
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName
            }).ToList();
            return values;
        }

    }
}
