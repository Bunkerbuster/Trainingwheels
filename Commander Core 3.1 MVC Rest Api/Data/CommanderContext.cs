using Commander_Core_3._1_MVC_Rest_Api.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;

namespace Commander_Core_3._1_MVC_Rest_Api.Data
{
    public class CommanderContext : DbContext
    {

        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }

    }
}
