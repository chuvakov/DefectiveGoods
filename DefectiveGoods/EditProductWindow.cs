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
    public partial class EditProductWindow : Form
    {
        private readonly Product _selectedProduct;

        public EditProductWindow(Product selectedProduct)
        {
            InitializeComponent();

            _selectedProduct = selectedProduct;
            Init();
        }

        private void Init()
        {
            TextBoxCode.Text = _selectedProduct.Code;
            TextBoxArrivalNum.Text = _selectedProduct.ArrivalNumber;
            TextBoxName.Text = _selectedProduct.Name;
            dateTimePicker.Value = _selectedProduct.Date;
            TextBoxCount.Text = _selectedProduct.Count.ToString();
            TextBoxCategory.Text = _selectedProduct.Category;
            TextBoxComment.Text = _selectedProduct.Comment;
            TextBoxImage.Text = _selectedProduct.PathToImage;
        }

        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            foreach (var fileName in openFileDialogImage.FileNames)
            {
                TextBoxImage.Text += fileName + ',';
            }

            TextBoxImage.Text = TextBoxImage.Text.Remove(TextBoxImage.Text.Length - 1);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _selectedProduct.Code = TextBoxCode.Text;
            _selectedProduct.Name = TextBoxName.Text;
            _selectedProduct.ArrivalNumber = TextBoxArrivalNum.Text;
            _selectedProduct.Count = int.Parse(TextBoxCount.Text);
            _selectedProduct.Date = dateTimePicker.Value;
            _selectedProduct.PathToImage = TextBoxImage.Text;
            _selectedProduct.Category = TextBoxCategory.Text;
            _selectedProduct.Comment = TextBoxComment.Text;

            using (DefectiveGoodsContext dbContext = new DefectiveGoodsContext())
            {
                dbContext.Products.Update(_selectedProduct);
                dbContext.SaveChanges();
            }

            Close();
        }
    }
}
