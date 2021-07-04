using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Mapster;
using Simple.Ordering.Dal;

namespace Simple.Ordering.Application.Order.Commands.CreateOrder
{
    public class AddOrderCommandHandler : IRequestHandler<AddOrderCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;

        public AddOrderCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<Guid> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            var entity = request.Adapt<Dal.Entities.Order>();
            
            await _dbContext.Orders.AddAsync(entity, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            
            return entity.Id;
        }
    }
}
