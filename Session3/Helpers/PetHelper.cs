using RestSharp;
using Session3.DataModels;
using Session3.Resources;
using Session3.Tests.TestData;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Session3.Helpers
{
    public class PetHelper
    {
        public static async Task<UserModel> GetPet(RestClient client)
        {
            var newPetData = GeneratePet.demoPet();
            var postRequest = new RestRequest(Endpoints.PostPet());

            //Send Post Request
            postRequest.AddJsonBody(newPetData);
            var postResponse = await client.ExecutePostAsync<UserModel>(postRequest);

            var createdPetData = newPetData;
            return createdPetData;
        }
    }
}
