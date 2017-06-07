using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AuthService.Controllers
{
    [RoutePrefix("auth")]
    public class AuthController : ApiController
    {
        [Route("{Device_ID}")]
        public IHttpActionResult Get(string Device_ID) {
            if (!String.IsNullOrEmpty(Device_ID)) {
                return Ok();
            }
            return InternalServerError();
        }
    }
}
