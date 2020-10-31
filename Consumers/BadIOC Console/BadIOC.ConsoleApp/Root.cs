namespace JinnDev.BadIOC.ConsoleApp
{
    public class Root
    {
        public static T GetService<T>()
        {
            // One option is to use the Resolve().  After all, that's why the Module was created in the Domain!
            // An issue here is that now this entire Entry-Point project has no clue where the Repo is being
            // used.  So, in a large system, when somebody wants to trace through the system to see where 
            // things are being used; Instead of just being able to look at the Composition Root, they have
            // to literally search every single file of every project to find all of the Resolvers and see.
            if (typeof(T) == typeof(Core.IDomainService))
                return (T)(object)new IocModule().Resolve();

            // Also, if there is an issue resolving anything, you'll get a Runtime exception instead of a Compile Exception

            // Also also, if there is an update to the implementation, EVERYTHING that uses this "Resolve" pattern,
            // (which also means those interface consumers also have knowledge of the implementation), must ALL be updated
            // and re-published.  Instead of only the Composition Root.

            return default(T);
        }
    }
}