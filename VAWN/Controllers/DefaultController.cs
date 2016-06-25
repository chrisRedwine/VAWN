using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VAWN.Controllers
{
    /// <summary>
    /// Default controller for common methods
    /// </summary>
    [RoutePrefix("api/default")]
    public class DefaultController : ApiController
    {
        // GET: api/Default
        /// <summary>
        /// Health check for Default controller
        /// </summary>
        /// <returns>Response string "Default controller is up and running"</returns>
        public string Get()
        {
            return "Default controller is up and running";
        }
    }
}
