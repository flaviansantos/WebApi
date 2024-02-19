using Microsoft.AspNetCore.Mvc;
using WebApi.Application.Dtos;
using WebApi.Application.Interface;

namespace WebApi.RestApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IApplicationServiceClient applicationServiceClient;

        public ClientsController(IApplicationServiceClient applicationServiceClient)
        {
            this.applicationServiceClient = applicationServiceClient;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceClient.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceClient.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ClientDto clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Add(clientDTO);
                return Ok("Client Registered Successfully!");
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClientDto clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Update(clientDTO);
                return Ok("Client Updated Successfully!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClientDto clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Remove(clientDTO);
                return Ok("Client Removed Successfully!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
