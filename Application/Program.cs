var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseExceptionHandler()
    .UseCors(c =>
    {
        c.AllowCredentials();
        c.AllowAnyHeader();
        c.AllowAnyMethod();
    })
    .UseSwagger()
    .UseSwaggerUI();