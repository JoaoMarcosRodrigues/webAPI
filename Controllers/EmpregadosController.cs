using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webMVC.Models;
using webMVC.Service;

namespace webApi.Controllers
{
    public class EmpregadosController : ApiController
    {
        // GET: api/Empregados
        public IEnumerable<EmployeeModel> Get()
        {
            return new EmployeeServices().GetEmployeeList();
        }

        // GET: api/Empregados/{cpf}
        public EmployeeModel Get(int id)
        {
            return new EmployeeServices().GetEditById(id);
            //return "value";
        }

        public EmployeeModel GetCPF(string cpf)
        {
            return new EmployeeServices().GetEmpByCpf(cpf);
            //return "value";
        }

        // POST: api/Empregados
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Empregados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Empregados/5
        public void Delete(int id)
        {
        }
    }
}
