using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Neo4j.Driver.V1;
using VAWN.App_Start;

namespace VAWN.Controllers
{
    [RoutePrefix("api/movies")]
    public class MovieController : ApiController
    {

        [HttpGet]
        [Route("")]
        public IHttpActionResult GetAllMovies(string relTypes = "", int limit = 100)
        {
            return Ok();
        }

        [HttpGet]
        [Route("{title}")]
        public IHttpActionResult GetMovieByTitle(string title, string relTypes = "", int hopLimit = 1)
        {
            return Ok();
            //var statementTemplate = System.IO.File.ReadAllText("/Cql/GetMovieByTitle.cql");
            //var statementParameters = new Dictionary<string, object> { { "title", title } };

            //var result = new MovieResult();
            //using (var session = WebApiConfig.Neo4jDriver.Session())
            //{
            //    var statementResult = session.Run(statementTemplate, statementParameters);

            //    var record = statementResult.Single();

            //    result.title = record["title"].As<string>();

            //    var castResults = new List<CastResult>();
            //    List<object> cast = record["cast"].As<List<object>>();
            //    foreach (IList<object> castMember in cast)
            //    {
            //        var castResult = new CastResult
            //        {
            //            name = castMember[0].As<string>(),
            //            job = castMember[1].As<string>(),
            //            role = castMember[2]?.As<List<string>>()
            //        };
            //        castResults.Add(castResult);
            //    }
            //    result.cast = castResults;
            //}

            //return Ok(result);
        }
    }
}
