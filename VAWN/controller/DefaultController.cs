using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VAWN.controller
{
    /// <summary>
    /// Default controller for common methods
    /// </summary>
    [RoutePrefix("api/default")]
    public class DefaultController : ApiController
    {
        // GET: api/Default
        /// <summary>
        /// Health check for default resource
        /// </summary>
        /// <returns>Default controller is up and responding.</returns>
        [Route("")]
        [HttpGet]
        public string Get()
        {
            return "Default controller is up and responding.";
        }
    }
}
