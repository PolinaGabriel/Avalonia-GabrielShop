using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Linq;

namespace GabrielShop;

public partial class UserListWindow : Window
{
    public List<Product> productsChosen = new List<Product>();

    public UserListWindow()
    {
        InitializeComponent();
        shopList.ItemsSource = Assortiment.products.ToList();
        this.Show();
    }

    /// <summary>
    /// ќформить заказ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void MakeOrder(object sender, RoutedEventArgs e)
    {
        foreach (Product product in Assortiment.products)
        {
            foreach (Product item in shopList.SelectedItems)
            {
                if (product.name == item.name)
                {
                    productsChosen.Add(product);
                }
            }
        }
        UserCartWindow UserCart = new UserCartWindow();
        UserCart.OrderList(productsChosen);
        this.Close();
    }
}