using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetJokeButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = GetJokes();
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
