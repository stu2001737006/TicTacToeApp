using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicTacToeApp
{
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            InitializeComponent();
        }

        int count = 0;

        /*void checkwinner(string symbol) 
        {
            if (button1.Text == symbol || button2.Text == symbol || button3.Text == symbol)
            {
                MessageBox.Show(symbol+"Won the game");
            }
        } */
        void Fnsymbol(object senderobj) 
        {
            string buttontxt = ((Button)senderobj).Text;
            if (buttontxt == "")
            {
                if (count % 2 == 0)
                {
                    ((Button)senderobj).Text = "O";
                }
                else
                {
                    ((Button)senderobj).Text = "X";
                }
                count++;
            }
          
        }

        private void Button1_clicked(object sender, EventArgs e) 
        {
            Fnsymbol(sender);
        }
        private void Button2_clicked(object sender, EventArgs e)
        {
            Fnsymbol(sender);
        }
        private void Button3_clicked(object sender, EventArgs e)
        {
            Fnsymbol(sender);
        }
        private void Button4_clicked(object sender, EventArgs e)
        {
            Fnsymbol(sender);
        }
        private void Button5_clicked(object sender, EventArgs e)
        {
            Fnsymbol(sender);
        }
        private void Button6_clicked(object sender, EventArgs e)
        {
            Fnsymbol(sender);
        }
        private void Button7_clicked(object sender, EventArgs e)
        {
            Fnsymbol(sender);
        }
        private void Button8_clicked(object sender, EventArgs e)
        {
            Fnsymbol(sender);
        }
        private void Button9_clicked(object sender, EventArgs e)
        {
            Fnsymbol(sender);
        }
        private void BtnNewGame_Click(object sender, EventArgs e) 
        {
            
        }

        private void ContentView_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}