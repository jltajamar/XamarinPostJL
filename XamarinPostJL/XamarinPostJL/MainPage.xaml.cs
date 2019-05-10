using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPostJL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BtnCall.Clicked += BtnCall_Clicked;
        }

        private void BtnCall_Clicked(object sender, EventArgs e)
        {
            var call = CrossMessaging.Current.PhoneDialer;

            if (call.CanMakePhoneCall)
                call.MakePhoneCall(PhoneNumber.Text);

            //throw new NotImplementedException();
        }

       
    }
}
