using System.Threading.Tasks;
using XZQ.MESIntelligence.Models.TokenAuth;
using XZQ.MESIntelligence.Web.Controllers;
using Shouldly;
using Xunit;

namespace XZQ.MESIntelligence.Web.Tests.Controllers
{
    public class HomeController_Tests: MESIntelligenceWebTestBase
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