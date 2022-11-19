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
using TRPO_LAB.Classes;
using TRPO_LAB.Pages;

namespace TRPO_LAB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static TextBlock error;
        public MainWindow()
        {
            InitializeComponent();

            Manager.MainFrame = MainFrame;
            Manager.CurrentPage = new WelcomePage();
            Manager.MainFrame.Navigate(Manager.CurrentPage);
            error = tbError;

            Classes.DataContext.addUser("123456", 250, 200, 500);
            Classes.DataContext.addUser("654321", 0, 0, 200);
            Classes.DataContext.addUser("123321", 0, 0, 0);
        }

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            AtmManager.context += (sender as Button).Content;

            if (Manager.CurrentPage.GetType().ToString() == "TRPO_LAB.Pages.WelcomePage")
            {
                WelcomePage.account.Text = AtmManager.context;
            }
        }

        private void btnDo_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button) == btnDel)
            {
                AtmManager.context = "";                
            }
            else if ((sender as Button) == btnCancel)
            {
                if (MainFrame.CanGoBack)
                    Manager.MainFrame.GoBack();
                MainWindow.error.Text = "";
            }
            if (Manager.CurrentPage.GetType().ToString() == "TRPO_LAB.Pages.WelcomePage")
            {
                WelcomePage.account.Text = AtmManager.context;
            }
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            
        }

        private void btnSpecial_Click(object sender, RoutedEventArgs e)
        {
            int result = Convert.ToInt32(AtmManager.context) + Convert.ToInt32((sender as Button).Content);
            AtmManager.context += result;
            MainFrame.Refresh();
        }
    }
}
