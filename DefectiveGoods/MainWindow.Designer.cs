﻿
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
            this.RadioButtonLocation = new System.Windows.Forms.RadioButton();
            this.radioButtonCategory = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonArrivalNumber = new System.Windows.Forms.RadioButton();
            this.radioButtonProductCode = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 33;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1124, 336);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProducts_ColumnHeaderMouseClick);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Location = new System.Drawing.Point(313, 3);
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
            this.ButtonRemoveProduct.Location = new System.Drawing.Point(585, 3);
            this.ButtonRemoveProduct.Name = "ButtonRemoveProduct";
            this.ButtonRemoveProduct.Size = new System.Drawing.Size(130, 34);
            this.ButtonRemoveProduct.TabIndex = 3;
            this.ButtonRemoveProduct.Text = "Удалить";
            this.ButtonRemoveProduct.UseVisualStyleBackColor = true;
            this.ButtonRemoveProduct.Click += new System.EventHandler(this.ButtonRemoveProduct_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(329, 94);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(130, 34);
            this.ButtonSort.TabIndex = 4;
            this.ButtonSort.Text = "Сортировка";
            this.ButtonSort.UseVisualStyleBackColor = true;
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Location = new System.Drawing.Point(0, 3);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(130, 34);
            this.ButtonDownload.TabIndex = 5;
            this.ButtonDownload.Text = "Скачать";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            // 
            // ButtonEditProduct
            // 
            this.ButtonEditProduct.Location = new System.Drawing.Point(449, 3);
            this.ButtonEditProduct.Name = "ButtonEditProduct";
            this.ButtonEditProduct.Size = new System.Drawing.Size(130, 34);
            this.ButtonEditProduct.TabIndex = 1;
            this.ButtonEditProduct.Text = "Редактировать";
            this.ButtonEditProduct.UseVisualStyleBackColor = true;
            this.ButtonEditProduct.Click += new System.EventHandler(this.ButtonEditProduct_Click);
            // 
            // ButtonShowFoto
            // 
            this.ButtonShowFoto.Location = new System.Drawing.Point(136, 3);
            this.ButtonShowFoto.Name = "ButtonShowFoto";
            this.ButtonShowFoto.Size = new System.Drawing.Size(160, 34);
            this.ButtonShowFoto.TabIndex = 5;
            this.ButtonShowFoto.Text = "Просмотр Фото";
            this.ButtonShowFoto.UseVisualStyleBackColor = true;
            this.ButtonShowFoto.Click += new System.EventHandler(this.ButtonShowFoto_Click);
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
            this.groupBox1.Controls.Add(this.RadioButtonLocation);
            this.groupBox1.Controls.Add(this.radioButtonCategory);
            this.groupBox1.Controls.Add(this.radioButtonName);
            this.groupBox1.Controls.Add(this.radioButtonArrivalNumber);
            this.groupBox1.Controls.Add(this.ButtonSort);
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
            this.ButtonResetSearch.Location = new System.Drawing.Point(329, 150);
            this.ButtonResetSearch.Name = "ButtonResetSearch";
            this.ButtonResetSearch.Size = new System.Drawing.Size(130, 34);
            this.ButtonResetSearch.TabIndex = 8;
            this.ButtonResetSearch.Text = "Сброс";
            this.ButtonResetSearch.UseVisualStyleBackColor = true;
            this.ButtonResetSearch.Click += new System.EventHandler(this.ButtonResetSearch_Click);
            // 
            // RadioButtonLocation
            // 
            this.RadioButtonLocation.AutoSize = true;
            this.RadioButtonLocation.Location = new System.Drawing.Point(38, 315);
            this.RadioButtonLocation.Name = "RadioButtonLocation";
            this.RadioButtonLocation.Size = new System.Drawing.Size(171, 29);
            this.RadioButtonLocation.TabIndex = 7;
            this.RadioButtonLocation.TabStop = true;
            this.RadioButtonLocation.Text = "Адрес Хранения";
            this.RadioButtonLocation.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewProducts);
            this.panel1.Location = new System.Drawing.Point(23, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 336);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ButtonDownload);
            this.panel2.Controls.Add(this.ButtonShowFoto);
            this.panel2.Controls.Add(this.ButtonAddProduct);
            this.panel2.Controls.Add(this.ButtonRemoveProduct);
            this.panel2.Controls.Add(this.ButtonEditProduct);
            this.panel2.Location = new System.Drawing.Point(29, 831);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 43);
            this.panel2.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 875);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton RadioButtonLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

