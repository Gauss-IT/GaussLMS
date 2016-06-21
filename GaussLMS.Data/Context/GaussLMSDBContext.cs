using System.Data.Entity;
using GaussLMS.Data.Madrasah;

namespace GaussLMS.Data.Context
{
    class GaussLMSDBContext : DbContext
    {

        public GaussLMSDBContext()
                : base("GaussLMS.Data.DbConnection")
            {
                Database.SetInitializer<GaussLMSDBContext>(new GaussLMSInitializer());
                Configuration.ProxyCreationEnabled = false;
            }

        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        }
}
