using Mapster;
using MediatR;
using Simple.Ordering.Data;
using Simple.Ordering.Features.Order.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simple.Ordering.Features.Order.Queries.GetOrderById
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, OrderDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetOrderByIdQueryHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OrderDto> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Orders
                .FindAsync(request.OrderId);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            return order.Adapt<OrderDto>();
        }
    }
}
