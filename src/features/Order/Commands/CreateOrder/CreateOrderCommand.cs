using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Ordering.Features.Order.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<Guid>
    {
        public string Name { get; set; }

        public int Number { get; set; }
    }
}
