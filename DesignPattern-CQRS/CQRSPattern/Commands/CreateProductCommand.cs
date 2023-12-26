namespace DesignPattern_CQRS.CQRSPattern.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
    }
}
