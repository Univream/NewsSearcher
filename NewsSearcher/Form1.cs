using System;
using System.Net;
using System.Web; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO; 

namespace NewsSearcher
{
    public enum SetLanguage
    {
        German, 
        English, 
        France
    }

    public partial class FrmNews : Form
    {
        SetLanguage language = SetLanguage.English;

        public FrmNews()
        {
            InitializeComponent();
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {

            
            string input = TxtSearcher.Text;


            var NewsList = new List<NewsResult>(); 
            var client = new WebClient();
            client.Headers.Add("Ocp-Apim-Subscription-Key", " d99949bbc4fd4bdab9cec19dcd0406bd");

            byte[] rawNews = null;
            LstNews.Items.Clear(); 

            switch(language)
            {
                case (SetLanguage.German):
                        rawNews = client.DownloadData(string.Format("https://api.cognitive.microsoft.com/bing/v5.0/news/search?q={0}&mkt=de-de", input));
                        break;
                case (SetLanguage.English):
                        rawNews = client.DownloadData(string.Format("https://api.cognitive.microsoft.com/bing/v5.0/news/search?q={0}&mkt=en-us", input));
                        break;
                case (SetLanguage.France):
                        rawNews = client.DownloadData(string.Format("https://api.cognitive.microsoft.com/bing/v5.0/news/search?q={0}&mkt=fr-fr", input));
                        break;
            }

            var serializer = new JsonSerializer(); 
            using (var memNews = new MemoryStream(rawNews))
            using (var reader = new StreamReader(memNews))
            using (var jsonreader = new JsonTextReader(reader))
            {
                NewsList = serializer.Deserialize<News>(jsonreader).value;
                foreach (NewsResult news in NewsList)
                {
                    LstNews.Items.Add(news);
                }


            }
        
        }

        private void TxtSearcher_TextChanged(object sender, EventArgs e)
        {
            if(TxtSearcher.Text != "")
            {
                CmdSearch.Enabled = true; 
            }
        }

        private void LstNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewsResult nr = LstNews.SelectedItem as NewsResult;
            string[] summary = null; 

            try
            {
                summary = nr.Summary.Split(new char[] { '.' }, 2);
            }
            catch(ArgumentNullException)
            {
                summary = nr.Summary.Split(new char[] { '.' }, 1);
            }
            nr.Summary = string.Join("\n", summary);
            Lblinfo.Text = nr.Date.ToShortDateString() + "\n" + nr.Headline + "\n" + nr.Summary;
        }

        private void Mungerman_Click(object sender, EventArgs e)
        {
            language = SetLanguage.German;
            Mungerman.Checked = !Mungerman.Checked;
            Munenglish.Checked = false;
            Munfrance.Checked = false;
            CmdSearch_Click(sender, e);
        }

        private void Munenglish_Click(object sender, EventArgs e)
        {
            language = SetLanguage.English;
            Mungerman.Checked = false; 
            Munenglish.Checked = !Munenglish.Checked;
            Munfrance.Checked = false;
            CmdSearch_Click(sender, e);
        }

        private void Munfrance_Click(object sender, EventArgs e)
        {
            language = SetLanguage.France;
            Mungerman.Checked = false;
            Munenglish.Checked = false; 
            Munfrance.Checked = !Munfrance.Checked;
            CmdSearch_Click(sender, e);
        }
    }
}
