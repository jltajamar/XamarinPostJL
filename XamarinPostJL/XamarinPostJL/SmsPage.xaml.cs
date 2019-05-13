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
	public partial class SmsPage : ContentView
	{
		public SmsPage ()
		{
			InitializeComponent ();
            this.BtnSMS.Clicked += SendSMS;
        }

        private void SendSMS(object sender, EventArgs e)
        {
            var sms = CrossMessaging.Current.SmsMessenger;


            if (sms.CanSendSms)
                sms.SendSms(SMSPhoneNumber.Text, SMSBody.Text);

            //throw new NotImplementedException();
        }

    }
}