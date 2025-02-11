﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WarehousClosingClient.Models;

namespace WarehousClosingClient.Views.SupplyView.Rows;

public partial class ProductShortRow : UserControl
{
    public Product product;

    public ProductShortRow(Product product)
    {
        this.product = product;

        InitializeComponent();
        InitData();
        
    }



    private void InitData()
    {
        label3.Text = product.Name.ToString();
        label4.Text = product.Price.ToString("0.00");
    }

    public void SetQuantity(int quantity)
    {
        numericUpDown1.Value = quantity;
    }

    public int GetQuantity()
    {
        return int.Parse(numericUpDown1.Value.ToString());
    }
}
