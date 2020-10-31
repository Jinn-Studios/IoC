using JinnDev.BadIOC.Data.Core;

namespace JinnDev.BadIOC.Data
{
    public class IocModule
    {
        public IDataRepository Resolve()
        {
            // This only seems acceptable compared to the Domain's "Resolve()" because it doesn't 
            // appear to have a dependency.  In reality, a Repo would have an ORM Builder or, at 
            // least, a connection string injected.  But either way, this existing here means a 
            // consumer who wants to use your interface must also know about this one implementation.
            return new DataRepository();
        }
    }
}