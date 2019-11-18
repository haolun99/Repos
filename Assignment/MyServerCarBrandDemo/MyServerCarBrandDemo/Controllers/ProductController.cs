using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Handlers;
using Newtonsoft.Json;
using MyServerCarBrandDemo.Models;

namespace MyServerCarBrandDemo.Controllers
{
    [RoutePrefix("api/CarBrands")]
    public class ProductController : ApiController
    {
        private myDBEntities MyDBEntities = new myDBEntities();

        [HttpGet]
        [Route("findAll")]
        public HttpResponseMessage findAll()
        
        {
            try
            {
                var result = new HttpResponseMessage(HttpStatusCode.OK);
                result.Content = new StringContent(JsonConvert.SerializeObject(MyDBEntities.CarBrands.ToList()));
               result.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                return result;
            }
            catch(Exception e) // add something inside (), otherwise meanless 
            {
                var result = new HttpResponseMessage(HttpStatusCode.BadRequest);
                result.Content = new StringContent(e.Message.ToString());
                return result;
            }
        }
    }
}
