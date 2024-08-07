﻿namespace SloppyJoe
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            MakeTheMenu();

            this.item1.SetValue(SemanticProperties.DescriptionProperty,
            "Here are the items on the menu. " + this.item1.Text);

        }

        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[6];

            for (int i = 0; i < menuItems.Length; i++)
            {
                menuItems[i] = new MenuItem();
                menuItems[i].Generate();
            }

            price1.Text = menuItems[0].Price;
            item1.Text = menuItems[0].Description;
            price2.Text = menuItems[1].Price;
            item2.Text = menuItems[1].Description;
            price3.Text = menuItems[2].Price;
            item3.Text = menuItems[2].Description;
            price4.Text = menuItems[3].Price;
            item4.Text = menuItems[3].Description;
            price5.Text = menuItems[4].Price;
            item5.Text = menuItems[4].Description;
            price6.Text = menuItems[5].Price;
            item6.Text = menuItems[5].Description;

            MenuItem guacamoleMenuItem = new MenuItem();
            guacamoleMenuItem.Generate();
            guacamole.Text = "Add guacamole for " + guacamoleMenuItem.Price;

        }

    }

}
