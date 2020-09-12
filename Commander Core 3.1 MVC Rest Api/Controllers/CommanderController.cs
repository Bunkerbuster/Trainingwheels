using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Commander_Core_3._1_MVC_Rest_Api.Data;
using Commander_Core_3._1_MVC_Rest_Api.Dtos;
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
        private readonly IMapper Mapper;

        public CommanderController(ICommanderRepo repository, IMapper mapper)
        {
            Repository = repository;
            Mapper = mapper;
        }

        // Bovenstaande vervangt onderstaande regel  
        // ==> VERVANGEN private readonly MockCommanderRepo Repository = new MockCommanderRepo();

        /// <summary>
        /// GET api/commands
        /// 
        /// use CommandReadDTO instead of the Command to return your data,
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var CommandItems = Repository.GetAllCommands();

            return Ok(Mapper.Map<IEnumerable<CommandReadDto>>(CommandItems));
        }

        /// <summary>
        /// GET api/commands/{id}
        /// GET api/commands/5
        /// https://localhost:5001/api/Commands/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {

            var CommandItem = Repository.GetCommandById(id);

            if(CommandItem!= null)
            {
                return Ok(Mapper.Map<CommandReadDto>(CommandItem));
            }
            return NotFound();
        }
    }
}