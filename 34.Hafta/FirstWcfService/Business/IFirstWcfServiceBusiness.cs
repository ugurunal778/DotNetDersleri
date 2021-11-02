using DTO;

namespace Business
{
    public interface IFirstWcfServiceBusiness
    {
        string GetData(int value);
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }
}
