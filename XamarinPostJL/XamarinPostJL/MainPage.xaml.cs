using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPostJL
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            this.LlamadasBtn.Clicked += Llamadas;
            

		}

        private void Llamadas(object sender, EventArgs e)
        {
            NavigationPage call = new NavigationPage(new Llamada());
            call.Title = "Llamadas";
            Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(call));
        }


    }
}