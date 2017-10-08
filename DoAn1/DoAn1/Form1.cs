using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class FrmMain : Form
    {
        //List<List<int>> Adjacent;
        //int dinh; // so dinh

        //GraphicsTools g; // khai bao 1 graphicsTools
        //List<Point> lstPointVertices; // danh sach toa do cac dinh
        //string FileName;
        //public const int PicturePadding = 50; // picture padding

        public FrmMain()
        {
            InitializeComponent();
        }

        private void exitToolStrip_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Thoát Khỏi Chương Trình?",
                                    "",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
    //        OpenFileDialog ofd = new OpenFileDialog();
    //        ofd.Filter = "Text Document File(*.txt)|*.txt|All File(*.*)|*.*";

    //        if (ofd.ShowDialog() == DialogResult.OK)
    //        {
    //            try
    //            {
    //                // enable button findpath va button save image
    //                this.btnFindPath.Enabled = true;

    //                // reset control values
    //                this.cboFrom.Items.Clear();
    //                this.cboTo.Items.Clear();
    //                this.lvMatrix.Items.Clear();
    //                this.lvMatrix.Columns.Clear();
    //                this.txtResult.Clear();
    //                this.picGraphics.Image = null;
    //                //
    //                MaTran m = new MaTran();
    //                //
    //                this.FileName = ofd.FileName;
    //                this.Adjacent = m.LoadFile(this.FileName, this.lvMatrix, this.cboFrom, this.cboTo);
    //                this.cboFrom.SelectedIndex = 0;
    //                this.cboTo.SelectedIndex = 1;

    //                this.dinh = m.Dinh;

    //                this.g = new Graphics(this.picGraphics.Width, this.picGraphics.Height);// khoi tao graphics tool

    //                // lay danh sach toa do cac dinh
    //                this.lstPointVertices = new Vector2D(this.dinh, this.picGraphics.Width - FrmMain.PicturePadding,
    //                                            this.picGraphics.Height - FrmMain.PicturePadding).getRandomPoint();

    //                // tao bitmap do thi voi danh sach ke va danh sach toa cac dinh

    //                this.picGraphics.Image = this.g.CreateGraphics(this.Adjacent, this.lstPointVertices);

    //            }
    //            catch (Exception EX)
    //            {
    //                MessageBox.Show(EX.Message, "Error");

    //            }
    //        }
    //        ofd.Dispose();
        }

        private void thongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThongTin = new FrmThongTin();
            frmThongTin.StartPosition = FormStartPosition.CenterScreen;
            frmThongTin.ShowDialog();
        }


        private void radioDraw_CheckedChanged(object sender, EventArgs e)
        {
            domainDemo.Enabled = false;
            GroupDraw.Enabled = true;
        }

        private void radioDemo_CheckedChanged(object sender, EventArgs e)
        {
            domainDemo.Enabled = true;
            GroupDraw.Enabled = false;
        }
    }
}
