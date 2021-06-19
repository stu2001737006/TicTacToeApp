using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace TicTacToeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string name1 = Player1Entry.Text;
            Player1Label.Text = "Играч 1 (X): " + name1;
            Player1Entry.Text = "";
       
            string name2 = Player2Entry.Text;
            Player2Label.Text = "Играч 2 (O): " + name2;
            Player2Entry.Text = "";
        
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {

            Application.Current.MainPage = new NavigationPage(new GamePage());


        }

    }
}
