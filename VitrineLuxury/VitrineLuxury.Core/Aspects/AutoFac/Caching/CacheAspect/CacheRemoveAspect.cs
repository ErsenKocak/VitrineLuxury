using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VitrineLuxury.Core.CrossCuttingConcerns.Caching;
using VitrineLuxury.Core.Utilities.Interceptors;
using VitrineLuxury.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace VitrineLuxury.Core.Aspects.AutoFac.Caching.CacheAspect
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
           
           
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}
