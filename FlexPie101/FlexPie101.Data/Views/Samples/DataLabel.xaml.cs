﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexPieDemo.Data.Model;
using Xamarin.Forms;
using Xuni.Forms.ChartCore;
using Xuni.Forms.FlexPie;
using System.Reflection;
using FlexPieDemo.Data.Resources;
namespace FlexPieDemo.Data.Views.Samples
{
    public partial class DataLabel
    {
        public DataLabel()
        {
            InitializeComponent();
            Title = AppResources.DataLabelsTitle;
            this.flexPie.ItemsSource = PieChartSampleFactory.CreateEntiyList();
            this.flexPie.Palette = Xuni.Forms.ChartCore.ChartPalettes.Organic;

            foreach (var item in Enum.GetNames(typeof(PieLabelPosition)))
            {
                this.pickPostion.Items.Add(item);
            }
            this.pickPostion.SelectedIndex = 2;
        }
        void pickPostion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.flexPie.DataLabel.Position = (PieLabelPosition)Enum.Parse(typeof(PieLabelPosition), this.pickPostion.Items[this.pickPostion.SelectedIndex]);
        }
    }
}
