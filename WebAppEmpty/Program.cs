namespace WebAppEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new instance of WebApplication
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            var app = builder.Build();

            // Add services to the container


            // Middleware is software that's assembled into an app pipeline to handle requests and responses
            // The order of middleware is important

            // Configure the HTTP request pipeline
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
