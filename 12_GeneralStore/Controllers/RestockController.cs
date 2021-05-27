﻿using _12_GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _12_GeneralStore.Controllers
{
    public class RestockController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public async Task<IHttpActionResult> Restock([FromUri] int id, [FromBody] Restock restock)
        {
            if (ModelState.IsValid)
            {
                Product product = await _context.Products.FindAsync(id);
                if (product != null)
                {
                    product.Quantity += restock.NewStock;
                    await _context.SaveChangesAsync();
                    return Ok();
                }
                return NotFound();
            }
            return BadRequest(ModelState);
        }
    }
}
