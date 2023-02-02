using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Session_19_InClass.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase {

        [HttpGet(Name = "GetPerson")]
        public Person Get() {


            Person person = new Person();
            person.Name = "fotis";

            return person;

        }
    }
}