using DesignPattern_CQRS.MediatorDesignPattern.Results;
using MediatR;

namespace DesignPattern_CQRS.MediatorDesignPattern.Queries
{
    public class GetCustomerByIdQuery : IRequest<GetCustomerByIdQueryResult>
    {
        public int Id { get; set; }
        public GetCustomerByIdQuery(int id)
        {
            Id = id;
        }


    }
}
