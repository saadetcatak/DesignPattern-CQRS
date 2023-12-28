using DesignPattern_CQRS.MediatorDesignPattern.Commands;
using DesignPattern_CQRS.MediatorDesignPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern_CQRS.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllCustomerQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand command)
        {
            await _mediator.Send(command);
            return View();
        }

        public async Task<IActionResult> DeleteCustomer(int id)
        {
            await _mediator.Send(new RemoveCustomerCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCustomer(int id)
        {
            var values = await _mediator.Send(new GetCustomerByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> CustomerCount(GetCountCustomerQuery query)
        {
            var customerCount=await _mediator.Send(query);
            return View(customerCount);
        }
    }
}
