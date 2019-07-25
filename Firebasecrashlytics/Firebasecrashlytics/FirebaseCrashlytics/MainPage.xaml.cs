using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedProject1;
using Xamarin.Forms;

namespace FirebaseCrashlytics
{
	public partial class MainPage : Page
	{
		private IFirebaseCrashlyticsService _firebaseCrashlyticsService;

		public MainPage()
		{
			_firebaseCrashlyticsService = new FirebaseCrashlyticsService();
			InitializeComponent();
		}

		public void CrashTest()
		{
			_firebaseCrashlyticsService.CrashTest();
		}
	}
}
