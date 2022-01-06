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
    public class ResidentsController : ApiController
    {
        static string Stringconction = "Data Source=LAPTOP-OT5IVM7S;Initial Catalog=CityDB;Integrated Security=True;Pooling=False";

        DataClasses1DataContext CityDB = new DataClasses1DataContext(Stringconction);

        // GET: api/Residents
        public IHttpActionResult  Get()
        {
            try
            {
               
                return Ok(CityDB.Residents.ToList());
            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // GET: api/Residents/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(CityDB.Residents.First(res => res.Id == id));  

            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }

        }

        // POST: api/Residents
        public IHttpActionResult Post([FromBody] Resident value)
        {
            try
            {
                CityDB.Residents.InsertOnSubmit(value);
                CityDB.SubmitChanges();
                return Ok("rwo add");

            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // PUT: api/Residents/5
        public IHttpActionResult Put(int id, [FromBody] Resident value)
        {

            try
            {
                Resident newResident = CityDB.Residents.First(Res => Res.Id == id);
                newResident.First_name = value.First_name;
                newResident.Last_name = value.Last_name;
                newResident.Born = value.Born;
                newResident.Address = value.Address;
                newResident.Seniority = value.Seniority;

                CityDB.SubmitChanges();

                return Ok(new { newResident });
                
            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // DELETE: api/Residents/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Resident resident1 = CityDB.Residents.First(res => res.Id == id);
                CityDB.Residents.DeleteOnSubmit(resident1);
                CityDB.SubmitChanges();
                return Ok(CityDB.Residents.ToList());

            }
            catch (SqlException ex) { return BadRequest(ex.Message); }
            catch (Exception ex) { return BadRequest(ex.Message); }

        }
    }
}
