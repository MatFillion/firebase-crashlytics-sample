using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Firebasecrashlytics.Droid
{
    [Activity(Label = "Firebasecrashlytics", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

			var firebaseAnalytics = Firebase.Analytics.FirebaseAnalytics.GetInstance(this);
			var bundle = new Bundle();
			bundle.PutString(Firebase.Analytics.FirebaseAnalytics.Param.ItemId, "1");
			bundle.PutString(Firebase.Analytics.FirebaseAnalytics.Param.ItemName, "CoolEventWorking");
			firebaseAnalytics.LogEvent(Firebase.Analytics.FirebaseAnalytics.Event.SelectContent, bundle);

			base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}