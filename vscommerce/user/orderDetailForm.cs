﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace vscommerce.user
{
    public partial class orderDetailForm : MaterialForm
    {
        private Order.Order order;
        public orderDetailForm(Order.Order order)
        {
            this.order = order;
            InitializeComponent();
            MaterialSkinManager materialUIManager = MaterialSkinManager.Instance;
            materialUIManager.AddFormToManage(this);
            materialUIManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialUIManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.Orange200,
                TextShade.WHITE
                );
            loadDetails();

        }
        private void loadDetails()
        {
            IDOrderPlaceHolder.Text = order.ID.ToString();
            customerPlaceHolder.Text = order.customer.name + " " + order.customer.surname;
            datePlaceHolder.Text = order.date.ToString();
            totalPlaceHolder.Text = order.total.ToString();

            orderLineListView.View = View.Details;
            orderLineListView.Columns.Add("ID", 50, HorizontalAlignment.Left);
            orderLineListView.Columns.Add("Prodotto", 200, HorizontalAlignment.Left);
            orderLineListView.Columns.Add("prezzo", 100, HorizontalAlignment.Left);
            orderLineListView.Columns.Add("Quantita", 100, HorizontalAlignment.Left);
            orderLineListView.Columns.Add("Subtotale", 100, HorizontalAlignment.Left);
            foreach (var orderLine in order.orderLines)
            {
                orderLineListView.Items.Add(new ListViewItem(new string[] {orderLine.product.ID.ToString(),
                orderLine.product.name, orderLine.priceUnit.ToString(), orderLine.qty.ToString(), (orderLine.priceUnit*orderLine.qty).ToString()}));
            }
            orderLineListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            orderLineListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void orderDetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
