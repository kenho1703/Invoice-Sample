using System.Data.Entity.Migrations;
using InvoiceSample.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace InvoiceSample.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<InvoiceSample.EntityFramework.InvoiceSampleDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "InvoiceSample";
        }

        protected override void Seed(InvoiceSample.EntityFramework.InvoiceSampleDbContext context)
        {
            context.DisableAllFilters();
            new InitialDataBuilder(context).Build();
        }
    }
}
