using DrinksMaskineREST.Repos;
using Microsoft.EntityFrameworkCore;
using Secret;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
bool useSql = true;
if (useSql)
{
    // Set up a new DbContextOptionsBuilder with the connection string from Secrets.
    var optionsBuilder = new DbContextOptionsBuilder<DrinksDBContext>();
    //Replace connectionstring with simply
    optionsBuilder.UseSqlServer(Secrets.ConnectionString);

    // Create a new instance of the CarCardsDbContext using the options from the builder.
    DrinksDBContext context = new DrinksDBContext(optionsBuilder.Options);

    // Add a singleton instance of the CarCardRepositoryDb to the container, using the context we just created.
    builder.Services.AddSingleton<IDrinkRepository>(new DrinkDBRepository(context));
}
else
{
    // Add a singleton instance of the CarCardRepositoryList to the container.
    builder.Services.AddSingleton<IDrinkRepository>(new DrinkRepository());
}


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();

app.MapControllers();

app.Run();
