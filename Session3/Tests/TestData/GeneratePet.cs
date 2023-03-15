using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session3.DataModels;

namespace Session3.Tests.TestData
{
    public class GeneratePet
    {
        public static UserModel demoPet()
        { 
            return new UserModel
            {
                Id = 1000,

                Category = new Category()
                {
                    Id = 2,
                    Name = "Test"
                },
                Name = "Kylo",
                PhotoUrls = new List<string>
               {
                   "Poring"
               },
                Tags = new List<Category>()
               {
                   new Category()
                   {
                   Id = 3,
                   Name = "Test"
                   }
               },
                Status = "available"
            };
        }
    }
}
