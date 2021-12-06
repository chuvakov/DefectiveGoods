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

        private void ButtonSearchProduct_Click(object sender, EventArgs e)
        {
            string searchValue = TextBoxSearch.Text;

            if (radioButtonProductCode.Checked)
            {
                bindingSourceProducts.DataSource = _dbContext.Products.Where(x => x.Code.Contains(searchValue)).ToList();
                dataGridViewProducts.DataSource = bindingSourceProducts.DataSource;
            }
            else if (radioButtonName.Checked)
            {
                bindingSourceProducts.DataSource = _dbContext.Products.Where(x => x.Name.Contains(searchValue)).ToList();
                dataGridViewProducts.DataSource = bindingSourceProducts.DataSource;
            }
            else if (radioButtonArrivalNumber.Checked)
            {
                bindingSourceProducts.DataSource = _dbContext.Products.Where(x => x.ArrivalNumber.Contains(searchValue)).ToList();
                dataGridViewProducts.DataSource = bindingSourceProducts.DataSource;
            }
            else if (radioButtonCategory.Checked)
            {
                bindingSourceProducts.DataSource = _dbContext.Products.Where(x => x.Category.Contains(searchValue)).ToList();
                dataGridViewProducts.DataSource = bindingSourceProducts.DataSource;
            }
            else
            {
                MessageBox.Show("Не выбрана колонка для поиска");
            }
            
        }

        private void ButtonResetSearch_Click(object sender, EventArgs e)
        {
            RefreshTableProducts();
        }

        private void ButtonEditProduct_Click(object sender, EventArgs e)
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

            EditProductWindow editProductWindow = new EditProductWindow(product);
            editProductWindow.ShowDialog();

            RefreshTableProducts();
        }
    }
}
