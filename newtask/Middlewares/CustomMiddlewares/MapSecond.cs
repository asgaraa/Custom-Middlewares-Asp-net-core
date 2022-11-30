namespace Middlewares.CustomMiddlewares
{
    public class MapSecond
    {
        private readonly IApplicationBuilder _app;

        public MapSecond(IApplicationBuilder app)
        {
            _app = app;
        }
        public static void Configure(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Middleware Test 2");
            });
        }
    }
}
