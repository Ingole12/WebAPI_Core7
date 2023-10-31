using LearnAPI.Repos;
using LearnAPI.Repos.Models;
using LearnAPI.ServicesInterface;

namespace LearnAPI.Container
{
    public class CustomerService : ICustomerService
    {
        private readonly LearnAPIDbContext _learnApiDbContext;
        public CustomerService(LearnAPIDbContext learnAPIDbContext)
        {
            _learnApiDbContext = learnAPIDbContext;
        }

        public List<TblLearnAPICustomer> GetAllCustomer()
        {
            return this._learnApiDbContext.TblCustomers.ToList();
        }
    }
}
