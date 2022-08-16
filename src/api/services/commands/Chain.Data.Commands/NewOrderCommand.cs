using AutoMapper;
using Chain.Data.Abstractions;
using Chain.Data.Request.request;
using Chain.Entities;
using MediatR;
namespace Chain.Data.Commands
{
    internal class NewOrderCommand : IRequestHandler<NewOrderRequest, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public NewOrderCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<bool> Handle(NewOrderRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<Order>();
            //var conflict = await repository.Get(f => f.IsActive , cancellationToken);
            //if (conflict is not null)
            //{
            //    return false;
            //}
            var entity = mapper.Map<Order>(request.Data);
            repository.Insert(entity);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;
        }
    }
}
