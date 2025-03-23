namespace WebAppEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                // HTTP Strict Transport Security (HSTS) is a web security policy mechanism that helps to protect websites
                app.UseHsts();
            }

            // Redirects all HTTP requests to HTTPS
            app.UseHttpsRedirection();

            app.MapGet("/", () => "Hello World!");

            app.Run();

            Console.WriteLine("Thanks for usinig our app!!");
        }
    }
}
