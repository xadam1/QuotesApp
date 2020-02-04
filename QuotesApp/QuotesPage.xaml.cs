using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuotesApp
{
    public partial class QuotesPage : ContentPage
    {
        private string[] quotes = {
            "Be yourself, everyone else is already taken.",
            "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
            "In three words I can sum up everything I've learned about life: it goes on.",
            "I've learned that people will forget what you said, people will forget what you did, but people will never forget how you made them feel.",
            "Always forgive your enemies; nothing annoys them so much."
        };

        private int quoteNum;


        public QuotesPage()
        {
            InitializeComponent();

            Padding = new Thickness(20);

            currentQuote.Text = quotes[quoteNum];
        }

        public void BtnClicked(object sender, EventArgs e)
        {
            quoteNum++;
            if (quoteNum >= quotes.Length)
            {
                quoteNum = 0;
            }

            currentQuote.Text = quotes[quoteNum];

        }

    }
}
