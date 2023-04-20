using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using EFReletionships.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

string efrRelationshipURL = builder.Configuration["EFRelationship:EFRelationshipURL"];
string tenantId = builder.Configuration["EFRelationship:TenatId"];
string clientId = builder.Configuration["EFRelationship:ClientId"];
string clientSecret = builder.Configuration["EFRelationship:ClientSecretId"];

var credentials = new ClientSecretCredential(tenantId, clientId, clientSecret);
var client = new SecretClient(new Uri(efrRelationshipURL), credentials);

builder.Configuration.AddAzureKeyVault(client, new AzureKeyVaultConfigurationOptions());

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("EFRelationship")));

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

app.Run();
