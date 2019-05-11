using System.Data.Entity;
using SelimLibrary.Data.Entities;
using SelimLibrary.Data.Configs;

namespace SelimLibrary.Data
{
    public class SelimLibraryDataContext :DbContext
    {
        public SelimLibraryDataContext(): base("SelimLibraryData")
        {

        }

        public virtual DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberConfig());

            //base.OnModelCreating(modelBuilder);
        }
    }
}
