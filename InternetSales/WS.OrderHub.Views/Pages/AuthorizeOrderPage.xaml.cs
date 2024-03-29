﻿using System;
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

namespace WS.OrderHub.Views.Pages
{
    /// <summary>
    /// Interaction logic for AuthorizeOrderViewModel.xaml
    /// </summary>
    public partial class AuthorizeOrderPage : Page
    {

        private static AuthorizeOrderPage instance;
        public static AuthorizeOrderPage Instance
        {
            get
            {
                if (instance == null)
                    instance = new AuthorizeOrderPage();
                return instance;
            }
        }
        public AuthorizeOrderPage()
        {
            InitializeComponent();
        }
    }
}
