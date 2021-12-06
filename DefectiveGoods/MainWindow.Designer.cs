
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
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonResetSearch = new System.Windows.Forms.Button();
            this.radioButtonCategory = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonArrivalNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonProductCode = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(14, 489);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 33;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1133, 326);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(745, 831);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(130, 34);
            this.ButtonAddProduct.TabIndex = 1;
            this.ButtonAddProduct.Text = "Добавить";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // ButtonSearchProduct
            // 
            this.ButtonSearchProduct.Location = new System.Drawing.Point(329, 43);
            this.ButtonSearchProduct.Name = "ButtonSearchProduct";
            this.ButtonSearchProduct.Size = new System.Drawing.Size(130, 34);
            this.ButtonSearchProduct.TabIndex = 2;
            this.ButtonSearchProduct.Text = "Поиск";
            this.ButtonSearchProduct.UseVisualStyleBackColor = true;
            this.ButtonSearchProduct.Click += new System.EventHandler(this.ButtonSearchProduct_Click);
            // 
            // ButtonRemoveProduct
            // 
            this.ButtonRemoveProduct.Location = new System.Drawing.Point(1017, 831);
            this.ButtonRemoveProduct.Name = "ButtonRemoveProduct";
            this.ButtonRemoveProduct.Size = new System.Drawing.Size(130, 34);
            this.ButtonRemoveProduct.TabIndex = 3;
            this.ButtonRemoveProduct.Text = "Удалить";
            this.ButtonRemoveProduct.UseVisualStyleBackColor = true;
            this.ButtonRemoveProduct.Click += new System.EventHandler(this.ButtonRemoveProduct_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(150, 831);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(130, 34);
            this.ButtonSort.TabIndex = 4;
            this.ButtonSort.Text = "Сортировка";
            this.ButtonSort.UseVisualStyleBackColor = true;
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Location = new System.Drawing.Point(286, 831);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(130, 34);
            this.ButtonDownload.TabIndex = 5;
            this.ButtonDownload.Text = "Скачать";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            // 
            // ButtonEditProduct
            // 
            this.ButtonEditProduct.Location = new System.Drawing.Point(881, 831);
            this.ButtonEditProduct.Name = "ButtonEditProduct";
            this.ButtonEditProduct.Size = new System.Drawing.Size(130, 34);
            this.ButtonEditProduct.TabIndex = 1;
            this.ButtonEditProduct.Text = "Редактировать";
            this.ButtonEditProduct.UseVisualStyleBackColor = true;
            this.ButtonEditProduct.Click += new System.EventHandler(this.ButtonEditProduct_Click);
            // 
            // ButtonShowFoto
            // 
            this.ButtonShowFoto.Location = new System.Drawing.Point(501, 831);
            this.ButtonShowFoto.Name = "ButtonShowFoto";
            this.ButtonShowFoto.Size = new System.Drawing.Size(160, 34);
            this.ButtonShowFoto.TabIndex = 5;
            this.ButtonShowFoto.Text = "Просмотр Фото";
            this.ButtonShowFoto.UseVisualStyleBackColor = true;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(6, 45);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(275, 31);
            this.TextBoxSearch.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonResetSearch);
            this.groupBox1.Controls.Add(this.radioButtonCategory);
            this.groupBox1.Controls.Add(this.radioButtonName);
            this.groupBox1.Controls.Add(this.radioButtonArrivalNumber);
            this.groupBox1.Controls.Add(this.radioButtonProductCode);
            this.groupBox1.Controls.Add(this.TextBoxSearch);
            this.groupBox1.Controls.Add(this.ButtonSearchProduct);
            this.groupBox1.Location = new System.Drawing.Point(23, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 395);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // ButtonResetSearch
            // 
            this.ButtonResetSearch.Location = new System.Drawing.Point(329, 102);
            this.ButtonResetSearch.Name = "ButtonResetSearch";
            this.ButtonResetSearch.Size = new System.Drawing.Size(130, 34);
            this.ButtonResetSearch.TabIndex = 8;
            this.ButtonResetSearch.Text = "Сброс";
            this.ButtonResetSearch.UseVisualStyleBackColor = true;
            this.ButtonResetSearch.Click += new System.EventHandler(this.ButtonResetSearch_Click);
            // 
            // radioButtonCategory
            // 
            this.radioButtonCategory.AutoSize = true;
            this.radioButtonCategory.Location = new System.Drawing.Point(38, 268);
            this.radioButtonCategory.Name = "radioButtonCategory";
            this.radioButtonCategory.Size = new System.Drawing.Size(120, 29);
            this.radioButtonCategory.TabIndex = 7;
            this.radioButtonCategory.TabStop = true;
            this.radioButtonCategory.Text = "Категория";
            this.radioButtonCategory.UseVisualStyleBackColor = true;
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(38, 214);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(160, 29);
            this.radioButtonName.TabIndex = 7;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Text = "Наименование";
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonArrivalNumber
            // 
            this.radioButtonArrivalNumber.AutoSize = true;
            this.radioButtonArrivalNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButtonArrivalNumber.Location = new System.Drawing.Point(38, 164);
            this.radioButtonArrivalNumber.Name = "radioButtonArrivalNumber";
            this.radioButtonArrivalNumber.Size = new System.Drawing.Size(201, 29);
            this.radioButtonArrivalNumber.TabIndex = 7;
            this.radioButtonArrivalNumber.TabStop = true;
            this.radioButtonArrivalNumber.Text = "Номер поступления";
            this.radioButtonArrivalNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonProductCode
            // 
            this.radioButtonProductCode.AutoSize = true;
            this.radioButtonProductCode.Location = new System.Drawing.Point(38, 118);
            this.radioButtonProductCode.Name = "radioButtonProductCode";
            this.radioButtonProductCode.Size = new System.Drawing.Size(130, 29);
            this.radioButtonProductCode.TabIndex = 7;
            this.radioButtonProductCode.TabStop = true;
            this.radioButtonProductCode.Text = "Код товара";
            this.radioButtonProductCode.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 875);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonShowFoto);
            this.Controls.Add(this.ButtonDownload);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonRemoveProduct);
            this.Controls.Add(this.ButtonEditProduct);
            this.Controls.Add(this.ButtonAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonProductCode;
        private System.Windows.Forms.RadioButton radioButtonCategory;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonArrivalNumber;
        private System.Windows.Forms.Button ButtonResetSearch;
    }
}

