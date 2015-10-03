using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace InvoiceSample
{
    [DependsOn(typeof(InvoiceSampleCoreModule), typeof(AbpAutoMapperModule))]
    public class InvoiceSampleApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
