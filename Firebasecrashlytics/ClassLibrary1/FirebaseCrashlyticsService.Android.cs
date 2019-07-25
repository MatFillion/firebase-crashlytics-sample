using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary1
{
	public partial class FirebaseCrashlyticsService
	{
		public FirebaseCrashlyticsService()
		{

		}

		private void CrashTestInner()
		{
			Crashlytics.Crashlytics.Instance.Crash();
		}
	}
}