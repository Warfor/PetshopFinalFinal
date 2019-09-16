using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.ApplicationService;
using Entity;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace UI.RestApi.Controllers
{
    public class OwnersController : ControllerBase
    {
        private readonly IOwnerService _OwnerService;

        public OwnersController(IOwnerService ownerService)
        {
            _OwnerService = ownerService;
        }

        // GET api/owners
        [HttpGet]
        public ActionResult<IEnumerable<Owner>> Get()
        {
            return _OwnerService.ReadAll().ToList();
        }

        // GET api/owners/5
        [HttpGet("{id}")]
        public ActionResult<Owner> Get(int id)
        {
            if (id < 1) return BadRequest("Id must be greater than 0");

            return _OwnerService.FindOwnerById(id);
        }

        // POST api/owners
        [HttpPost]
        public Owner Post([FromBody] Owner owner)
        {
            return _OwnerService.CreateOwner(owner);
        }

        // PUT api/owners/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Owner owner)
        {
            if (id < 1 || id != owner.id)
         
           _OwnerService.UpdateOwner(owner);
        }

        // DELETE api/owners/5
        [HttpDelete("{id}")]
        public void Delete(Owner owner)
        {
            _OwnerService.RemoveOwner(owner);

        }
    }
}
