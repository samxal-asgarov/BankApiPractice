using BankUserApi.Models;
using BankUserApi.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankUserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await app.Users

                .Include(c => c.Cards)
                .ThenInclude(c => c.Bank)
                .ToListAsync()); 
        }

        [HttpGet("{id}")] //biz heqiqeten idni gozluyuruk teleb edirik 
        public async Task<IActionResult> Details(int id)
        {
            User blog = await app.Users.Include(c => c.Cards)
                .ThenInclude(c => c.Bank).FirstOrDefaultAsync(b => b.Id == id);     //detallisina baxmaq idsine gore
            if (blog == null) return NotFound(StatusCodes.Status404NotFound);
            return Ok(blog);
        }
        [HttpPost]

        public async Task<IActionResult> Create(UserDto dto)
        {
            if (ModelState.IsValid)
            {
                app.Users.Add(mapper.Map<User>(dto));
                await app.SaveChangesAsync();
                return Ok(dto);
            }
            return NotFound();
        }
        [HttpPut("{id}")]

        public async Task<IActionResult> Edit(int id, UserDto dto)
        {
            var data = await app.Users.FirstOrDefaultAsync(b => b.Id == id);
            if (data == null) return NotFound();



            app.Users.Update(mapper.Map(dto, data));
            await app.SaveChangesAsync();
            return Ok(data);



        }


        [HttpDelete("{id}")]


        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var data = await app.Users.FirstOrDefaultAsync(b => b.Id == id);
            if (data == null) return NotFound();
            app.Users.Remove(data);
            await app.SaveChangesAsync();


            return Ok();
        }






    }
}
