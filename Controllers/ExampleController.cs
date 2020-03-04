using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using System.Net.Http;

namespace APIKeycloak_Example.API.Controllers
{
    public class ExampleController : ApiController
    {
        [HttpGet]
        [Route("api/example/adminMethod")]
        [Authorize(Roles = "admin")]
        public HttpResponseMessage getSomethingForAdmin()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "You are admin!");
        }

        [HttpGet]
        [Route("api/example/multiRolesMethod")]
        [Authorize(Roles = "role1")]
        [Authorize(Roles = "role2")]
        public HttpResponseMessage getSomethingForMultiRoles()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "You are someone with role1 or role2!");
        }

        [HttpGet]
        [Route("api/example/anyoneMethod")]
        public HttpResponseMessage getSomethingForAnyone()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "You are someone!");
        }
    }
}