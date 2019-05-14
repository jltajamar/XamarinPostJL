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
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.LlamadasBtn.Clicked += Llamadas;
            this.BtnSendSMS.Clicked += Sms;
            this.BtnSendEmail.Clicked += EmailSend;
            this.Sos.Clicked += Emergencias;

        }

        private void Llamadas(object sender, EventArgs e)
        {
            var call = CrossMessaging.Current.PhoneDialer;

            if (call.CanMakePhoneCall)
                call.MakePhoneCall(PhoneNumber.Text);
        }


        private void Sms(object sender, EventArgs e)
        {
            var sms = CrossMessaging.Current.SmsMessenger;
            

            if (sms.CanSendSms)
                sms.SendSms(SMSPhoneNumber.Text, SMSMessage.Text);
        }

        private void EmailSend(object sender, EventArgs e)
        {
            var email = CrossMessaging.Current.EmailMessenger;

            //if (em.CanSendEmail)
            //em.SendEmail(Email.Text, Subject.Text, Body.Text);

            if (email.CanSendEmail)
                email.SendEmail(nEmail.Text, Subject.Text, Body.Text);
            /*
            var email = new EmailMessageBuilder()
     .To(new[] { "emailsender@askxammy.com","email@askxammy.com"})
     .Cc("emailwithcopy@askxammy.com")
     .Bcc("emailwithhiddencopy@askxammy.com")
     .Subject("Hello!")
     .Body("This is a message for you <3!!")
     .WithAttachment("FilePath", "ContenctType").Build();

            em.SendEmail(email);
            */

        }

        private void Emergencias(object sender, EventArgs e)
        {
            var call = CrossMessaging.Current.PhoneDialer;

            if (call.CanMakePhoneCall)
                call.MakePhoneCall("911");
        }

    }
}