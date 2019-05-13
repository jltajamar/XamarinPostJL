using Plugin.Messaging;
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
	public partial class Llamada : ContentPage
	{
        public Llamada()
        {
            InitializeComponent();
            this.BtnCall.Clicked += BCall;
        }

        private void BCall(object sender, EventArgs e)
        {
            var call = CrossMessaging.Current.PhoneDialer;

            if (call.CanMakePhoneCall)
                call.MakePhoneCall(PhoneNumber.Text);

            //throw new NotImplementedException();
        }
    }
}