using LoanManagement.Backend.Data;
using LoanManagement.Backend.Models;
using System;
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
                request = newRequest;

                db.CreditRequest.Add(request);
                db.SaveChanges();

                response = new { Error = false };
                return Request.CreateResponse(HttpStatusCode.OK, request, Configuration.Formatters.JsonFormatter);
            }
            catch (Exception ex)
            {
                response = new { Error = true };
                return Request.CreateResponse(HttpStatusCode.OK, ex, Configuration.Formatters.JsonFormatter);
            }
        }
    }
}