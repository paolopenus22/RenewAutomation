using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RenewAutomation.Data_Models;
using RenewAutomation.TestEndpoints;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace RenewAutomation.Tests
{
    [TestClass]
    public class PostsTests
    {
        private readonly RestClient client = new RestClient();

        [TestMethod]
        public async Task GetAllPostsAsync()
        {
            RestRequest request = new RestRequest(Endpoints.GetAllPosts);
            RestResponse<Posts> response = await client.ExecuteGetAsync<Posts>(request);
            
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status Code is not OK!");
            Assert.IsTrue(response.Content.Contains("userId"), "Response body might be empty!");
        }
        [TestMethod]
        public async Task GetPostByIdAsync()
        {
            string title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit";
            string body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto";
            RestRequest request = new RestRequest(Endpoints.GetPostById(1));
            RestResponse<Posts> response = await client.ExecuteGetAsync<Posts>(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status Code is not OK!");
            Assert.AreEqual(1, response.Data.userId, "UserId is not 1");
            Assert.AreEqual(1, response.Data.id, "Id is not 1");
            Assert.AreEqual(title, response.Data.title, "Incorrect title");
            Assert.AreEqual(body, response.Data.body, "Incorrect body");
        }
        [TestMethod]
        public async Task GetPostByLetterAsync()
        {
            RestRequest request = new RestRequest(Endpoints.GetPostByInvalidId("a"));
            RestResponse<Posts> response = await client.ExecuteGetAsync<Posts>(request);

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode, "Status Code is not 'Not Found'");
            Assert.IsTrue(response.Content == "{}", "Content is not blank");
        }
        [TestMethod]
        public async Task GetPostCommentsAsync()
        {
            RestRequest request = new RestRequest(Endpoints.GetPostComments(1));
            var response = await client.ExecuteGetAsync<List<Comments>>(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "Status Code is not OK!");
            Assert.AreEqual(5, response.Data.Count, "Incorrect count of data!");
        }
    }
}