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
    [Route("api/music")]
    public class ListMusicUsersController : Controller
    {
        private readonly MacroSocietyContext _context;

        public ListMusicUsersController(MacroSocietyContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public ActionResult<ListMusicUser> GetInfoMusic(string name)
        {
            ListMusicUser ListMusicUser = _context.ListMusicUsers.FirstOrDefault(listMusicUser => listMusicUser.NameUser == name);
            if (ListMusicUser == null)
                return NotFound();
            return Ok(ListMusicUser);
        }
        [HttpPut]
        public int Put(ListMusicUser ListMusicUser)
        {
            int result = 0;
            if (ListMusicUser == null)
            {
                return result;
            }
            _context.Update(ListMusicUser);
            result = _context.SaveChanges();
            return result;
        }
    }
}