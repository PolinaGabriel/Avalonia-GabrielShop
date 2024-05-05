using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace GabrielShop;

public partial class RedactWindow : Window
{
    public int index = -1;
    
    public RedactWindow()
    {
        InitializeComponent();
        this.Show();
    }

    /// <summary>
    /// Окно редактирования
    /// </summary>
    /// <param name="product"></param>
    /// <param name="i"></param>
    public void Redacting(Product product, int j)
    {
        redName.Text = product.name;
        redSource.Text = product.source;
        redPrice.Text = Convert.ToString(product.price);
        index = j;
    }

    /// <summary>
    /// Сохранить изменения 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void Save(object sender, RoutedEventArgs e)
    {
        //в сурс вводить только ссылку
        //в цену вводить только цифры и запятую

        int i = 0;
        foreach (Product product in Assortiment.products)
        {
            if (Assortiment.products.IndexOf(product) != index && product.name == redName.Text)
            {
                i++;
            }
        }
        if (i == 0 && redName.Text != "" && redSource.Text != "" && Convert.ToInt32(redPrice.Text) != 0 && Convert.ToDouble(redPrice.Text) != 0)
        { 
            Assortiment.products[index].name = redName.Text;
            Assortiment.products[index].source = redSource.Text;
            Assortiment.products[index].price = Convert.ToDouble(redPrice.Text);
            AdminListWindow AdminList = new AdminListWindow();
            AdminList.Show();
            this.Close();
        }
        else if (i > 0)
        {
            redEx.IsVisible = true;
        }
        else
        {
            redName.Text = Assortiment.products[index].name;
            redSource.Text = Assortiment.products[index].source;
            redPrice.Text = Convert.ToString(Assortiment.products[index].price);
        }
    }

    /// <summary>
    /// Отменить редактирование
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void Cancel(object sender, RoutedEventArgs e)
    {
        AdminListWindow AdminList = new AdminListWindow();
        AdminList.Show();
        this.Close();
    }
}