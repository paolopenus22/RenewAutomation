using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenewAutomation.TestEndpoints
{
    public class Endpoints
    {
        private const string BaseURL = "https://jsonplaceholder.typicode.com";

        public static string GetAllPosts = $"{BaseURL}/posts";

        public static string GetPostById(int postId) => $"{BaseURL}/posts/{postId}";
        public static string GetPostByInvalidId(string letter) => $"{BaseURL}/posts/{letter}";
        public static string GetPostComments(int postId) => $"{BaseURL}/posts/{postId}/comments";
    }
}
