using CSharpFunctionalExtensions;
using MediatR;

namespace DeliveryRoutes.Domain.DeliveryRoutes.Commands
{
    public class UpdateDeliveryRoutsCommand : IRequest<Result<bool>>
    {
        public short CompanyCode { get; private set; }
        public short DeliveryRoutesCode { get; private set; }
        public char UfRouteOrigin { get; private set; }
        public char CityOrigin { get; private set; }
        public char UfRouteDestiny { get; private set; }
        public char CityDestiny { get; private set; }
        public UpdateDeliveryRoutsCommand(short companycode, short deliveryRoutesCode, char ufRouteOrigin, char cityOrigin, char ufRouteDestiny, char cityDestiny)
        {
            CompanyCode = companycode;
            DeliveryRoutesCode = deliveryRoutesCode;
            UfRouteOrigin = ufRouteOrigin;
            CityOrigin = cityOrigin;
            UfRouteDestiny = ufRouteDestiny;
            CityDestiny = cityDestiny;
        }
    }
    
}