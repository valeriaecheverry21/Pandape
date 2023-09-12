using AutoMapper;

namespace Pandape.Host.Mvc.ViewModels
{
    public abstract class ViewModelFactoryBase
    {
        public IMapper Mapper { get; set; }

        public ViewModelFactoryBase(IMapper mapper)
        {
            Mapper = mapper;
        }
    }
}
