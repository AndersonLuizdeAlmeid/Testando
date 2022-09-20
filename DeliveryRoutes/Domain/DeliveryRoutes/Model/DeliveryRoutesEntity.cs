using CSharpFunctionalExtensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DeliveryRoutes.Domain.DeliveryRoutes.Commands;

namespace DeliveryRoutes.Domain.DeliveryRoutes.Model
{
    public class DeliveryRoutesEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public short CompanyCode { get; private set; } 
        public int DeliveryRoutesCode { get; private set; }
        public char UfRouteOrigin { get; private set; }
        public char CityOrigin { get; private set; }
        public char UfDestinationRoute { get; private set; }
        public char CityDestination { get; private set; }
        public object CodigoEmpresa { get; internal set; }
        private DeliveryRoutesEntity(short companyCode, int deliveryRoutesCode, char ufRouteOrigin, char cityOrigin, 
                                     char ufDestinationRoute, char cityDestination)
        {
            CompanyCode = companyCode;
            DeliveryRoutesCode = deliveryRoutesCode;
            UfRouteOrigin = ufRouteOrigin;
            CityOrigin = cityOrigin;
            UfDestinationRoute = ufDestinationRoute;
            CityDestination = cityDestination;
        }

        public static Result<DeliveryRoutesEntity> Create(CreateDeliveryRoutesCommand deliveryRoutesCommand)
        {
            if (deliveryRoutesCommand.CompanyCode <= 0)
                return Result.Failure<DeliveryRoutesEntity>("Error getting company from employee.");

            if (deliveryRoutesCommand.DeliveryRoutesCode <= 0)
                return Result.Failure<DeliveryRoutesEntity>("Error DeliveryRoutesCode");

            if (deliveryRoutesCommand.UfRouteOrigin == 0)
                return Result.Failure<DeliveryRoutesEntity>("Error UfRouteOrigin");

            if (deliveryRoutesCommand.CityOrigin == 0)
                return Result.Failure<DeliveryRoutesEntity>("Error CityOrigin");

            if (deliveryRoutesCommand.UfRouteDestiny == 0)
                return Result.Failure<DeliveryRoutesEntity>("Error UfRouteDestiny");

            if (deliveryRoutesCommand.CityDestiny == 0)
                return Result.Failure<DeliveryRoutesEntity>("Error CityDestiny");

            return new DeliveryRoutesEntity(
                deliveryRoutesCommand.CompanyCode,
                deliveryRoutesCommand.DeliveryRoutesCode,
                deliveryRoutesCommand.UfRouteOrigin,
                deliveryRoutesCommand.CityOrigin,
                deliveryRoutesCommand.UfRouteDestiny,
                deliveryRoutesCommand.CityDestiny);
        }

        public void Update(UpdateDeliveryRoutsCommand deliveryRoutesCommand)
        {
            CompanyCode = deliveryRoutesCommand.CompanyCode;
            DeliveryRoutesCode = deliveryRoutesCommand.DeliveryRoutesCode;
            UfRouteOrigin = deliveryRoutesCommand.UfRouteOrigin;
            CityOrigin = deliveryRoutesCommand.CityOrigin;
            UfDestinationRoute = deliveryRoutesCommand.UfRouteDestiny;
            CityDestination = deliveryRoutesCommand.CityDestiny;
        }

        public Result<bool> ChecksIfItCanCreateOrUpdate(int quantityRegistersExists)
        {
            if (quantityRegistersExists > 0)
                return Result.Failure<bool>("There are already records with these parameters in the database");

            return true;
        }
    }
}