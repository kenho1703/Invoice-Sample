using InvoiceSample.EntityFramework;

namespace InvoiceSample.Migrations.SeedData
{
    public class InitialDataBuilder
    {
        private readonly InvoiceSampleDbContext _context;

        public InitialDataBuilder(InvoiceSampleDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            new DefaultTenantRoleAndUserBuilder(_context).Build();
        }
    }
}
