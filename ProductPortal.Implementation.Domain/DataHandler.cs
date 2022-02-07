using AutoMapper;
using ProductPortal.Implementation.Domain.Models;

namespace ProductPortal.Implementation.Domain
{
    public class DataHandler : ProductPortal.Domain.DataHandler
    {
        public DataHandler(string connectionString, MapperConfigurationExpression? mapperConfigurationExpression = null) : base(connectionString, mapperConfigurationExpression)
        {
            _databaseContext = new Data.DatabaseContext(connectionString);

            mapperConfigurationExpression = GetDefaultMapperConfigurationExpression;

            mapperConfigurationExpression.CreateMap<Data.Models.Product, Product>()
                    .ForMember(dest => dest.Id, act => act.MapFrom(src => src.ProductId));

            var config = new MapperConfiguration(mapperConfigurationExpression);
            config.AssertConfigurationIsValid();
            _autoMapper = new Mapper(config);
        }
    }
}