using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander_Core_3._1_MVC_Rest_Api.Data;
using Commander_Core_3._1_MVC_Rest_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Commander_Core_3._1_MVC_Rest_Api.Controllers
{

    /// <summary>
    /// api/[controller] => default controller route (wildcard approuch)
    /// api/commander  => fixed end point dat de class gerenamed kan 
    /// worden zonder dat de route veranderd
    /// </summary>
    [Route("api/commands")]
    [ApiController]
    public class CommanderController : ControllerBase
    {
        private readonly ICommanderRepo Repository;

        public CommanderController(ICommanderRepo repository)
        {
            Repository = repository;
        }

        // Bovenstaande vervangt onderstaande regel  
        // ==> VERVANGEN private readonly MockCommanderRepo Repository = new MockCommanderRepo();

        /// <summary>
        /// GET api/commands
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var CommandItems = Repository.GetAppCommands();

            return Ok(CommandItems);
        }

        /// <summary>
        /// GET api/commands/{id}
        /// GET api/commands/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var CommandItem = Repository.GetCommandById(id);

            return Ok(CommandItem);
        }
    }
}