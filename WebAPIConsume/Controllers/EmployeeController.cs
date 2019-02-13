using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebAPIConsume.Controllers
{
    public class EmployeeController : ApiController
    {
      
        [HttpGet]
        [Route("api/AllEmployees")]
        public IEnumerable<string> All()
        {
            return new string[] { "Waris", "Kantroo" };
        }
        [HttpGet]
        [Route("api/Employees")]
        public IEnumerable<DummyEmployee> Employees()
        {
            return new List<DummyEmployee>()
                {
                 new DummyEmployee { Id=1, Name ="Waris",Town="Tral"},
                 new DummyEmployee { Id = 2, Name = "Kantroo", Town = "Tral" },
                };
        }

        [HttpPost]
        [Route("api/add")]
        public DummyEmployee AddEmployee(DummyEmployee employee)
        {
            DummyEmployee d = new DummyEmployee();
            d.Id = employee.Id;
            d.Name = employee.Name;
            d.Town = employee.Town;
            return d;
        }
    }

   

    public class DummyEmployee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Town { get; set; }
    }

}
