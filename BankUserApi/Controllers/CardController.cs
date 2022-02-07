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
    public class CardController : BaseApiController
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok(await app.Cards
                .Include(b=>b.Bank)
                .ToListAsync());
        }

        [HttpPost]

        public async Task<IActionResult> Create(CardDto dto)
        {
            if (ModelState.IsValid)
            {
                app.Cards.Add(mapper.Map<Card>(dto));
               
                await app.SaveChangesAsync();
                return Ok(dto);
            }





     
            return NotFound();

        }
        [HttpPut("{id}")]

        public async Task<IActionResult> Edit(int id, CardDto dto)
        {
            var data = await app.Cards.FirstOrDefaultAsync(b => b.Id == id);
            if (data == null) return NotFound();



            app.Cards.Update(mapper.Map(dto, data));
            await app.SaveChangesAsync();
            return Ok(data);



        }


        [HttpDelete("{id}")]


        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var data = await app.Cards.FirstOrDefaultAsync(b => b.Id == id);
            if (data == null) return NotFound();
            app.Cards.Remove(data);
            await app.SaveChangesAsync();


            return Ok();
        }

        [HttpGet("{id}")] //biz heqiqeten idni gozluyuruk teleb edirik 
        public async Task<IActionResult> Details(int id)
        {
            Card blog = await app.Cards
                .Include(b=>b.Bank)
                .FirstOrDefaultAsync(b => b.Id == id);     //detallisina baxmaq idsine gore
            if (blog == null) return NotFound(StatusCodes.Status404NotFound);
            return Ok(blog);
        }

    }
}
