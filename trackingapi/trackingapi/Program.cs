using Microsoft.EntityFrameworkCore;
using trackingapi.Data;
using trackingapi.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<IssueDbContext>(
    o => o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
//builder.Services.AddScoped<IIssueResponsitory, IssueResponsitory>();
builder.Services.AddScoped<IIssueResponsitory, IssueResponsitoryInMemory>();

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

app.Run();
