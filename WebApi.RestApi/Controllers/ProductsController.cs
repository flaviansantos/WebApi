using Microsoft.AspNetCore.Mvc;
using WebApi.Application.Dtos;
using WebApi.Application.Interface;

namespace WebApi.RestApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IApplicationServiceProduct applicationServiceProduct;

        public ProdutosController(IApplicationServiceProduct applicationServiceProduct)
        {
            this.applicationServiceProduct = applicationServiceProduct;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceProduct.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceProduct.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProductDto productDTO)
        {
            try
            {
                if (productDTO == null)
                    return NotFound();


                applicationServiceProduct.Add(productDTO);
                return Ok("The product has been registered successfully");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProductDto productDTO)
        {

            try
            {
                if (productDTO == null)
                    return NotFound();

                applicationServiceProduct.Update(productDTO);
                return Ok("The product has been updated successfully!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProductDto productDTO)
        {
            try
            {
                if (productDTO == null)
                    return NotFound();

                applicationServiceProduct.Remove(productDTO);
                return Ok("The product has been removed successfully!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
