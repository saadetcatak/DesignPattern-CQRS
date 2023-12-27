using DesignPattern_CQRS.CQRSPattern.Commands;
using DesignPattern_CQRS.DAL.Context;

namespace DesignPattern_CQRS.CQRSPattern.Handlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly SaleContext _context;

        public RemoveCategoryCommandHandler(SaleContext context)
        {
            _context = context;
        }
        public void Handler(RemoveCategoryCommand command)
        {
            var value = _context.Categories.Find(command.Id);
            _context.Categories.Remove(value);
            _context.SaveChanges();
        }
    }
}
