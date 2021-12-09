
namespace DefectiveGoods
{
    partial class PhotoViewerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPhoto = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelPhoto
            // 
            this.panelPhoto.AutoScroll = true;
            this.panelPhoto.AutoSize = true;
            this.panelPhoto.Location = new System.Drawing.Point(56, 45);
            this.panelPhoto.Name = "panelPhoto";
            this.panelPhoto.Size = new System.Drawing.Size(528, 390);
            this.panelPhoto.TabIndex = 0;
            // 
            // PhotoViewerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 501);
            this.Controls.Add(this.panelPhoto);
            this.Name = "PhotoViewerWindow";
            this.Text = "PhotoViewer";
            this.Load += new System.EventHandler(this.PhotoViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPhoto;
    }
}