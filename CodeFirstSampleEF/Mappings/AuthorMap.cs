using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ef_code_first_sample.Models;

namespace CodeFirstSampleEF.Mappings
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable("Author");

            HasKey(x => x.Id);

            Property(x => x.Name)
                .HasMaxLength(80)
                .IsRequired();

            HasMany(x => x.Books)
                .WithMany(x => x.Authors)
                .Map(x => ToTable("BookAuthor"));

        }
    }
}
