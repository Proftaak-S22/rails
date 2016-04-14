using CTRails.DAL.Contexts;
using CTRails.Entities;


namespace CTRails.DAL.Repositories
{
    public class AccountTypeRepository : Repository<AccountType>
    {
        public AccountTypeRepository(IDataContext<AccountType> context)
            : base(context)
        {
            
        }
    }
}
