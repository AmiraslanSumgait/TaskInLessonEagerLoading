using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfTaskInLesson.DataAccess.Abstract;
using WpfTaskInLesson.DataAccess.Concrete;
using WpfTaskInLesson.Models;

namespace WpfTaskInLesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GenericRepository<Product> _reposProduct=new GenericRepository<Product>();
        GenericRepository<Category> _reposCategory=new GenericRepository<Category>();
        public MainWindow()
        {
            InitializeComponent();
            //Product p1 = new Product() { ProductName = "Hp", Price = 1100,Units=3};
            //Product p2= new Product() { ProductName = "Iphone", Price = 2500,Units=6};
            //Product p3 = new Product() { ProductName = "Rog", Price = 3600,Units=1};
            //Product p4 = new Product() { ProductName = "Xiaomi", Price = 700,Units=2};
            //_reposProduct.Insert(p1);
            //_reposProduct.Insert(p2);
            //_reposProduct.Insert(p3);
            //_reposProduct.Insert(p4);
            //Category c1 = new Category() { Name = "Notebook" };
            //Category c2 = new Category() { Name = "Phone" };
            //_reposCategory.Insert(c1);
            //_reposCategory.Insert(c2);
            //c1.Products?.Add(p1);
            //c2.Products?.Add(p2);
            //c1.Products?.Add(p3);
            //c2.Products?.Add(p4);
            //_reposProduct.SaveChanges();
            //_reposCategory.SaveChanges();
            var categories = _reposCategory.GetAll().Include(c => c.Products).ToList();
            datagridCategories.ItemsSource=categories;

        }

        private void datagridCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var products = _reposProduct.Query(p => p.Category.Name == (datagridCategories.SelectedItem as Category).Name).ToList();
            datagridProducts.ItemsSource = products;
        }
    }
}
