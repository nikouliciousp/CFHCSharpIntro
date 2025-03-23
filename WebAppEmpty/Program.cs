namespace WebAppEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new host builder
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .Build()
                .Run();

            Console.WriteLine("Thanks for usinig our app!!");
        }
    }
}
