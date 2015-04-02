using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(democorflow.DataService))]
namespace democorflow
{
	public class App : Application, ILoginManager
	{


		public App ()
		{
			// The root page of your application
			MainPage = new RootPage();

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

	
		public event EventHandler<Exception> SyncFailed = delegate { };

		public void NotifySyncFailed(Exception e)
		{
			if (SyncFailed != null)
				SyncFailed(this, e);
		}

		public event EventHandler<SyncParams> SyncCompleted = delegate { };

		public void NotifySyncCompleted(SyncParams p)
		{
			if (SyncCompleted != null)
				SyncCompleted(this, p);
		}

		public static string DatabasePath { get; set; }
}

}

