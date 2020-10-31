using JinnDev.BadIOC.Core;

namespace JinnDev.BadIOC
{
    public class IocModule
    {
        public IDomainService Resolve()
        {
            // There is no way for this to work without a reference to the Data Implementation
            // This means your Domain knows about your Data Source, 
            // breaking the rule of Persistence Ignorance.
            return new DomainService(new Data.IocModule().Resolve());
        }
    }
}