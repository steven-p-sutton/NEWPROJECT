using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NEWIPROJECT_Items.Data
{
    public partial class Model1_CodeFirst_Database : DbContext
    {
        public Model1_CodeFirst_Database()
            : base("name=Model1_CodeFirst_Database")
        {
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
