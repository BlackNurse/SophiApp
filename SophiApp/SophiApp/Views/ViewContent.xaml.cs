﻿using SophiApp.Interfaces;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace SophiApp.Views
{
    /// <summary>
    /// Логика взаимодействия для ViewContent.xaml
    /// </summary>
    public partial class ViewContent : UserControl
    {
        // Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(ViewContent), new PropertyMetadata(default(string)));

        // Using a DependencyProperty as the backing store for Header.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(string), typeof(ViewContent), new PropertyMetadata(default(string)));

        // Using a DependencyProperty as the backing store for Tag.  This enables animation, styling, binding, etc...
        public static readonly new DependencyProperty TagProperty =
            DependencyProperty.Register("Tag", typeof(string), typeof(ViewContent), new PropertyMetadata(default(string)));

        public ViewContent()
        {
            InitializeComponent();
        }

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public new string Tag
        {
            get { return (string)GetValue(TagProperty); }
            set { SetValue(TagProperty, value); }
        }

        private void FilterByTag(object sender, FilterEventArgs e) => e.Accepted = (e.Item as IUIElementModel).Tag == Tag;

        private void UIElement_MouseEnter(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Description = e.OriginalSource as string;
        }

        private void UIElement_MouseLeave(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Description = string.Empty;
        }
    }
}