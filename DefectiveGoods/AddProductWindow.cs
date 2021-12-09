using DefectiveGoods.Core;
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
    public partial class AddProductWindow : Form
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        //TODO: поменять местами наименования как ImageTextBox а нужно TextBoxImage
        //Поправить дизайн
        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (DefectiveGoodsContext dbContext = new DefectiveGoodsContext())
            {
                dbContext.Products.Add(new Core.Models.Product
                {
                    Code = TextBoxCode.Text,
                    Name = TextBoxName.Text,
                    ArrivalNumber = TextBoxArrivalNum.Text,
                    Count = int.Parse(TextBoxCount.Text),
                    Date = dateTimePicker.Value,
                    PathToImage = TextBoxImage.Text,
                    Category = TextBoxCategory.Text,
                    Comment = TextBoxComment.Text,
                    Location = TextBoxLocation.Text
                });

                dbContext.SaveChanges();
            }

            Close();
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
    }
}
