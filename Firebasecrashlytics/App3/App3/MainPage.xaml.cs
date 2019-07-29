using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Crashlytics9
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			this.BindingContext = new MainPageViewModel();
		}

		public class MainPageViewModel
		{
			public ICommand CrashTest { get; private set; }

			public ICommand ForceUICrash { get; private set; }

			public ICommand ForceBackgroundCrash { get; private set; }

			public MainPageViewModel()
			{
				CrashTest = new Command(CrashTestCommand);
				ForceUICrash = new Command(ForceUICrashCommand);
				ForceBackgroundCrash = new Command(ForceBackgroundCrashCommand);
			}
						
			public void CrashTestCommand()
			{
				Crashlytics.Crashlytics.Instance.Crash();
			}

			private void ForceUICrashCommand()
			{
				new Android.OS.Handler(Android.OS.Looper.MainLooper).Post(() =>
				{
					throw new Exception("Explicit crash on UI Thread");
				});
			}

			private void ForceBackgroundCrashCommand()
			{
				ThreadPool.QueueUserWorkItem(_ =>
				{
					throw new Exception("Explicit crash on Background Thread");
				});
			}
		}
	}
}
