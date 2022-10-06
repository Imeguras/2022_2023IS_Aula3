using ProductsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using ProductsAPI.DAL.Products;

namespace ProductsAPI.Controllers{
	[Route("api/[controller]")]
	[ApiController]
    public class ProductsController : ControllerBase{
		private InheritanceMappingContext _context;
		public ProductsController(InheritanceMappingContext context){
			_context = context;
		}

		[HttpGet("products")]
		public IActionResult GetProducts(){
			//Console.Write("fuck");
			//fetch data from db
			
			return Ok(_context.Products.ToList());
		}
		[HttpGet("product/{id}")]
		public IActionResult GetProduct(int id){
			var ret = _context.Products.Where(p => p.Id == id);
			if(ret.Count() == 0 || ret.First().Id != id){
				return NotFound("No such product dingus");
			}
			return Ok(ret);
			//Respecting HTTP errors (200 OK)}
		}
	}
}
