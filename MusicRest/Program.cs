using MusicRest;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options => 
{
    options.AddPolicy(name: "AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});


builder.Services.AddControllers();
builder.Services.AddSingleton<RecordsRepositoryList>(new RecordsRepositoryList()); // opretter ny instans af WoodPelletRepository for at kunne bruge den i controllers



// Add services to the container.

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

app.UseAuthorization();
app.UseCors("AllowAll"); // Bruger cors

app.MapControllers();

app.Run();
