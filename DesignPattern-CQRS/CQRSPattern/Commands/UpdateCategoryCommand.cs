namespace DesignPattern_CQRS.CQRSPattern.Commands
{
    public class UpdateCategoryCommand
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
