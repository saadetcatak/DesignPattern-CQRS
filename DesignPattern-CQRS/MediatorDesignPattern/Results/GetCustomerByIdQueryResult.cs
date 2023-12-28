namespace DesignPattern_CQRS.MediatorDesignPattern.Results
{
    public class GetCustomerByIdQueryResult
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
    }
}
