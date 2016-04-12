using System.Collections.Generic;
using System.Linq;
using CTRails.Data;
using CTRails.Entities;
using CTRails.Entities.Employees;


namespace CTRails.Repositories
{
    public class AccountTypeRepository : Repository<AccountType>, IAccountTypeRepository
    {

        public IRailsDataContext Context { get; set; }

        public AccountTypeRepository(IRailsDataContext context)
            : base(context)
        {
            Context = context;
        }

    }
}
