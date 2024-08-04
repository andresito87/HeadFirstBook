using PickRandomCards;

namespace PickRandomCardsMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PickCardsBtn_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(NumberOfCards.Text, out int amountOfCards))
            {
                Cards.Text = String.Empty;
                string[] cardsPicked = new string[amountOfCards];
                cardsPicked = CardPicker.PickSomeCards(amountOfCards);

                foreach (string card in cardsPicked)
                {
                    if (!String.IsNullOrEmpty(Cards.Text))
                    {
                        Cards.Text += Environment.NewLine + card.ToString();
                    }
                    else
                    {
                        Cards.Text = card.ToString();
                    }
                }
                Cards.Text += Environment.NewLine + "You picked " + amountOfCards + " cards.";
            }
            else
            {
                Cards.Text = "Please enter a valid number.";
            }
        }
    }
}
