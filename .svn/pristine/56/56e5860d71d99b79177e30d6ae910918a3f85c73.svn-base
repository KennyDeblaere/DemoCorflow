using System;

using Xamarin.Forms;

namespace democorflow
{
	public class LoginPage : ContentPage
	{
		private StackLayout _layout;
		private Label _label;
		private Entry _username;
		private Entry _password;
		private Button _button;

		private SyncParams _syncParams = null;
		private bool _syncInProgress = false;

		public bool IsSyncInProgress {
			get { return _syncInProgress; }
			set { _syncInProgress = value; OnPropertyChanged("IsSyncInProgress");  } 
		}

		public SyncParams Params
		{
			get { return _syncParams; }
			set { ; }
		}


		public LoginPage ()
		{
			_syncParams = SyncParams.LoadSavedSyncParams();

			_layout = new StackLayout { Padding = 10 };

			_label = new Label
			{
				Text = "Login",
				Font = Font.BoldSystemFontOfSize(NamedSize.Large),
				TextColor = Color.White,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				XAlign = TextAlignment.Center, // Center the text in the blue box.
				YAlign = TextAlignment.Center, // Center the text in the blue box.
			};


			_username = new Entry { Placeholder = "Username" };

			_password = new Entry { Placeholder = "Password", IsPassword = true };



			_button = new Button { Text = "Sign In", TextColor = Device.OnPlatform(Color.Black,Color.White,Color.White)};
			_button.Clicked += (sender, e) => {
				Navigation.PopModalAsync();
			};
			Content = new ScrollView { Content = _layout };
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			((democorflow.App)Xamarin.Forms.Application.Current).SyncCompleted += SyncCompleted;
			((democorflow.App)Xamarin.Forms.Application.Current).SyncFailed += SyncFailed;

			Sync ();
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			((democorflow.App)Xamarin.Forms.Application.Current).SyncCompleted -= SyncCompleted;
			((democorflow.App)Xamarin.Forms.Application.Current).SyncFailed -= SyncFailed;
		}

		void SyncCompleted(object sender, SyncParams e)
		{
			Device.BeginInvokeOnMainThread(() =>
				{
					//if (!ZagDebugSchemaVersionCheck.VerifySchema())
					//this.DisplayAlert("Database Schema Changed", "The schema for the database has been changed since this application was generated.  This may cause failures if columns have been removed.  You may want to use Zumero Application Generator to recreate this app, based on the new schema.", "Ok");
					_syncParams.SaveSyncParam();
					this.IsSyncInProgress = false;

					_layout.Children.Add(_label);
					_layout.Children.Add(_username);
					_layout.Children.Add(_password);
					_layout.Children.Add(_button);
				});
		}

		void SyncFailed(object sender, Exception e)
		{
			Device.BeginInvokeOnMainThread(() =>
				{
					this.IsSyncInProgress = false;
					this.DisplayAlert("Exception", e.Message, "Ok");
				});
		}

		public void Sync()
		{
			this.IsSyncInProgress = true;
			DependencyService.Get<ISyncService>().StartBackgroundSync(_syncParams);
		}
	}
}


