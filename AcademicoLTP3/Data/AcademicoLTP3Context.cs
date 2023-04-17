using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AcademicoLTP3.Models;

namespace AcademicoLTP3.Data
{
    public class AcademicoLTP3Context : DbContext
    {
        public AcademicoLTP3Context (DbContextOptions<AcademicoLTP3Context> options)
            : base(options)
        {
        }

        public DbSet<AcademicoLTP3.Models.Departamento> Departamento { get; set; } = default!;
    }
}
