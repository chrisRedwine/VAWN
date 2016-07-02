using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using NUnit.Framework;
using VAWN.Controllers;
using VAWN.Models;

namespace VAWN.Tests
{
    [TestFixture]
    public class MovieControllerTests
    {
        // Arrange
        private MovieController _controller;

        public MovieControllerTests()
        {
            _controller = new MovieController();
        }


        // GET api/movies test
        [Test]
        public void GetAllMovies_ReturnsOk_ReturnsMovies()
        {
            // Act
            IHttpActionResult actionResult = _controller.GetAllMovies();
            var contentResult = actionResult as OkNegotiatedContentResult<IEnumerable<MovieModel>>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.Greater(1, -1);
        }

        [Test]
        public void GetAllMovies_ReturnsNotFound()
        {
            // Act
            IHttpActionResult actionResult = _controller.GetAllMovies("NOT_A_RELATIONSHIP");

            // Assert
            Assert.IsInstanceOfType(typeof(NotFoundResult), actionResult);
        }


        // GET api/movies/{title} test
        [Test]
        public void GetMovieByTitle_ReturnsOk_ReturnsCorrectMovie()
        {
            // Act
            IHttpActionResult actionResult = _controller.GetMovieByTitle("The Matrix");
            var contentResult = actionResult as OkNegotiatedContentResult<MovieModel>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual("The Matrix", contentResult.Content.Title);
        }

        [Test]
        public void GetMovieByTitle_ReturnsNotFound()
        {
            // Act
            IHttpActionResult actionResult = _controller.GetMovieByTitle("The FooBar Movie");

            // Assert
            Assert.IsInstanceOfType(typeof(NotFoundResult), actionResult);
        }
    }
}
