using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Simple.Ordering.Api.ViewModels.Order;
using Simple.Ordering.Application.Order.Commands.CreateOrder;

namespace Simple.Ordering.Api.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] OrderVm model, CancellationToken token)
        {
            var command = model.Adapt<AddOrderCommand>();
            return Ok(await _mediator.Send(command, token));
        }
    }
}
