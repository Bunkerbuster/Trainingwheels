using Commander_Core_3._1_MVC_Rest_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander_Core_3._1_MVC_Rest_Api.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext Context;

        public SqlCommanderRepo(CommanderContext DBContext)
        {
            Context = DBContext;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return Context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return Context.Commands.FirstOrDefault(c => c.Id == id);
        }
    }
}
