using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace Chuck_API
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetJokes();
            Console.WriteLine(message);
        }
        public static string GetJokes()
        {
            string url = "http://api.icndb.com/jokes/random";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";

            var webRespose = request.GetResponse();
            var webStream = webRespose.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var respone = responseReader.ReadToEnd();
                Joke joke = JsonConvert.DeserializeObject<Joke>(respone);
                Console.WriteLine(joke.value.Joke);
                return joke.value.Joke;
            }
        }
    }
}
