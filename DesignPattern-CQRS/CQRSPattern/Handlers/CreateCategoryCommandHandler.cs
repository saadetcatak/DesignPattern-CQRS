using DesignPattern_CQRS.CQRSPattern.Commands;
using DesignPattern_CQRS.DAL.Context;
using DesignPattern_CQRS.DAL.Entities;

namespace DesignPattern_CQRS.CQRSPattern.Handlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly SaleContext _context;

        public CreateCategoryCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public void Handle(CreateCategoryCommand command) 
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName,
            });
            _context.SaveChanges();
        }
    }
}
