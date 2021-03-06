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

namespace BSControl.UserControls
{
    /// <summary>
    /// Interaction logic for PageTitleUserControl.xaml
    /// </summary>
    public partial class PageTitleUserControl : UserControl
    {
        public PageTitleUserControl()
        {
            InitializeComponent();
        }

        public string txtPageTitle
        {
            get { return this.PageTitle.Content.ToString(); }
            set { this.PageTitle.Content = value; }
        }
    }
}
