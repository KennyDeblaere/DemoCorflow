using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace democorflow
{
	public class CRMPage : ContentPage
	{
		private ListView _itemsList = new ListView();
        private SearchBar _searchbar = new SearchBar() { Placeholder="Zoeken" };
        private StackLayout _layout = new StackLayout();
        private ObservableCollection<Contactpersoon> personen;
        private List<Contactpersoon> houdPersonen;

        public ObservableCollection<Contactpersoon> Personen
        {
            get { return personen; }
            set { personen = value; OnPropertyChanged("Personen"); }
        }

		public CRMPage ()
		{
			Title = "CRM";
			Icon = "Contracts.png";

            houdPersonen = (List<Contactpersoon>)DependencyService.Get<IDataService>().LoadAll<Contactpersoon>();
            Personen = (ObservableCollection<Contactpersoon>)DependencyService.Get<IDataService>().LoadAll<Contactpersoon>();

			Padding = new Thickness(0,Device.OnPlatform(20,0,0),0,0);


			_itemsList.ItemSelected += (sender, e) => {
				//listview.SelectedItem = null;
				//Navigation.PushAsync(new wer(e.SelectedItem.ToString()));
				this.Navigation.PushAsync(new CRMDetailPage(e.SelectedItem as Contactpersoon));
			};

            _itemsList.ItemsSource = Personen;

            _searchbar.TextChanged += (sender, e) => Filter(_searchbar.Text);

            _layout.Children.Add(_searchbar);
            _layout.Children.Add(_itemsList);

			Content = _layout;

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

        private void Filter(string text)
        {
            Personen.Clear();
            houdPersonen.Where(t => t.voornaam.ToLower().Contains(text.ToLower())).ToList().ForEach(t => Personen.Add(t));
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


