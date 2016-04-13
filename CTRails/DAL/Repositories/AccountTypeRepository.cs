using CTRails.Entities;


namespace CTRails.DAL.Repositories
{
    public class AccountTypeRepository : RailsRepository<AccountType>, IAccountTypeRepository
    {
        public AccountTypeRepository(IRailsDataContext context)
            : base(context)
        {
            
        }
    }
}
