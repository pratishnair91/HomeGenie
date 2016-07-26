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

namespace HomeGenie.UI.ServiceClient
{
   public class AzureWebApiClient : WebApiClient
    {
        public string  val { get; set; }
        public override string UrlString
        {
            
            
            get
            {
                return ("http://hackathon2016homegeniewebapi.azurewebsites.net/api/device?value="+val+"&secret=shashwat");
            }
        }

        public AzureWebApiClient()
        {
            val = "on";
        }


    }
}