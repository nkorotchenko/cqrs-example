using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Simple.Ordering.Api.Models.Order;
using Simple.Ordering.Features.Order.Commands.CreateOrder;
using Simple.Ordering.Features.Order.Queries.GetOrderById;

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

        /// <summary>
        /// Создание заказа
        /// </summary>
        /// <param name="model"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest model, CancellationToken token)
        {
            var command = model.Adapt<CreateOrderCommand>();
            return Ok(await _mediator.Send(command, token));
        }

        /// <summary>
        /// Получение заказа по уникальному идентификатору
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet("{orderId}")]
        public async Task<IActionResult> CreateOrder([FromRoute] Guid orderId, CancellationToken token)
        {
            return Ok(await _mediator.Send(new GetOrderByIdQuery(orderId), token));
        }
    }
}
