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
    public partial class FrmThongTin : Form
    {
        public FrmThongTin()
        {
            InitializeComponent();
            lblTenDeTai.Text += " Đề tài tìm đường đi bằng BFS";
            lblVersion.Text = " Version 1.0.0.1.0";
            lblNguon.Text = "Copyright by LTDT";
            lblNhom.Text += " Lê Quang Sơn_15110118." +
                " --  Bành Công Minh_15110070.";
            textBoxNoiDung.Text = "Description: Tìm đường đi từ đỉnh I đến J bất kỳ bằng thuật toán BFS";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
