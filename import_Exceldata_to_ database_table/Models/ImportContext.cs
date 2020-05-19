using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace import_Exceldata_to__database_table.Models
{
    public class ImportContext:DbContext
    {
        public ImportContext(DbContextOptions<ImportContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
