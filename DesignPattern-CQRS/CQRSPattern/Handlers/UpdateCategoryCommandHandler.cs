using DesignPattern_CQRS.CQRSPattern.Commands;
using DesignPattern_CQRS.DAL.Context;

namespace DesignPattern_CQRS.CQRSPattern.Handlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly SaleContext _context;

        public UpdateCategoryCommandHandler(SaleContext context)
        {
            _context = context;
        }

        public void Handler(UpdateCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryID);
            values.CategoryName = command.CategoryName;
            _context.SaveChanges();
        }
    }
}
