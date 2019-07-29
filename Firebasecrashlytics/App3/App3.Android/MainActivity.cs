using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Firebase;
using Java.Lang;
using Firebase.Iid;
using System.Threading.Tasks;
using Firebase.Messaging;
using App3.Droid;

namespace Crashlytics9.Droid
{
    [Activity(Label = "Crashlytics9", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

			//Initialize Firebase manually if it is not doing so automatically
			//var firebaseApp = FirebaseApp.InitializeApp(this);

			//Initialize the Crashlytics SDK
			Fabric.Fabric.With(this, new Crashlytics.Crashlytics());
			
			//Catch unhandled android exceptions and format them nicely
			Crashlytics.Crashlytics.HandleManagedExceptions();

			var a = FirebaseInstanceId.Instance;

			var exception = new InvalidOperationException();
			Crashlytics.Crashlytics.LogException(Throwable.FromException(exception));

			Crashlytics.Crashlytics.Instance.Crash();

			LoadApplication(new App());
        }
	}
}