﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockApi.BO;
using StockApi.IServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItem _item;  
        public ItemsController(IItem item)
        {
            _item = item;
        }

        // GET: api/<ItemsController>
        [HttpGet]
        public ICollection<ItemBO> Get()
        {
            return _item.Get().ToList();
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id:string}")]
        public ItemBO Get(string id)
        {
            return _item.GetById(id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public ItemBO Post([FromBody] ItemBO item)
        {
            return _item.Create(item);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id:string}")]
        public ItemBO Put(string id, [FromBody] ItemBO item)
        {
            return _item.Update(item);
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id:string}")]
        public ItemBO Delete(string  id)
        {
            return _item.Delete(id);
        }
    }
}
