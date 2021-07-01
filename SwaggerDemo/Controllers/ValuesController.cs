using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Web.Http;

namespace SwaggerDemo.Controllers
{
    /// <summary>
    /// value API
    /// </summary>
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        /// <summary>
        /// get方法测试
        /// </summary>
        /// <param name="id">测试id</param>
        /// <returns></returns>
        public HttpResponseMessage Get(int id)
        {
            var response = new ResponseMessage { Message = "hello", Code = "xxx" };
            var json = JsonConvert.SerializeObject(response);
            return Request.CreateResponse(response);
        }

        // POST api/values
        /// <summary>
        /// post方法测试
        /// </summary>
        /// <param name="value">测试value值</param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Post([FromBody]string value)
        {
            var response = new ResponseMessage { Message = "hello", Code = "xxx" };
            var json = JsonConvert.SerializeObject(response);
            return Request.CreateResponse(new Docs { First_Name= "vals", LastName = "chris", Message = "hello",Code = "yyy" });
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class ResponseMessage
    {
        public string Message { get; set; }

        public string Code { get; set; }
    }

    public class Docs : ResponseMessage
    {
        public string First_Name { get; set; }
        public string LastName { get; set; }
    }
}
