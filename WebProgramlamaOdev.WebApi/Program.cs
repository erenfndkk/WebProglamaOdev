using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using WebProgramlamaOdev.BusinessLayer.Abstract;
using WebProgramlamaOdev.BusinessLayer.Concreate;
using WebProgramlamaOdev.DataAccessLayer.Abstract;
using WebProgramlamaOdev.DataAccessLayer.Concreate;
using WebProgramlamaOdev.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IDepartmentDal, EfDepartmentDal>();
builder.Services.AddScoped<IDepartmentService, DepartmentManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<IHomeDal, EfHomeDal>();
builder.Services.AddScoped<IHomeService, HomeManager>();


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
