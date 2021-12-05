
namespace DefectiveGoods
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.bindingSourceProducts = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonSearchProduct = new System.Windows.Forms.Button();
            this.ButtonRemoveProduct = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonDownload = new System.Windows.Forms.Button();
            this.ButtonEditProduct = new System.Windows.Forms.Button();
            this.ButtonShowFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 33;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1133, 376);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(743, 404);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(130, 34);
            this.ButtonAddProduct.TabIndex = 1;
            this.ButtonAddProduct.Text = "Добавить";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // ButtonSearchProduct
            // 
            this.ButtonSearchProduct.Location = new System.Drawing.Point(12, 404);
            this.ButtonSearchProduct.Name = "ButtonSearchProduct";
            this.ButtonSearchProduct.Size = new System.Drawing.Size(130, 34);
            this.ButtonSearchProduct.TabIndex = 2;
            this.ButtonSearchProduct.Text = "Поиск";
            this.ButtonSearchProduct.UseVisualStyleBackColor = true;
            // 
            // ButtonRemoveProduct
            // 
            this.ButtonRemoveProduct.Location = new System.Drawing.Point(1015, 404);
            this.ButtonRemoveProduct.Name = "ButtonRemoveProduct";
            this.ButtonRemoveProduct.Size = new System.Drawing.Size(130, 34);
            this.ButtonRemoveProduct.TabIndex = 3;
            this.ButtonRemoveProduct.Text = "Удалить";
            this.ButtonRemoveProduct.UseVisualStyleBackColor = true;
            this.ButtonRemoveProduct.Click += new System.EventHandler(this.ButtonRemoveProduct_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(148, 404);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(130, 34);
            this.ButtonSort.TabIndex = 4;
            this.ButtonSort.Text = "Сортировка";
            this.ButtonSort.UseVisualStyleBackColor = true;
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Location = new System.Drawing.Point(284, 404);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(130, 34);
            this.ButtonDownload.TabIndex = 5;
            this.ButtonDownload.Text = "Скачать";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            // 
            // ButtonEditProduct
            // 
            this.ButtonEditProduct.Location = new System.Drawing.Point(879, 404);
            this.ButtonEditProduct.Name = "ButtonEditProduct";
            this.ButtonEditProduct.Size = new System.Drawing.Size(130, 34);
            this.ButtonEditProduct.TabIndex = 1;
            this.ButtonEditProduct.Text = "Редактировать";
            this.ButtonEditProduct.UseVisualStyleBackColor = true;
            this.ButtonEditProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // ButtonShowFoto
            // 
            this.ButtonShowFoto.Location = new System.Drawing.Point(499, 404);
            this.ButtonShowFoto.Name = "ButtonShowFoto";
            this.ButtonShowFoto.Size = new System.Drawing.Size(160, 34);
            this.ButtonShowFoto.TabIndex = 5;
            this.ButtonShowFoto.Text = "Просмотр Фото";
            this.ButtonShowFoto.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 450);
            this.Controls.Add(this.ButtonShowFoto);
            this.Controls.Add(this.ButtonDownload);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonRemoveProduct);
            this.Controls.Add(this.ButtonSearchProduct);
            this.Controls.Add(this.ButtonEditProduct);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.BindingSource bindingSourceProducts;
        private System.Windows.Forms.Button ButtonSearchProduct;
        private System.Windows.Forms.Button ButtonRemoveProduct;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonDownload;
        private System.Windows.Forms.Button ButtonEditProduct;
        private System.Windows.Forms.Button ButtonShowFoto;
    }
}

