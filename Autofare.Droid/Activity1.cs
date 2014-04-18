using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Autofare.PCL;

namespace Autofare.Droid
{
    [Activity(Label = "Autofare.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += button_Click;

        }

        void button_Click(object sender, EventArgs e)
        {
            EditText distance = FindViewById<EditText>(Resource.Id.txtDistance);
            TextView output = FindViewById<TextView>(Resource.Id.txvOutput);
            output.Text = Fare.CalculateFare(double.Parse(distance.Text.ToString()));

        }
    }
}

