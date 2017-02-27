using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LDSBC_IT_Website.Controllers
{
    public class ClassesController : Controller
    {
        [Route("classes/names/{id}")]
        public IActionResult Names(string id)
        {
            id = id.ToUpper();
            return View(id);
        }
    }
}
