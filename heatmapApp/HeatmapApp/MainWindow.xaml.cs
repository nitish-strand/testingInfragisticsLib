using Infragistics.Common.Util;
using Infragistics.Controls.Charts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;
using Infragistics;

namespace HeatmapApp
{
    public partial class MainWindow : Window
    {
        private Model model = new Model();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = model;

            updateTimer = new DispatcherTimer() { Interval = TimeSpan.FromSeconds(1.0 / 15.0) };
            updateTimer.Tick += (o, e) => model.refresh();
        }

        private DispatcherTimer updateTimer;
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton button=sender as ToggleButton;

            if(button.IsChecked.Value)
            {
                updateTimer.Start();
            }
            else
            {
                updateTimer.Stop();
            }
        }
        private void SmoothRows_Click(object sender, RoutedEventArgs e)
        {
            Heatmap.DisplayMode=Heatmap.DisplayMode^DisplayMode.Rows;
        }
        private void SmoothColumns_Click(object sender, RoutedEventArgs e)
        {
            Heatmap.DisplayMode = Heatmap.DisplayMode ^ DisplayMode.Columns;
        }
        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            Heatmap.GridDisplayMode = Heatmap.GridDisplayMode == GridDisplayMode.Before ? GridDisplayMode.Behind : GridDisplayMode.Before;
        }

        private void Heatmap_ItemMouseEnter(object sender, MouseOverEventArgs e)
        {
            MouseOver.Text = "ENTER: " + e.Row.ToString() + ", " + e.Column.ToString();
        }

        private void Heatmap_ItemMouseLeave(object sender, MouseOverEventArgs e)
        {
            MouseOver.Text = "";
        }

        private void Heatmap_ItemMouseLeftButtonDown(object sender, MouseOverEventArgs e)
        {
            MouseOver.Text = "DOWN: "+e.Row.ToString()+", "+e.Column.ToString();
        }

        private void Heatmap_ItemMouseMove(object sender, MouseOverEventArgs e)
        {
            MouseOver.Text = "MOVE: " + e.Row.ToString() + ", " + e.Column.ToString();
        }

        private void Heatmap_ItemMouseLeftButtonUp(object sender, MouseOverEventArgs e)
        {
            MouseOver.Text = "UP: " + e.Row.ToString() + ", " + e.Column.ToString();
        }

    }
}
