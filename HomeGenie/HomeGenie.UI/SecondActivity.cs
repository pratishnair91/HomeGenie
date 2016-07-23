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
using HomeGenie.UI.ServiceClient;
using Newtonsoft.Json.Linq;

namespace HomeGenie.UI
{
    [Activity(Label = "Choose your option")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SecondLayout);
            Button videoStream = FindViewById<Button>(Resource.Id.allow);
           
            videoStream.Click += VideoStream_Click;

            Button videoView = FindViewById<Button>(Resource.Id.video);
            videoView.Click += VideoView_Click;
        }

        private void VideoView_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(VideoActivity));
        }

       

        private void VideoStream_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(WebViewActivity));
        }
    }
}