using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using Xamarin.Forms;

[assembly: Dependency(typeof(democorflow.Droid.SHA1Service))]
namespace democorflow.Droid
{
	public class SHA1Service : democorflow.ISHA1Service
	{
		public string HashString(string input)
		{
			byte[] jsonBytes = Encoding.UTF8.GetBytes(input);
			var sha1 = SHA1.Create();
			byte[] hashBytes = sha1.ComputeHash(jsonBytes);

			var sb = new StringBuilder();
			foreach (byte b in hashBytes)
			{
				var hex = b.ToString("X2");
				sb.Append(hex);
			}
			return sb.ToString();
		}
	}

	[Activity(Label = "democorflow", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);



			var sqliteFilename = "data.db3";
			string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);
			App.DatabasePath = path;

			LoadApplication(new democorflow.App());
		}
	}
}

