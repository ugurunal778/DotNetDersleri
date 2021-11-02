using Business;

namespace FirstWcfService
{
    public class BaseService
    {
        private IFirstWcfServiceBusiness _firstWcfServiceBusiness;
        public IFirstWcfServiceBusiness FirstWcfServiceBusiness
        {
            get
            {
                if (_firstWcfServiceBusiness is null)
                    _firstWcfServiceBusiness = new FirstWcfServiceBusiness();
                return _firstWcfServiceBusiness;
            }
        }
    }
}