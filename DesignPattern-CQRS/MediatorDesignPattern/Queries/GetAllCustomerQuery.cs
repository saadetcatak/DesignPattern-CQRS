using DesignPattern_CQRS.MediatorDesignPattern.Results;
using MediatR;

namespace DesignPattern_CQRS.MediatorDesignPattern.Queries
{
    public class GetAllCustomerQuery : IRequest<List<GetAllCustomerQueryResult>>
    {
    }
}
