using KeyedServiceRegistration;

var builder = WebApplication.CreateBuilder(args);

/** HERE ---> **/
builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>();
builder.Services.AddKeyedScoped<INotificationService, MailNotificationService>("mail");
builder.Services.AddKeyedScoped<INotificationService, PhoneNotificationService>("phone");
builder.Services.AddKeyedScoped<INotificationService, PushNotificationService>("push");
/** HERE <--- **/

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", (IShoppingCartService shoppingCartService) => shoppingCartService.ClearCart())
    .WithName("phoneClearNotification")
    .WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}