using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Core.ApplicationService;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace UI.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetsController(IPetService petService)
        {
            _petService = petService;
        }

        // GET api/pets
        [HttpGet]
        public ActionResult<IEnumerable<Pet>> Get()
        {
            return _petService.FindAllPets();
        }

        // GET api/pets/5
        [HttpGet("{id}")]
        public ActionResult<Pet> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater than 0");

            return _petService.FindPetById(id);
        }

        // POST api/pets
        [HttpPost]
        public Pet Post([FromBody] Pet pet)
        {
            return _petService.Add(pet);
        }

        // PUT api/pets/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Pet pet)
        {
            if (id < 1 || id != pet.Id)
            {
                return BadRequest(" fejl bitch");
            }
            return Ok(_petService.UpdatePet(pet));
        }

        // DELETE api/pets/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _petService.RemovePet(id);
        
        }
    }
}
