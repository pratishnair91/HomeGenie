using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Net;

namespace HomeGenie.UI.ServiceClient
{
   public class WikiPediaWebApiClient : WebApiClient
    {
        private const string wikipediaQueryUrl= "http://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&explaintext=1&titles=";

        public override string UrlString
        {
            get
            {
                return wikipediaQueryUrl;
            }
        }

        public string Query { get; set; }
        public override void Init(string contentType, string requestMethod)
        {
            _request = HttpWebRequest.Create(UrlString + Query) as HttpWebRequest;
            _request.ContentType = contentType;
            _request.Method = requestMethod;
        }

         public string GetResults()
        {


            return string.Empty;
        }
        
    }
}