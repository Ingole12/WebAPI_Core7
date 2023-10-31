using LearnAPI.Repos.Models;

namespace LearnAPI.ServicesInterface
{
    public interface ICustomerService
    {
        public List<TblLearnAPICustomer> GetAllCustomer();
    }
}
