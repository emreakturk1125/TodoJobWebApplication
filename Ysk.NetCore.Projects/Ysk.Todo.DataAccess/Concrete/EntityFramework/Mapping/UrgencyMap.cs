using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UrgencyMap : IEntityTypeConfiguration<Urgency>
    {
        public void Configure(EntityTypeBuilder<Urgency> builder)
        {
            builder.Property(x => x.Description).HasMaxLength(100); 
             
        }
    }
}
