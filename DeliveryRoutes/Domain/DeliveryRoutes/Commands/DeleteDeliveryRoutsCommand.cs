using CSharpFunctionalExtensions;
using MediatR;

namespace DeliveryRoutes.Domain.DeliveryRoutes.Commands
{
    public class DeleteDeliveryRoutsCommand : IRequest<Result<bool>>
    {
        public short CompannyCode { get; private set; }
        public short DeliveryRoutesCode { get; private set; } 
    }
}