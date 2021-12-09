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

        private DataGridViewColumn _columnHeaderClicked;
        private ListSortDirection _listSortDirection = ListSortDirection.Ascending;

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
            else if (RadioButtonLocation.Checked)
            {
                bindingSourceProducts.DataSource = _dbContext.Products.Where(x => x.Location.Contains(searchValue)).ToList();
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

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewProducts_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dataGridViewProducts.Columns[e.ColumnIndex];            

            if (_columnHeaderClicked == null || _columnHeaderClicked.Name != column.Name)
            {
                _columnHeaderClicked = column;
                _listSortDirection = ListSortDirection.Ascending;
            }
            else
            {
                if (_listSortDirection == ListSortDirection.Ascending)
                {
                    _listSortDirection = ListSortDirection.Descending;
                }
                else
                {
                    _listSortDirection = ListSortDirection.Ascending;
                }
            }

            SortGrid(column.Name);
        }

        private void SortGrid(string columnName)
        {
            List<Product> products = (List<Product>)bindingSourceProducts.DataSource;

            switch (columnName)
            {
                case "Count":
                    if (_listSortDirection == ListSortDirection.Ascending)
                    {
                        bindingSourceProducts.DataSource = products.OrderBy(x => x.Count).ToList();
                    }
                    else
                    {
                        bindingSourceProducts.DataSource = products.OrderByDescending(x => x.Count).ToList();
                    }                       
                    break;

                case "Id":
                    if (_listSortDirection == ListSortDirection.Ascending)
                    {
                        bindingSourceProducts.DataSource = products.OrderBy(x => x.Id).ToList();
                    }
                    else
                    {
                        bindingSourceProducts.DataSource = products.OrderByDescending(x => x.Id).ToList();
                    }                    
                    break;

                case "Code":
                    if (_listSortDirection == ListSortDirection.Ascending)
                    {
                        bindingSourceProducts.DataSource = products.OrderBy(x => x.Code).ToList();
                    }
                    else
                    {
                        bindingSourceProducts.DataSource = products.OrderByDescending(x => x.Code).ToList();
                    }
                    break;

                case "ArrivalNumber":
                    if (_listSortDirection == ListSortDirection.Ascending)
                    {
                        bindingSourceProducts.DataSource = products.OrderBy(x => x.ArrivalNumber).ToList();
                    }
                    else
                    {
                        bindingSourceProducts.DataSource = products.OrderByDescending(x => x.ArrivalNumber).ToList();
                    }
                    break;

                case "Name":
                    if (_listSortDirection == ListSortDirection.Ascending)
                    {
                        bindingSourceProducts.DataSource = products.OrderBy(x => x.Name).ToList();
                    }
                    else
                    {
                        bindingSourceProducts.DataSource = products.OrderByDescending(x => x.Name).ToList();
                    }
                    break;

                case "Date":
                    if (_listSortDirection == ListSortDirection.Ascending)
                    {
                        bindingSourceProducts.DataSource = products.OrderBy(x => x.Date).ToList();
                    }
                    else
                    {
                        bindingSourceProducts.DataSource = products.OrderByDescending(x => x.Date).ToList();
                    }
                    break;

                case "Category":
                    if (_listSortDirection == ListSortDirection.Ascending)
                    {
                        bindingSourceProducts.DataSource = products.OrderBy(x => x.Category).ToList();
                    }
                    else
                    {
                        bindingSourceProducts.DataSource = products.OrderByDescending(x => x.Category).ToList();
                    }
                    break;

                case "Location":
                    if (_listSortDirection == ListSortDirection.Ascending)
                    {
                        bindingSourceProducts.DataSource = products.OrderBy(x => x.Location).ToList();
                    }
                    else
                    {
                        bindingSourceProducts.DataSource = products.OrderByDescending(x => x.Location).ToList();
                    }
                    break;
            }

            dataGridViewProducts.DataSource = bindingSourceProducts.DataSource;
        }

        private void ButtonShowFoto_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(product.PathToImage))
            {
                MessageBox.Show("У выбранного продукта нет фотографий");
                return;
            }

            List<string> pathToImages = product.PathToImage.Split(",").ToList();

            PhotoViewerWindow photoViewerWindow = new PhotoViewerWindow(pathToImages);
            photoViewerWindow.Show();
        }
    }
}
