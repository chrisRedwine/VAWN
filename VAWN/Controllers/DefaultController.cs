using System;
using System.Web.Http;
using VAWN.Models;

namespace VAWN.Controllers
{
    /// <summary>
    /// Default controller for common methods
    /// </summary>
    [RoutePrefix("api/default")]
    public class DefaultController : ApiController
    {
        // GET: api/default
        /// <summary>
        /// Health check for Default controller
        /// </summary>
        /// <returns>Response string "Default controller is up and running"</returns>
        [HttpGet, Route("")]
        public string GetHealth()
        {
            return "Default controller is up and running";
        }

        // GET: api/default/user
        /// <summary>
        /// Gets the current user metadata
        /// </summary>
        /// <returns>Current user name</returns>
        [HttpGet, Route("user")]
        public DefaultModel GetUser()
        {
            DefaultModel user = new DefaultModel()
            {
                UserName = Environment.UserName,
                UserDomainName = Environment.UserDomainName,
                MachineName = Environment.MachineName,
                OSVersionString = Environment.OSVersion.VersionString
            };
            return user;
        }

        // GET: api/default/{name}
        /// <summary>
        /// Friendly greeting
        /// </summary>
        /// <returns>Response string "Default controller is up and running"</returns>
        [HttpGet, Route("{name}")]
        public string GetGreeting(string name)
        {
            return string.Format("Hello, {0}!", name);
        }
    }
}
