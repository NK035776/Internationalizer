using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel.Web;
using Internalization.Properties;
using Yandex.Translator;
using Yandex;
using Json;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Web;


namespace Internalization
{
    class  YandexTranslate
    {
        public static string _apiKey = "trnsl.1.1.20170901T142853Z.a977e42a143ff396.c45eca538d137c0714d48a727e04746e62236ffb";

        public static List<string> Translate(string lang, string text)
        {
            try
            {
               
                var requestString =
                    System.Net.WebUtility.HtmlDecode(String.Format("https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}&format={3}",
                    _apiKey, text, lang, "plain"));

                var request = WebRequest.Create(requestString);
                if ((requestString.Length > 10240) && (request.Method.StartsWith("GET")))
                    throw new ArgumentException("Text is too long (>10Kb)");
                request.Method = WebRequestMethods.Http.Get;
                request.ContentType = "application/json; charset=utf-8";
                var response = request.GetResponse();
                var rawJson = new StreamReader(response.GetResponseStream()).ReadToEnd();

                var json = Newtonsoft.Json.Linq.JObject.Parse(rawJson);
                dynamic results = JsonConvert.DeserializeObject<dynamic>(rawJson);
                return results.text.ToObject<List<string>>();

            }
            catch(Exception ep)
            {
                MessageBox.Show(ep.Message);
                List < string > str = new List<string>();
                return (str);
            }
        }

        public class RootObject
        {
            public int code { get; set; }
            public string lang { get; set; }
            public List<string> text { get; set; }
        }

        public static void PopulateLanguageCbo(ComboBox cbo)
        {
            List<KeyValuePair<string, string>> lang = new List<KeyValuePair<string, string>>();
            lang.Add(new KeyValuePair<string, string>("en-fi", "Finnish"));
            lang.Add(new KeyValuePair<string, string>("en-fr", "French"));
            cbo.DataSource = new BindingSource(lang, null);
            cbo.DisplayMember = "Value";
            cbo.ValueMember = "Key";
        }
    }

}

    
