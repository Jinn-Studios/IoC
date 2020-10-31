namespace JinnDev.IOC.ConsoleApp
{
    public class Root
    {
        public static T GetService<T>()
        {
            if (typeof(T) == typeof(Data.Core.IDataRepository))
                return (T)(object)new Data.DataRepository();

            if (typeof(T) == typeof(Core.IDomainService))
                return (T)(object)new DomainService(GetService<Data.Core.IDataRepository>());

            return default(T);
        }
    }
}