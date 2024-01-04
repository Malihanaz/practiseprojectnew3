using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppRainbowSchooldb.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TeacherContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TeacherContext") ?? throw new InvalidOperationException("Connection string 'TeacherContext' not found.")));
builder.Services.AddDbContext<SubjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SubjectContext") ?? throw new InvalidOperationException("Connection string 'SubjectContext' not found.")));
builder.Services.AddDbContext<StudentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentContext") ?? throw new InvalidOperationException("Connection string 'StudentContext' not found.")));
builder.Services.AddDbContext<MarksContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MarksContext") ?? throw new InvalidOperationException("Connection string 'MarksContext' not found.")));

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

app.MapControllers();

app.Run();
