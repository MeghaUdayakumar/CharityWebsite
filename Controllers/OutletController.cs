using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebsiteAPI.Data;
using WebsiteAPI.Models;

namespace WebsiteAPI.Controllers
{
    //api/Outlet
    [Route("api/[Controller]")]
    [ApiController]
    public class OutletController : ControllerBase
    {
        private readonly IOutletRepo _repository;

        public OutletController(IOutletRepo repository)
        {
         _repository = repository;   
        }
        //private readonly MockOutletRepo _repository = new MockOutletRepo();
        //GET api/outlet
        [HttpGet]
        public ActionResult <IEnumerable<OutletController>> GetAllOutlets()
        {
            var OutletItems = _repository.GetAllOutlets();

            return Ok(OutletItems);
        }

        //GET api/outlet/id
        [HttpGet("{id}")]
        public ActionResult <Outlet> GetOutletById(int id)
        {
          var OutletItems = _repository.GetOutletById(id);
          return Ok(OutletItems);  
        }
    }

}