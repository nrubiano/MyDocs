using System.Data;
using System.Reflection;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using MyDocs.Application.Common.Persistence;
using MyDocs.Infrastructure.Persistence.Repositories;


namespace MyDocs.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {

            services.AddTransient<IDbConnection>(x => new SqlConnection(""));
            services.AddTransient(typeof(IGroupRepository), typeof(GroupRepository));

            return services;
        }
    }
}
