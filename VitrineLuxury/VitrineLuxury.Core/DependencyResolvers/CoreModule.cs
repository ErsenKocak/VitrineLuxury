using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Core.CrossCuttingConcerns.Caching;
using VitrineLuxury.Core.CrossCuttingConcerns.Caching.Microsoft;
using VitrineLuxury.Core.Utilities.IoC;

namespace VitrineLuxury.Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
        }
    }
}
