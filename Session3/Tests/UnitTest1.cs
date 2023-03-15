using Microsoft.VisualStudio.TestTools.UnitTesting;
using Session3.Helpers;
using Session3.Resources;
using Session3.DataModels;
using RestSharp;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Session3.Tests
{
    [TestClass]
    public class Session3 : ApiBaseTest
    {
        private static List<UserModel> userCleanUpList = new List<UserModel>();

        [TestInitialize]
        public async Task TestInitialize()
        {
            PetDetails = await PetHelper.GetPet(RestClient);
        }
        [TestMethod]
        public async Task DemoGetPet()
        {
            //Arrange
            var demoGetRequest = new RestRequest(Endpoints.GetPetByID(PetDetails.Id.ToString()));
            userCleanUpList.Add(PetDetails);

            //Act
            var demoResponse = await RestClient.ExecuteGetAsync<UserModel>(demoGetRequest);

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, demoResponse.StatusCode, "Failed due to wrong status code.");
            Assert.AreEqual(PetDetails.Name, demoResponse.Data.Name);
            Assert.AreEqual(PetDetails.PhotoUrls[0], demoResponse.Data.PhotoUrls[0]);
            Assert.AreEqual(PetDetails.Tags[0].Name, demoResponse.Data.Tags[0].Name);
            Assert.AreEqual(PetDetails.Status, demoResponse.Data.Status);
        }
        //[TestCleanup]
        //public async Task TestCleanUp()
        //{
        //    foreach (var data in userCleanUpList) 
        //    {
        //        var deletePetRequest = new RestRequest(Endpoints.DeletePetById(data.Id));
        //        var deletePetResponse = await RestClient.DeleteAsync(deletePetRequest);
        //    }
        //}
    }
}