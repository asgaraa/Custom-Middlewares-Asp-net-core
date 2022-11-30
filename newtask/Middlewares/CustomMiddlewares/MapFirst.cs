namespace Middlewares.CustomMiddlewares
{
    
        public class MapFirst
        {
            private readonly IApplicationBuilder _app;

            public MapFirst(IApplicationBuilder app)
            {
                _app = app;
            }
            public static void Configure(IApplicationBuilder app)
            {
                app.Run(async context =>
                {
                    await context.Response.WriteAsync("Middleware Test 1");
                });
            }
        }
    

}
