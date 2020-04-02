using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xamarin1.models;
using xamarin1.services;
using Xamarin.Essentials;

namespace xamarin1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ITwitterServices twitterService;
        public MainPage()
        {
            InitializeComponent();
            this.btnConnexion.Clicked += Connection_Clicked;
            this.tweetList.IsVisible = false;
            this.error.IsVisible = false;
            this.twitterService = new TwitterService();

        }

        private void Connection_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Connection is Clicked");
            string identifiant = this.idEntry.Text;
            string passwd = this.pwdEntry.Text;
            Boolean remember = this.remember.IsToggled;

            String errors = "";

            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                errors = this.twitterService.authenticate(new User() { Login = identifiant, Password = passwd });

            } else {

                errors = "aucune connection disponible";
            }

            if (!String.IsNullOrEmpty(errors))
            {
                this.error.Text = errors;
                this.error.IsVisible = true;

            } else {

                this.error.Text = "";
                this.error.IsVisible = false;
                this.connexionForm.IsVisible = false;
                this.tweetList.IsVisible = true;
            }
        }
    }
}
