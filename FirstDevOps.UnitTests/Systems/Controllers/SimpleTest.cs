using FirstDevOps.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace FirstDevOps.UnitTests.Systems.Controllers
{
    public class SimpleTest
    {
        [Fact]
        public void Get_OnSucess_ReturnsStatusCode200()
        {
            //Arrange
            var sut = new HomeController();

            //Act
            var result = (OkObjectResult)sut.GetAll();

            //Assert
            result.StatusCode.Should().Be(200);
        }
    }
}
