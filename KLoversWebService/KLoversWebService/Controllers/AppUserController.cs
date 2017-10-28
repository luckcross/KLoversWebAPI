using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using KLoversWebService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data.SqlClient;
using System.Data;
using KLoversWebService.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KLoversWebService.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AppUserController : Controller
    {
        private readonly KLoversDBContext db;

        public AppUserController(KLoversDBContext db)
        {
            this.db = db;
        }
        // GET: api/appuser
        [HttpGet]
        public List<AppUser> Get()
        {
            return db.AppUsers.ToList(); 
        }

        // GET api/appuser/5
        [HttpGet("{id}")]
        public AppUser Get(int id)
        {
            //return $"value {id}";
            return db.AppUsers.Find(id);
        }

        // POST api/appuser
        [HttpPost]
        public IActionResult Post([FromBody]AppUser appUser)
        {
            if (!ModelState.IsValid)
            {
                //throw new InvalidOperationException("Invalid");
                return BadRequest(ModelState);
            }

            db.AppUsers.Add(appUser);
            db.SaveChanges();
            //return CreatedAtAction("Get", new { id = value.Id}, value);
            return new ObjectResult("AppUser added sucessfully");
        }

        [HttpPut]
        [Route("AddAppUser/{facebook}")]
        public IActionResult AddAppUser(string facebook)
        {
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("facebook", facebook)
            {
                DbType = DbType.String,
                Size = 50,
                Direction = ParameterDirection.Input
            };
            parameters[1] = new SqlParameter("ause_id_inserted", "")
            {
                DbType = DbType.Int32,
                Direction = ParameterDirection.Output
            };

            var result = ProcedureUtils.ExecuteProcedure(db, "dbo.app_proc_user_add", parameters);

            int outnewid = (int)parameters[1].Value;

            return new ObjectResult("AppUser added with procedure sucessfully");
        }

        // PUT api/appuser/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]AppUser value)
        {
            if (!ModelState.IsValid)
            {
                //throw new InvalidOperationException("Invalid");
                return BadRequest(ModelState);
            }

            db.Entry(value).State = EntityState.Modified;
            db.SaveChanges();
            return new ObjectResult("AppUser updated sucessfully");
        }

        // DELETE api/appuser/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                //throw new InvalidOperationException("Invalid");
                return BadRequest(ModelState);
            }

            db.AppUsers.Remove(db.AppUsers.Find(id));
            db.SaveChanges();
            return new ObjectResult("AppUser removed sucessfully");
        }
    }
}
