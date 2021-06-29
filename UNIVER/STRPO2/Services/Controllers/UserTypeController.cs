using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLINterfaces;
using DBLibrary;
using ModelsLibrary;
using RealServices;

namespace Services.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserTypeController : ApiController
    {
        private IUTService _service;

        /* public UserTypeController()
         {
             //_service = new TestLibrary.TestService();
             _service = new RealService();
         }*/
        public UserTypeController(IUTService service)
        {
            _service = service;

        }

        // GET api/usertype
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Get()
        {
            var resp = Request.CreateResponse(HttpStatusCode.OK, _service.GetUTs(), Configuration.Formatters.JsonFormatter);
            resp.Headers.Add("X-Custom-Header", "hello");
            return resp;
        }

        // GET api/usertype?id=7
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Get(int id)
        {
            var resp = Request.CreateResponse(HttpStatusCode.OK, _service.GetUTs(id), Configuration.Formatters.JsonFormatter);
            resp.Headers.Add("X-Custom-Header", "hello");
            return resp;
        }

        // GET api/usertype?page=1&pagecount=7
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Get(int page, int pagecount)
        {
            var resp = Request.CreateResponse(HttpStatusCode.OK, _service.GetPagedUTs(page, pagecount), Configuration.Formatters.JsonFormatter);
            resp.Headers.Add("X-Custom-Header", "hello");
            return resp;
        }



        // POST api/usertype
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPost]
        public string Post([FromBody] MyModel mdl)
        {
            using (var context = new STRPO2Entities())
            {
                if (mdl == null || mdl.NewName == "")
                    return null;

                if (Enumerable.Any(context.User_type, User_type => User_type.Name ==
                mdl.NewName))
                {
                    return "Already exists";
                }

                User_type ct = new User_type
                {
                    Name = mdl.NewName
                };
                context.User_type.Add(ct);
                try
                {
                    context.SaveChanges();
                    return "OK";
                }
                catch (DbException dbex)
                {
                    return 
                        dbex.ToString();
                }
                catch (Exception exception)
                {
                    return exception.Message;
                }
            }
        }

        // PUT api/usertype/5
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody] MyModel mdl)
        {
            if(id == -1 || mdl?.NewName == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            try
            {
                using (var context = new STRPO2Entities())
                {
                    var o = (from c in context.User_type where c.ID == id select c).FirstOrDefault();
                    if (o == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    o.Name = mdl.NewName;
                    context.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (DbUpdateException dbex)
            {
                return Request.CreateResponse(HttpStatusCode.Conflict,
                    dbex.ToString()

                );
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,
                    ex.ToString()
                );
            }
        }

        // DELETE api/usertype/5
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {

            try
            {
                using (var context = new STRPO2Entities())
                {
                    var o = (from c in context.User_type where c.ID == id select c).FirstOrDefault();
                    if (o == null)
                    {
                        return Request.CreateResponse(HttpStatusCode.NotFound);
                    }
                    context.User_type.Remove(o);
                    context.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (DbUpdateException dbex)
            {
                return Request.CreateResponse(HttpStatusCode.Conflict,
                    dbex.ToString()

                );
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,
                    ex.ToString()
                );
            }
        }
    }
}
