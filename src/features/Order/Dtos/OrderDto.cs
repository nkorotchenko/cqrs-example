using System;

namespace Simple.Ordering.Features.Order.Dtos
{
    public record OrderDto(
        Guid Id,
        string Name,
        int Number
    );
}