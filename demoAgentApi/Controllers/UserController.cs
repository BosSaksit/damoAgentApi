using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoAgentApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoAgentApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<User> data = new List<User>{
            new User {Id = "1",Name = "getter",Tel = "0841543232",Address = "15/78 testewsf",Idcard = "1231654868"},
             new User {Id = "2",Name = "p gotf",Tel = "094646494",Address = "12/78 gergrege",Idcard = "1644611316"},
              new User {Id = "3",Name = "bosjazz",Tel = "0972743145",Address = "1/78 fewfwe",Idcard = "1101554868"}
        };
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            return data.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<User> GetbyId(string id)
        {
            return data.FirstOrDefault(it => it.Id == id.ToString());
        }

        // POST api/values
        [HttpPost]
        public User AddUser([FromBody] User Userx)
        {
            var id = Guid.NewGuid().ToString();
            var item = new User
            {
                Id = id,
                Name = Userx.Name,
                Tel = Userx.Tel,
                Address = Userx.Address,
                Idcard = Userx.Idcard,
            };

            data.Add(item);

            // User.Id = id;

            // data.Add(Userx);
            return Userx;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void EditUser(string id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteUser(string id)
        {
            var delete = data.FirstOrDefault(it => it.Id == id.ToString());
            data.Remove(delete);
        }
    }
}