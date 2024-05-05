using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GabrielShop;

public partial class UserCartWindow : Window
{
    public List<Product> cart = new List<Product>(); 
    
    public UserCartWindow()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Заполнение списка покупок
    /// </summary>
    /// <param name="productsChosen"></param>
    public void OrderList(List<Product> productsChosen)
    {
        cart = productsChosen.ToList();
        orderListBox.ItemsSource = cart.ToList();
        this.Show();
    }

    /// <summary>
    /// Добавить в корзину
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void AddToCart(object? sender, RoutedEventArgs e)
    {
        //проблемы с выделением

        try
        {
            cart[orderListBox.SelectedIndex].quantity++;
            cart[orderListBox.SelectedIndex].cost = cart[orderListBox.SelectedIndex].price * cart[orderListBox.SelectedIndex].quantity;
            orderListBox.ItemsSource = cart.ToList();
        }
        catch (Exception) { }
    }

    /// <summary>
    /// Удалить из корзины
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DeleteFromCart(object sender, RoutedEventArgs e)
    {
        //проблемы с выделением

        try
        {
            if (cart[orderListBox.SelectedIndex].quantity != 0)
            {
                cart[orderListBox.SelectedIndex].quantity--;
                cart[orderListBox.SelectedIndex].cost = cart[orderListBox.SelectedIndex].price * cart[orderListBox.SelectedIndex].quantity;
                orderListBox.ItemsSource = cart.ToList();
            }
        }
        catch (Exception) { }
    }

    /// <summary>
    /// Вернуться к списку покупок
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void GoToList(object sender, RoutedEventArgs e)
    {
        foreach (Product product in cart)
        {
            product.quantity = 0;
        }
        UserListWindow UserList = new UserListWindow();
        UserList.Show();
        this.Close();
    }

    /// <summary>
    /// Сменить пользователя
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void ChangeUser(object sender, RoutedEventArgs e)
    {
        MainWindow MainWindow = new MainWindow();
        MainWindow.Show();
        this.Close();
    }
}