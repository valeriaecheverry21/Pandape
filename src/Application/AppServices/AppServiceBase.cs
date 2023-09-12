using AutoMapper;

namespace Pandape.Application.AppServices
{
    public abstract class AppServiceBase
    {
        protected IMapper Mapper { get; }

        protected AppServiceBase(IMapper mapper) => Mapper = mapper;
    }
}
