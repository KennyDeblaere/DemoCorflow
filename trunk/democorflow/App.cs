using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(democorflow.DataService))]
namespace democorflow
{
	public class App : Application
	{
		private bool _isLoggedIn = false;
		public bool IsLoggedIn {
			get { return _isLoggedIn; }
			set { _isLoggedIn = value; }
		}

		public App ()
		{
			// The root page of your application
			if (_isLoggedIn)
				MainPage = new RootPage ();
			else
				MainPage = new LoginPage ();

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

		public void ShowMainPage ()
		{
			MainPage = new RootPage ();
		}

		public void Logout ()
		{
			_isLoggedIn = false;
			MainPage = new LoginPage ();
		}
}

}

