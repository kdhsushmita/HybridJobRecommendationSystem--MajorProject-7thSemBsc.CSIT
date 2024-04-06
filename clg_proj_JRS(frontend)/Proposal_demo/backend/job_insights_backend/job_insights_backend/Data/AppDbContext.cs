using job_insights_backend.Data;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace job_insights_backend.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    //This is the constructor for the AppDbContext class.
    //It takes an instance of DbContextOptions<AppDbContext> as a parameter. 
    //It's responsible for configuring the database connection and other options for the context.
    {
    }
    //These lines define properties of type DbSet<T>.Each property correspond 
    //to a database table(or entity set) that you want to interact with using Entity Framework Core.
    public DbSet<Job?> Jobs { get; set; }
    //Job is nullable that means it allows null values for the Job entity
    public DbSet<Company> Companies { get; set; }
    public DbSet<Category> Categories { get; set; }
    //These properties are used by Entity Framework Core to map to and interact with database tables.
    //Entity Framework Core will create SQL queries and commands to perform CRUD (Create, Read, Update, Delete)
    //operations on these tables based on the defined model classes
}


//The Provided code defines a class named AppDbContext,
//which is a part of Entity Framework Core, used for database access in ASP.NET Core applications. 
//It specifies how the application interacts with the database by defining a data context class. 

//In summary, the AppDbContext class is used to define the database context for your ASP.NET Core application.
//It specifies the database tables (represented by DbSet properties) that your application can interact with and 
//is responsible for configuring the database connection and other options. 
//Entity Framework Core uses this context to perform database operations based on your model classes and 
//the database schema.