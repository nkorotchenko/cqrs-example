using System;
using Mapster;
using Simple.Ordering.Features.Order.Commands.CreateOrder;

namespace Simple.Ordering.Features.Order
{
    public class OrderMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.ForType<CreateOrderCommand, Domain.Order>()
                .Map(x => x.Id, x => Guid.NewGuid());
        }
    }
}