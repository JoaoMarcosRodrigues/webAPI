using System.Collections.Generic;
using System.Web.Http;
using webMVC.Models;
using webMVC.Service;

namespace webApi.Controllers
{
    public class DepartamentosController : ApiController
    {
        // GET: api/Departamentos
        public IEnumerable<DepartamentoModel> Get()
        {
            return new DepartamentoServices().GetDepartamentoList();
        }

        // GET: api/Departamentos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Departamentos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Departamentos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Departamentos/5
        public void Delete(int id)
        {
        }
    }
}
