using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Xamarin.Forms;

namespace democorflow
{
	public class CRMPage : ContentPage
	{
		ListView _itemsList = new ListView();

		public CRMPage ()
		{
			Title = "CRM";
			Icon = "Contracts.png";

			Padding = new Thickness(0,Device.OnPlatform(20,0,0),0,0);


			_itemsList.ItemSelected += (sender, e) => {
				//listview.SelectedItem = null;
				//Navigation.PushAsync(new wer(e.SelectedItem.ToString()));
				this.Navigation.PushAsync(new CRMDetailPage(e.SelectedItem as Contactpersoon));
			};

			_itemsList.ItemTemplate = new DataTemplate (typeof(ContactpersoonCell));

			Content = _itemsList;

			/*ToolbarItems.Add(new ToolbarItem()
				{
					Text = "Sync"
						, Icon = (Device.OS == TargetPlatform.WinPhone) ? "refresh.png" : null
						, Order = ToolbarItemOrder.Primary,
					Command = new Command(() =>
						{
							Sync ();
						})
				});*/
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			try
			{
				_itemsList.ItemsSource = await Task<IList<Contactpersoon>>.Run(() =>
						{
						return DependencyService.Get<IDataService>().LoadAll<Contactpersoon>();
						});
			}
			catch (Exception e)
			{
				if (e.Message.StartsWith("no such table"))
					this.DisplayAlert("Exception", "A sync hasn't been performed yet.  Please sync.", "Ok");
				else
					this.DisplayAlert("Exception", e.Message, "Ok");
			}
		}
	}
}


