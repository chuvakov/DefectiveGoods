using DefectiveGoods.Core;
using DefectiveGoods.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DefectiveGoods
{
    public partial class MainWindow : Form
    {
        private readonly DefectiveGoodsContext _dbContext = new DefectiveGoodsContext();

        public MainWindow()
        {
            InitializeComponent();
            RefreshTableProducts();
        }

        private void RefreshTableProducts()
        {
            bindingSourceProducts.DataSource = _dbContext.Products.ToList();
            dataGridViewProducts.DataSource = bindingSourceProducts.DataSource;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow();
            addProductWindow.ShowDialog();

            RefreshTableProducts();
        }

        private void ButtonRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows == null || dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Невыбран продукт");
                return;
            }

            Product product = dataGridViewProducts.SelectedRows[0].DataBoundItem as Product;

            if (product == null)
            {
                MessageBox.Show("Неудалось преобразовать строку таблицы в продукт");
                return;
            }

            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();

            RefreshTableProducts();
        }             

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _dbContext.Dispose();
        }
    }
}
