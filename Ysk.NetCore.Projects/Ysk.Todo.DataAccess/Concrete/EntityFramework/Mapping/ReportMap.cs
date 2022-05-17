using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ysk.Todo.Entities.Concrete;

namespace Ysk.Todo.DataAccess.Concrete.EntityFramework.Mapping
{
    public class ReportMap : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Detail).HasColumnType("ntext");

            builder.HasOne(x => x.Task).WithMany(x => x.Reports).HasForeignKey(x => x.TaskId);

        }
    }
}
