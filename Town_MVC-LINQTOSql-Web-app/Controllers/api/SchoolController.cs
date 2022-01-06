using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Town_MVC_LINQTOSql_Web_app.Models;

namespace Town_MVC_LINQTOSql_Web_app.Controllers.api
{
    public class SchoolController : ApiController
    {
        static string Stringconction = "Data Source=LAPTOP-OT5IVM7S;Initial Catalog=CityDB;Integrated Security=True;Pooling=False";
        DataClasses1DataContext CityDB = new DataClasses1DataContext(Stringconction);
        // GET: api/School
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(CityDB.Schools.ToList());

            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // GET: api/School/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(CityDB.Schools.First(item => item.Id==id));
            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }




        }

        // POST: api/School
        public IHttpActionResult Post([FromBody]School value)
        {
            try
            {
                CityDB.Schools.InsertOnSubmit(value);
                CityDB.SubmitChanges();
                return Ok("row add");
            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }


        }

        // PUT: api/School/5
        public IHttpActionResult Put(int id, [FromBody]School value)
        {

            try
            {
                School newSchool = CityDB.Schools.First(Res => Res.Id == id);
                newSchool.Street = value.Street;
                newSchool.Public = value.Public;    
                newSchool.Number_Student = value.Number_Student;

                CityDB.SubmitChanges();

                return Ok(new { newSchool });

            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // DELETE: api/School/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                School SchoolDelte = CityDB.Schools.First(item => item.Id == id);
                CityDB.Schools.DeleteOnSubmit(SchoolDelte);
                CityDB.SubmitChanges();
                return Ok("success");
            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}
