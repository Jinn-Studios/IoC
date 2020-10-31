namespace JinnDev.NonIOC.ConsoleApp
{
    public class Root
    {
        public static T GetService<T>()
        {
            if (typeof(T) == typeof(Data.DataRepository))
                return (T)(object)new Data.DataRepository();

            if (typeof(T) == typeof(DomainService))
                return (T)(object)new DomainService(GetService<Data.DataRepository>());

            return default(T);
        }
    }
}