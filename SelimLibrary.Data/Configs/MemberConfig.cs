using System.Data.Entity.ModelConfiguration;
using SelimLibrary.Data.Entities;

namespace SelimLibrary.Data.Configs
{
    public class MemberConfig : EntityTypeConfiguration<Member>
    {
        public MemberConfig()
        {
            ToTable("members");
            HasKey(a => a.Id);
            Property(a => a.FirstName).HasColumnName("FirstName");
            Property(a => a.LastName).HasColumnName("LastName");
            Property(a => a.Username).HasColumnName("Username");
            Property(a => a.Password).HasColumnName("Password");
            Property(a => a.Email).HasColumnName("Email");
        }
    }
}
