using LoanManagement.Backend.Data;
using LoanManagement.Backend.Models;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoanManagement.Backend.Controllers
{
    [RoutePrefix("api/Clients")]
    public class ClientController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpPost]
        [Route("AddClient")]
        public HttpResponseMessage AddClient([FromBody]BankClient newClient)
        {
            var response = new object();

            try
            {
                BankClient client = new BankClient();

                client = newClient;

                db.BankClient.Add(client);
                db.SaveChanges();

                response = new { Error = false };
                return Request.CreateResponse(HttpStatusCode.OK, client, Configuration.Formatters.JsonFormatter);
            }
            catch (Exception)
            {
                response = new { Error = true };
                return Request.CreateResponse(HttpStatusCode.OK, response, Configuration.Formatters.JsonFormatter);
            }
        }

        [HttpGet]
        [Route("SearchClient")]
        public HttpResponseMessage SearchClient(int docNumber)
        {
            var response = new object();

            try
            {
                //db.BankClient.Find();
                var client = db.BankClient.Where(x => x.DocNumber == docNumber);

                response = new { Error = false };
                return Request.CreateResponse(HttpStatusCode.OK, client, Configuration.Formatters.JsonFormatter);
            }
            catch (Exception ex)
            {
                response = new { Error = true };
                return Request.CreateResponse(HttpStatusCode.OK, ex, Configuration.Formatters.JsonFormatter);
            }
        }
    }
}
