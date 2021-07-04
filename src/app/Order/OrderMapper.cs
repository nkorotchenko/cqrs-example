using System;
using Mapster;
using Simple.Ordering.Application.Order.Commands.CreateOrder;

namespace Simple.Ordering.Application.Order
{
    public class OrderMapper : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.ForType<CreateOrderCommand, Dal.Entities.Order>()
                .Map(x => x.Id, x => Guid.NewGuid());
        }
    }
}