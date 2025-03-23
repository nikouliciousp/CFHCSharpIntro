namespace WebAppEmpty
{
    public class Startup
    {
        // ... other code ...

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // If the environment is development, use the developer exception page
            if (env.IsDevelopment())
            {
                // Use the developer exception page
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Use the exception handler page
                app.UseExceptionHandler("/Home/Error");
                // Use the HSTS
                app.UseHsts();
            }

            app.UseRouting();
            app.UseHttpsRedirection();

            // Use endpoint routing
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
