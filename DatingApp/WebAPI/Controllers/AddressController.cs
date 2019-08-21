using System;
using WebAPI.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Data.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController :ControllerBase
    {
        private readonly DataContext readContext;
        public AddressController(DataContext context)
        {
            readContext = context;
        }
        [HttpPost ("addAddress")]
        public IActionResult addAddress( Address address)
        {
            readContext.Add(address);
            readContext.SaveChanges();
            return Ok("Posted");
        }

    }
}