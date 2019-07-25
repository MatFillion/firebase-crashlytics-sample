using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		public void CrashTest()
		{
			Crashlytics.Crashlytics.Instance.Crash();
		}

		//private void ForceUICrash()
		//{
		//	new Android.OS.Handler(Android.OS.Looper.MainLooper).Post(() =>
		//	{
		//		throw new Exception("Explicit crash on UI Thread");
		//	});
		//}

		//private void ForceBackgroundCrash()
		//{
		//	ThreadPool.QueueUserWorkItem(_ =>
		//	{
		//		throw new Exception("Explicit crash on Background Thread");
		//	});
		//}
	}
}
