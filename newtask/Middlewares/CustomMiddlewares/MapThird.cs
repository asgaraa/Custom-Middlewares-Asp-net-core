namespace Middlewares.CustomMiddlewares
{
    public class MapThird
    {
        private readonly IApplicationBuilder _app;

        public MapThird(IApplicationBuilder app)
        {
            _app = app;
        }
        public static void Configure(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Middleware Test 3");
            });
        }
    }
}
