namespace JinnDev.SingularIOC.ConsoleApp
{
    public class Root
    {
        public static T GetService<T>()
        {
            if (typeof(T) == typeof(Data.Core.ISingularRepo))
                return (T)(object)new Data.SingularRepo();

            if (typeof(T) == typeof(Core.ISingularService))
                return (T)(object)new SingularService(GetService<Data.Core.ISingularRepo>());

            return default(T);
        }
    }
}