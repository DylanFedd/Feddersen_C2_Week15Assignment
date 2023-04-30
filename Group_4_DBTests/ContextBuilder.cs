using Group_4_DB.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_4_DBTests
{
    internal class ContextBuilder
    {
        public static academic_settingsContext CreateContext()
        {
            var connectionstring = "Data Source=DylanPC;Initial Catalog=academic_settings;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            var optionsBuilder = new DbContextOptionsBuilder<academic_settingsContext>();
            optionsBuilder.UseSqlServer(connectionstring);

            return new academic_settingsContext(optionsBuilder.Options);
        }
    }
}
