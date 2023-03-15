using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using Session3.DataModels;

namespace Session3.Tests
{
    public class ApiBaseTest
    {
        public RestClient RestClient { get; set; }

        public UserModel PetDetails { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            RestClient = new RestClient();
        }

        [TestCleanup]
        public void Cleanup()
        {

        }
    }
}
