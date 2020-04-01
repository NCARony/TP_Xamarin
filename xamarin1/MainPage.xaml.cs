using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Connection_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Connection is Clicked");
            string identifiant = this.idEntry.Text;
            string passwd = this.pwdEntry.Text;
            Boolean remember = this.remember.IsToggled;
            
            this.HideError();
            
            if (String.IsNullOrEmpty(identifiant) || identifiant.Length < 3)
            {
                this.ShowError("Veuillez entrez un identifiant d'au moins 3 carractères");
            }

            if (String.IsNullOrEmpty(passwd) || passwd.Length < 6)
            {
                this.ShowError("Veuillez entrez un mot de passe d'au moins 6 carractères");
            }

        }

        private void HideError()
        {
            this.error.IsVisible = false;
        }

        private void ShowError(string message)
        {
            this.error.IsVisible = true;
            this.error.Text = message;
            return;
        }

    }
}
