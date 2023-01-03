using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace app1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView tvDisplay;
        private Button btnPlus;
        private Button btnMinus;
        private int number = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            SetView();
        }

        private void SetView()
        {
            tvDisplay = FindViewById<TextView>(Resource.Id.ClickCount);
            btnPlus = FindViewById<Button>(Resource.Id.plusButton);
            btnMinus = FindViewById<Button>(Resource.Id.minusBtn);

            btnPlus.Click += BtnPlus_Click;
            btnPlus.Click += BtnPlus_Click1;
            btnMinus.Click += BtnMinus_Click;

        }

        private void BtnPlus_Click1(object sender, EventArgs e)
        {
            Toast.MakeText(Application.Context, "Hello", ToastLength.Short).Show();
        }

        private void BtnPlus_Click(object sender,EventArgs e)
        {
            number++;
            tvDisplay.Text = number.ToString();
        }
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            number--;
            tvDisplay.Text = number.ToString();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}