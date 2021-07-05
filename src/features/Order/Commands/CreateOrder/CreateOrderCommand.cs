using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Ordering.Features.Order.Commands.CreateOrder
{
    public record CreateOrderCommand(string Name, int Number) : IRequest<Guid>;
}
