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
        public MainPage()
        {
            InitializeComponent();
            for(int i = 0; i < 5; i++)
            {
                dices.Children.Add(new Image() { Source = ImageSource.FromFile("question.png"), Margin = 5  });
            }
        }
    }
}
