namespace JinnDev.NonIOC.ConsoleApp
{
    class Program
    {
        // This is an "Entry Point", which could be an Event, API Endpoint, or Main()
        static void Main()
        {
            // The "Entry Point" gets a Service from the "Composition Root"
            var service = Root.GetService<DomainService>();

            // The "Entry Point" uses the Service to Command or Query
            var result = service.GetValue(1);

            // Output for fun:
            System.Console.WriteLine(result.Value);
            System.Console.ReadKey();
        }
    }
}