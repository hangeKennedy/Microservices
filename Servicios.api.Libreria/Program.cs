using Servicios.api.Libreria.Core;
using Servicios.api.Libreria.Core.ContextMongoDB;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// para conectarse  a mongoDB
builder.Services.Configure<MongoSettings>(options =>
{
    builder.Configuration.GetSection("MongoDB").Bind(options);
});

builder.Services.AddSingleton<MongoSettings>();
builder.Services.AddTransient<IAutorContext, AutorContext>();
//

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
