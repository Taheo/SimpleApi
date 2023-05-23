using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public PersonController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet]
        [Route("GetPersons")]
        public async Task<List<Person>> Get()
        {
            return await _dataContext.Persons.ToListAsync();
        }

        [HttpGet]
        [Route("AddPerson")]
        public async Task<List<Person>> Add()
        {
            _dataContext.Persons.Add(new Person());
            await _dataContext.SaveChangesAsync();
            return await _dataContext.Persons.ToListAsync();
        }
    }
}
