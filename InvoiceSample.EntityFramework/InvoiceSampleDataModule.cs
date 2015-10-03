using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using InvoiceSample.EntityFramework;

namespace InvoiceSample
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(InvoiceSampleCoreModule))]
    public class InvoiceSampleDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
