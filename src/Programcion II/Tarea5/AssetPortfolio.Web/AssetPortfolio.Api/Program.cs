using DentalClinic.Domain;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowOriginForm",
        policy =>
        {
            policy.WithOrigins("https://localhost:7071")
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});

builder.Services.AddDbContext<DentalClinicWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AssetPortfolioWebContext") ?? throw new InvalidOperationException("Connection string 'AssetPortfolioWebContext' not found.")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();
app.UseCors("AllowOriginForm");
app.Run();
