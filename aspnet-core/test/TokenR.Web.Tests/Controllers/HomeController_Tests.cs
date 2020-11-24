using System.Threading.Tasks;
using TokenR.Models.TokenAuth;
using TokenR.Web.Controllers;
using Shouldly;
using Xunit;

namespace TokenR.Web.Tests.Controllers
{
    public class HomeController_Tests: TokenRWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}