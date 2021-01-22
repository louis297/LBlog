using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.BlogModels
{
    public class BlogDBConfiguration
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder
                .HasOne(b => b.Type)
                .WithMany();
            builder
                .HasMany(b => b.Tags)
                .WithMany(t => t.Blogs);
        }

        public void Configure(EntityTypeBuilder<BlogType> builder)
        {
            #region seed blog types
            builder.HasData(new BlogType
            {
                BlogTypeID = 1,
                BlogTypeName = "Technique"
            });
            builder.HasData(new BlogType
            {
                BlogTypeID = 2,
                BlogTypeName = "Daily Life"
            });
            builder.HasData(new BlogType
            {
                BlogTypeID = 3,
                BlogTypeName = "Faith"
            });
            builder.HasData(new BlogType
            {
                BlogTypeID = 4,
                BlogTypeName = "Music"
            });
            builder.HasData(new BlogType
            {
                BlogTypeID = 5,
                BlogTypeName = "Study"
            });
            builder.HasData(new BlogType
            {
                BlogTypeID = 6,
                BlogTypeName = "Other"
            });
            #endregion
        }
    }
}
