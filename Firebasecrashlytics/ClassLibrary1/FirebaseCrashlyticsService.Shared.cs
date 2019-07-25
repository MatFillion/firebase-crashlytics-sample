using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary1
{
	public partial class FirebaseCrashlyticsService : IFirebaseCrashlyticsService
	{
		public void CrashTest()
		{
			CrashTestInner();
		}
	}
}