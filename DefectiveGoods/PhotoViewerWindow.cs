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
    public partial class PhotoViewerWindow : Form
    {
        private readonly List<string> _pathToImages;

        public PhotoViewerWindow(List<string> pathToImages)
        {
            _pathToImages = pathToImages;

            InitializeComponent();
        }

        private void PhotoViewer_Load(object sender, EventArgs e)
        {
            int y = 0;

            foreach (var path in _pathToImages)
            {
                panelPhoto.Controls.Add(new PictureBox()
                {
                    Image = Image.FromFile(path),
                    SizeMode = PictureBoxSizeMode.Zoom,                    
                    Location = new Point(0,y),
                    Size = new Size(528,390),
                    Margin = new Padding(0,0,0,50),
                    Anchor = AnchorStyles.None

                });

                y += 50;
            }

            panelPhoto.VerticalScroll.Value = panelPhoto.VerticalScroll.Maximum;
            panelPhoto.Focus();
        }
    }
}
