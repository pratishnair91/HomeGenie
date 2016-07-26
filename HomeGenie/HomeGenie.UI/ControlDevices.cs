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
namespace HomeGenie.UI
{
    [Activity(Label = "ControlDevices")]
    public class ControlDevices : Activity
    {
        private AzureWebApiClient azureClient;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.switchview);
            azureClient = new AzureWebApiClient();

            Button toggle = FindViewById<Button>(Resource.Id.btnToggle);

            toggle.Click += Toggle_Click;


        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            RadioButton rdbtn = FindViewById<RadioButton>(Resource.Id.radioButton1);
            azureClient.val = rdbtn.Checked ? "on" : "off";
            azureClient.Init("application/json", "POST");

            azureClient.Request();
            var alert = new AlertDialog.Builder(this)
      .SetPositiveButton("Ok", (se, args) =>
      {
          // User pressed yes
      })

      .SetMessage("Device Successfully switched " + azureClient.val + " !!")
      .SetTitle("Status")
      .Show();

        }


    }
}
