﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpfplayground.ViewModels;

namespace wpfplayground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainWindowViewModel();
        }


        private void ChatWindowBackground_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove(); // make window move
            }
        }

        bool isMaximized = false;
        private void ChatWindowBackground_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (isMaximized)    
                {
                    // make window normal
                    this.WindowState = WindowState.Normal;
                    this.Width = 1250;
                    this.Height = 830;
                }
                else                
                {
                    // make window maximized
                    this.WindowState = WindowState.Maximized;
                }

                isMaximized = !isMaximized;
            }
        }
    }
}