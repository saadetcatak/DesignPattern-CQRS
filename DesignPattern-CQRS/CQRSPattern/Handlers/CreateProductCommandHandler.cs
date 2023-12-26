using DesignPattern_CQRS.CQRSPattern.Commands;
using DesignPattern_CQRS.DAL.Context;
using DesignPattern_CQRS.DAL.Entities;

namespace DesignPattern_CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly SaleContext _context;

        public CreateProductCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                CategoryID = command.CategoryID,
                Name = command.Name,
                Price = command.Price,
                Stock = command.Stock,
            });
            _context.SaveChanges();
        }
    }
}
