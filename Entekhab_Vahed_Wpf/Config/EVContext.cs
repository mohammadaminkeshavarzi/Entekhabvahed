using Entekhab_Vahed_Wpf.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entekhab_Vahed_Wpf.Config
{
    public partial class EVContext : DbContext
    {

        public virtual DbSet<ChooseUnit> ChooseUnits { get; set; }
        public virtual DbSet<Classx> Classes { get; set; }
        public virtual DbSet<Fieldx> Fields { get; set; }
        public virtual DbSet<Lessonx> Lessons { get; set; }
        public virtual DbSet<Professorx> Professors { get; set; }
        public virtual DbSet<Scorex> Scores { get; set; }
        public virtual DbSet<Studentx> Students { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=EntekhabVahedDB;Trusted_Connection=True;");
        }

    }
}
