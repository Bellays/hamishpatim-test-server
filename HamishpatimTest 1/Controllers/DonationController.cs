using HamishpatimTest_1;
using Microsoft.AspNetCore.Mvc;



namespace HamishpatimTest_1.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
    public class DonationController : ControllerBase
    {
        private readonly IService<DonationDto> service;
            public DonationController(IService<DonationDto> service)
            {
                this.service = service;
            }

            [HttpGet]
            public List<DonationDto> Get()
            {
                return service.GetAll();
            }

            [HttpGet("{id}")]
            public DonationDto Get(int id)
            {
                return service.GetById(id);
            }

            [HttpPost]
            public void Post([FromBody] DonationDto donation)
            {
                service.AddItem(donation);
            }

            [HttpPut("{id}")]
            public void Put(int id, [FromBody] DonationDto donation)
            {
                service.UpdateItem(id, donation);
            }

            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                service.DeleteItem(id);
            }
        }
    
}





