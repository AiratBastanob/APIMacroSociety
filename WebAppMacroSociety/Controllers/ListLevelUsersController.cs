using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppMacroSociety.Models;

namespace WebAppMacroSociety.Controllers
{
    [ApiController]
    [Route("api/game")]
    public class ListLevelUsersController : Controller
    {
        private readonly MacroSocietyContext _context;

        public ListLevelUsersController(MacroSocietyContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<ListLevelUser> GetInfoGame(string name)
        {
            ListLevelUser ListLevelUser = _context.ListLevelUsers.FirstOrDefault(listLevelUser => listLevelUser.NameUser == name);
            if (ListLevelUser == null)
                return NotFound();
            return Ok(ListLevelUser);
        }
        [HttpPut]
        public int Put(ListLevelUser ListLevelUser)
        {
            int result = 0;
            if (ListLevelUser == null)
            {
                return result;
            }
            _context.Update(ListLevelUser);
            result = _context.SaveChanges();
            return result;
        }
    }
}