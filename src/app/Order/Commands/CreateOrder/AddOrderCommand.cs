using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Ordering.Application.Order.Commands.CreateOrder
{
    public class AddOrderCommand : IRequest<Guid>
    {
        public string Name { get; set; }

        public int Number { get; set; }
    }
}
