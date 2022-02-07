using ProductPortal.Domain.Interfaces;
using AutoMapper;
using ProductPortal.Data;
using ProductPortal.Domain.Models;

namespace ProductPortal.Domain
{
    /// <summary>
    /// class to handle connection between DB and our objects
    /// </summary>
    public class DataHandler
    {
        public Data.BaseClasses.BaseDatabaseContext? _databaseContext { init; get; }
        public Mapper? _autoMapper { init; get; }

        public Type BasicDataBaseType { get; set; }

        public MapperConfigurationExpression GetDefaultMapperConfigurationExpression { get {
                var result = new MapperConfigurationExpression();
                result.CreateMap<Data.Models.Product, Product>()
                    .ForMember(dest => dest.Id, act => act.MapFrom(src => src.ProductId));
                result.CreateMap<Data.Models.Category, ICategory>()
                    .ForMember(dest => dest.Id, act => act.MapFrom(src => src.CategoryId));
                return result;
            }
        }

        public DataHandler(string connectionString) : this(connectionString, null)
        { }

        public DataHandler(string connectionString, MapperConfigurationExpression? mapperConfigurationExpression = null)
        {
            _databaseContext = new DatabaseContext(connectionString);
            if (mapperConfigurationExpression == null)
            {
                mapperConfigurationExpression = GetDefaultMapperConfigurationExpression;
            }

            var config = new MapperConfiguration(mapperConfigurationExpression);
            config.AssertConfigurationIsValid();
            _autoMapper = new Mapper(config);
        }

        /// <summary>
        /// Default call for default products
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts() => GetProducts<Data.Models.Product, Product>();

        public List<Category> GetCategories() => GetCategories<Data.Models.Category, Category>();

        /// <summary>
        /// When calling directly, we have altered products
        /// </summary>
        /// <typeparam name="TDataType"></typeparam>
        /// <typeparam name="TDomainType"></typeparam>
        /// <returns></returns>
        public List<TDomainType> GetProducts<TDataType, TDomainType>() where TDataType : class where TDomainType : class => _autoMapper.Map<List<TDomainType>>(_databaseContext.Products<TDataType>().ToList());

        public List<TDomainType> GetCategories<TDataType, TDomainType>() where TDataType : class where TDomainType : class => _autoMapper.Map<List<TDomainType>>(_databaseContext.Categories<TDataType>().ToList());
        
    }
}
