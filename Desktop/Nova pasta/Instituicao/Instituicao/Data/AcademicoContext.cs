using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CRUD.Data
{
    public class AcademicoContext : DbContext
    {
        public AcademicoContext(DbContextOptions<AcademicoContext> options) : base(options)
        {
        }
        public DbSet<Instituicao> ?Instituicoes { get; set; }
        public DbSet<Departamento> ?Departamento { get; set; }

    }
}
