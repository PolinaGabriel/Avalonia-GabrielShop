using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Linq;
using Avalonia.Input;
using System.Reflection;

namespace GabrielShop;

public partial class AdminListWindow : Window
{
    public AdminListWindow()
    {
        try
        {
            InitializeComponent();
            admShopList.ItemsSource = Assortiment.products.ToList();
            this.Show();
        }
        catch (Exception) { }
    }

    /// <summary>
    /// Добавить товар
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void AddProduct(object sender, RoutedEventArgs e)
    {
        //в сурс вводить только ссылку
        //в цену вводить только цифры и запятую

        int i = 0;
        foreach (Product product in Assortiment.products)
        {
            if (product.name == Name.Text)
            {
                i++;
            }
        }
        if (i == 0 && Name.Text != "" && Source.Text != "" && Convert.ToDouble(Price.Text) != 0 && Convert.ToDouble(Price.Text) != null)
        {
            Product newProduct = new Product()
            {
                name = Name.Text,
                source = Source.Text,
                price = Convert.ToDouble(Price.Text),
                quantity = 0,
                cost = 0
            };
            Assortiment.products.Add(newProduct);
            admShopList.ItemsSource = Assortiment.products.ToList();
            Name.Text = "";
            Source.Text = "";
            Price.Text = "";
        }
        else if (i > 0)
        {
            Ex.IsVisible = true;
        }
        else
        {
            Name.Text = "";
            Source.Text = "";
            Price.Text = "";
        }
    }

    /// <summary>
    /// Измененить товар
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void ModifyProduct(object sender, RoutedEventArgs e)
    {
        //срабатывает без выделения (пустое окно)
        
        try
        {
            RedactWindow Redact = new RedactWindow();
            Redact.Redacting(Assortiment.products[admShopList.SelectedIndex], admShopList.SelectedIndex);
            this.Close();
        }
        catch (Exception) { }
    }

    /// <summary>
    /// Удалить товар
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void DeleteProduct(object sender, RoutedEventArgs e)
    {
        try
        {
            Assortiment.products.Remove(Assortiment.products[admShopList.SelectedIndex]);
            admShopList.ItemsSource = Assortiment.products.ToList();
        }
        catch (Exception) { }
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