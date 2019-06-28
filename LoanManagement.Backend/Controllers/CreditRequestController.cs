using LoanManagement.Backend.Data;
using LoanManagement.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoanManagement.Backend.Controllers
{
    [RoutePrefix("api/Credit")]
    public class CreditRequestController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpPost]
        [Route("SaveRequest")]
        public HttpResponseMessage SaveRequest([FromBody] CreditRequest newRequest)
        {
            var response = new object();

            try
            {
                CreditRequest request = new CreditRequest();
                newRequest = request;

                response = new { Error = false };
                return Request.CreateResponse(HttpStatusCode.OK, request, Configuration.Formatters.JsonFormatter);
            }
            catch (Exception)
            {
                response = new { Error = true };
                return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
            }
        }
    }
}