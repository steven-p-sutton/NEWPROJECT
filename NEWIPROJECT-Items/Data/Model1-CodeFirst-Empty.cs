using System;
using System.Data.Entity;
using System.Linq;

namespace NEWIPROJECT_Items.Data
{
    public class Model1_CodeFirst_Empty : DbContext
    {
        // Your context has been configured to use a 'Model1_CodeFirst_Empty' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'NEWIPROJECT_Items.Data.Model1_CodeFirst_Empty' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1_CodeFirst_Empty' 
        // connection string in the application configuration file.
        public Model1_CodeFirst_Empty()
            : base("name=Model1-CodeFirst-Empty")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}