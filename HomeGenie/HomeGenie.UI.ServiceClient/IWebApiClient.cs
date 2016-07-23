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
    interface IWebApiClient
    {
        HttpWebRequest _request { get; set; }
        HttpWebResponse _reponse { get; set; }
        string UrlString { get; }
        void Init(string contentType, string requestMethod);
        string Request();
    }
}