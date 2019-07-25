using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedProject1
{
	public interface IFirebaseCrashlyticsService 
	{
		/// <summary>
		/// Make app crash
		/// </summary>
		void CrashTest();
	}
}