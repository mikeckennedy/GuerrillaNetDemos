﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TraditionalAsync.ViewModels;

namespace TraditionalAsync
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            int await = 1;


            var model = new ViewModels.PictureTransformer(System.IO.Path.GetFullPath(@"..\..\..\Images"));
            var view = new Views.PickImageView();

            //var model = new ViewModels.AllPicturesTransform(System.IO.Path.GetFullPath(@"..\..\..\Images"));
            //var view = new Views.AllPicturesView();

            DataContext = model;
            Content = view;
        }
    }
}