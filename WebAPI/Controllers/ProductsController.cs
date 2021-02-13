using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]       //ATTRIBUTE(klasla ilgili bilgi verme, imzalama) - java(Annotation)
    public class ProductsController : ControllerBase
    {
        //Loosely coupled (gevşek bağlılık)
        //naming convetion (_..)
        //IoC Container--Inversion of Control(Değişimin kontrolü)
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Gett()
        {
            var result = _productService.GetAll();
            return result.Data;
    
        }
       
        
    }
}
