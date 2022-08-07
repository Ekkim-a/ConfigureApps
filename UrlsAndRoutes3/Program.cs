var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

builder.Services.AddMvc()
    .AddMvcOptions(options => options.EnableEndpointRouting = false); //for working line app.UseMvc();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvc();
