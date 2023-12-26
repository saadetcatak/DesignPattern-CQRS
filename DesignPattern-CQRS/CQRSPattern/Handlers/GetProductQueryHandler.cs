using DesignPattern_CQRS.CQRSPattern.Results;
using DesignPattern_CQRS.DAL.Context;

namespace DesignPattern_CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly SaleContext _context;

        public GetProductQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Price = x.Price,
                Stock = x.Stock,
            }).ToList();
            return values;
        }
    }
}
