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
using Android.Webkit;
using Java.Lang;

namespace HomeGenie.UI
{
    [Activity(Label = "WebViewActivity")]
    public class WebViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.web);
            WebView myWebView = FindViewById<WebView>(Resource.Id.webView1);
            myWebView.Settings.JavaScriptEnabled = true;
            //myWebView.Settings.PluginsEnabled = true;
            myWebView.Settings.AllowUniversalAccessFromFileURLs = true;
            myWebView.Settings.AllowFileAccessFromFileURLs = true;
            myWebView.Settings.AllowFileAccess = true;
            myWebView.Settings.SetPluginState(WebSettings.PluginState.OnDemand);
            myWebView.SetWebChromeClient(new WebChromeClient());
            myWebView.Settings.MediaPlaybackRequiresUserGesture = false;
          //  myWebView.Settings.UserAgent = 1;
            myWebView.LoadUrl("file:///android_asset/media.html");
            WebViewClient wc = new WebViewClient();

            




            // Create your application here
        }
        [Android.Runtime.Register("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", "GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler")]
        public virtual void UncaughtException(Thread t, Throwable e)
        { }
    }
}