
using HamishpatimTest_1.Models;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamishpatimTest_1.Repositories
{

        public static class ServiceCollectionExtension
        {
            public static IServiceCollection AddRepositories(this IServiceCollection service)
            {

                service.AddScoped<IRepository<Donation>, DonationRepository>();
                return service;
            }
        }
    }
