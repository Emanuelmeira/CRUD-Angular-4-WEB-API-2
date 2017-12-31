using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using Easy.Api.Controllers;
using Easy.Unit.Test.MockEtities;
using System.Web.Http.Results;
using Easy.Domain.Entities;

namespace Easy.Unit.Test.ControllersUnitTest
{
    [TestClass]
    public class DeveloperControllerUnitTest
    {
        //[TestMethod]
        //public void RegisteredDeveloperSuccessfully()
        //{
        //    MockDeveloper mockDeveloper = new MockDeveloper();

        //    // Arrange
        //    var developer = mockDeveloper.Prepare();
        //    var controller = new DeveloperController();
            
        //    //Act
        //    IHttpActionResult actionResult = controller.PostDeveloper(developer);            
        //    var contentResult = actionResult as OkNegotiatedContentResult<Developer>;

        //    // Assert
        //    Assert.IsNotNull(contentResult);
        //    Assert.AreEqual(developer.Name, contentResult.Content.Name);
        //}


        [TestMethod]
        public void GetDeveloperSuccessfully()
        {
            //MockDeveloper mockDeveloper = new MockDeveloper();

            // Arrange
            //var developer = mockDeveloper.Prepare();
            var controller = new DeveloperController();

            //Act
            IHttpActionResult actionResult = controller.GetDeveloper(1);
            var contentResult = actionResult as OkNegotiatedContentResult<Developer>;

            // Assert
            Assert.IsNotNull(contentResult);
            //Assert.AreEqual(developer.Name, contentResult.Content.Name);
        }

        //[TestMethod]
        //public void DeleteReturnsOk()
        //{
        //    // Arrange
        //    var mockRepository = new Mock<IProductRepository>();
        //    var controller = new Products2Controller(mockRepository.Object);

        //    // Act
        //    IHttpActionResult actionResult = controller.Delete(10);

        //    // Assert
        //    Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        //}
    }
}
