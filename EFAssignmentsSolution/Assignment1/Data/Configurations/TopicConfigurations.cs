using Assignment1.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Data.Configurations
{
    internal class TopicConfigurations : IEntityTypeConfiguration<Topic>
    {
        void IEntityTypeConfiguration<Topic>.Configure(EntityTypeBuilder<Topic> builder)
        {

            builder.HasKey(T => new { T.Id });
        }
    }
}
