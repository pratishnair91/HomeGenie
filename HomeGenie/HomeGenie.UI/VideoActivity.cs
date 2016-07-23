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
using Android.Media;


namespace HomeGenie.UI
{
    [Activity(Label = "Live Video Stream")]
    public class VideoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.video);

            VideoView view = FindViewById<VideoView>(Resource.Id.videoView1);


            // Create a progressbar
           var pDialog = new ProgressDialog(this);
            // Set progressbar title
            pDialog.SetTitle("Android Video Streaming Tutorial");
            // Set progressbar message
            pDialog.SetMessage("Buffering...");
           // pDialog.SetIndeterminateDrawable(false);
            pDialog.SetCancelable(false);
            // Show progressbar
            pDialog.Show();

            try
            {
                // Start the MediaController
                MediaController mediacontroller = new MediaController(
                        this);
                mediacontroller.SetAnchorView(view);
                // Get the URL from String VideoURL
                Android.Net.Uri video = Android.Net.Uri.Parse("http://prvnaimedia.streaming.mediaservices.windows.net/11109950-8da1-4555-bfaa-fbf2183c5198/50491138-5814-4bd7-a9fd-3bae77d8e031.ism/manifest(format=m3u8-aapl)"); ;
                view.SetMediaController(mediacontroller);
                view.SetVideoURI(video);

            }
            catch (Exception e)
            {
                pDialog.SetMessage("Error While Streaming...");
            }


            view.RequestFocus();


            view.Prepared += delegate { pDialog.Dismiss(); view.Start(); };




            //Android.Net.Uri uri = Android.Net.Uri.Parse("http://prvnaimedia.streaming.mediaservices.windows.net/d549d574-cdfe-4c7f-bb7b-56f54c57c849/c798f97a-7bf9-446c-bd6c-6fa734a4ad54.ism/manifest(format=m3u8-aapl)");
            //view.SetVideoURI(uri);
            //view.Start(); 

            //Intent browserIntent = new Intent(Intent.Action, Android.Net.Uri.Parse("http://prvnaimedia.streaming.mediaservices.windows.net/d549d574-cdfe-4c7f-bb7b-56f54c57c849/c798f97a-7bf9-446c-bd6c-6fa734a4ad54.ism/manifest(format=m3u8-aapl)"));
            //StartActivity(browserIntent);
        }

      
    }




}
