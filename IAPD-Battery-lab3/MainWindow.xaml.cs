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
using System.Management;
using IAPD_Battery_lab3;

namespace IAPD_Battery_lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            initText();
        }

        private void initText()
        {
            Battery battery = new Battery();
            PowerType.Text = battery.getPowerType();
            Charge.Text = battery.getChargeLevel();
            TimeLeft.Text = battery.getTime();
        }
    }
}
