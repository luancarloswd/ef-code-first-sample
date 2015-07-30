using System.Data.Entity.ModelConfiguration;
using ef_code_first_sample.Models;

namespace CodeFirstSampleEF.Mappings
{
    class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable("Book");

            HasKey(x => x.Id);

            Property(x => x.Title)
                .HasMaxLength(80)
                .IsRequired();

            HasMany(x => x.Authors);

            HasRequired(x => x.Authors);

        }
    }
}
