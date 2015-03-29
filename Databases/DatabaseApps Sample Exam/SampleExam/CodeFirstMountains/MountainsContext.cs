namespace CodeFirstMountains
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MountainsContext : DbContext
    {
        // Your context has been configured to use a 'MountainsContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirstMountains.MountainsContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MountainsContext' 
        // connection string in the application configuration file.
        public MountainsContext()
            : base("name=MountainsContext")
        {
        }
        
         public virtual DbSet<Country> Countries { get; set; }

         public virtual DbSet<Mountain> Mountains { get; set; }

         public virtual DbSet<Peak> Peaks { get; set; }

    }

    
}