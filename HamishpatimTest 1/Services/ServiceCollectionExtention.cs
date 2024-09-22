using HamishpatimTest_1.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HamishpatimTest_1.Services
{
    
        public static class ServiceCollectionExtension
        {
            public static IServiceCollection AddServices(this IServiceCollection service)
            {

                service.AddRepositories();
                service.AddScoped<IService<DonationDto>, DonationService>();

                service.AddAutoMapper(typeof(MapperProfile));
                return service;
            }
        }
    }


