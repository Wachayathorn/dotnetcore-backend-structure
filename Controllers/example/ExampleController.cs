using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnetcore_backend_structure.Controllers.example
{
    public class ExampleController : Controller
    {
        [HttpGet]
        public Task<ActionResult> get()
        {
            
        }
    }
}
