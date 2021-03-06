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
    /// Interaction logic for AnalogCardUserControl.xaml
    /// </summary>
    public partial class AnalogCardUserControl : UserControl
    {
        public string txtCardName
        {
            get { return this.CardName.Content.ToString(); }
            set { this.CardName.Content = value; }
        }

        public string txtCardValue
        {
            get { return this.CardValue.Text.ToString(); }
            set { this.CardValue .Text= value; }
        }


        public AnalogCardUserControl()
        {
            InitializeComponent();
        }
    }
}
