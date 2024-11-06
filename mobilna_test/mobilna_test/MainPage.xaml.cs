using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna_test
{
    public partial class MainPage : TabbedPage
    {
        private int total = 0;
        public MainPage()
        {
            InitializeComponent();
            for(int i = 0; i < 5; i++)
            {
                dices.Children.Add(new Image() { Source = ImageSource.FromFile("question.png"), Margin = 5  });
            }
        }

        private void ThrowDices(object sender,EventArgs e)
        {
            Random rnd = new Random();
            List<int> dices_thrown = new List<int>();
            List<int> dices_counts = new List<int>() { 0, 0, 0, 0, 0, 0 };
            for(int i = 0; i < 5; i++)
            {
                int dice = rnd.Next(0, 6);
                dices_counts[dice]++;
                dices_thrown.Add(dice + 1);
            }

            
            dices.Children.Clear();
            foreach(int dice in dices_thrown)
            {
                dices.Children.Add(new Image() { Source = ImageSource.FromFile("liczba" + dice.ToString() + ".png"), Margin = 5 });
            }

            int points_counted = 0;
            for(int i = 0; i < dices_counts.Count; i++)
            {
                if (dices_counts[i] > 1)
                {
                    points_counted += (i + 1) * dices_counts[i];
                }
            }
            total += points_counted;
            resultNow.Text = "Wynik tego losowania: " + points_counted.ToString();
            result.Text = "Wynik gry: " + total.ToString();
        }

        private void Reset(object sender, EventArgs e)
        {
            resultNow.Text = "Wynik tego losowania: 0";
            result.Text = "Wynik gry: 0";
            total = 0;
        }
    }
}
