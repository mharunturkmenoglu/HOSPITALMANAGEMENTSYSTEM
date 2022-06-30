using HospitalManagementSystem.Data.Abstract;
using HospitalManagementSystem.Data.Concrete.EntityFramework;
using HospitalManagementSystem.Data.Concrete.EntityFramework.Contexts;
using HospitalManagementSystem.Services.Abstract;
using HospitalManagementSystem.Services.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("LocalDB");
builder.Services.AddDbContext<Context>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IDoctorService, DoctorManager > ();
builder.Services.AddScoped<IPatientService, PatientManager>();
builder.Services.AddScoped<IAppointmentService, AppointmentManager>();


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
