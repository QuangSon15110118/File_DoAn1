namespace DoAn1
{
    partial class FrmMain
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
            this.groupMatrix = new System.Windows.Forms.GroupBox();
            this.lvMatrix = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.thuậtToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijsktraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupGraph = new System.Windows.Forms.GroupBox();
            this.picGraphics = new System.Windows.Forms.PictureBox();
            this.groupMoPhong = new System.Windows.Forms.GroupBox();
            this.listMoPhong = new System.Windows.Forms.ListView();
            this.groupTool = new System.Windows.Forms.GroupBox();
            this.btnRungTungBuoc = new System.Windows.Forms.Button();
            this.btnRunAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.btnDiChuyen = new System.Windows.Forms.Button();
            this.btnNoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.domainDemo = new System.Windows.Forms.DomainUpDown();
            this.radioDemo = new System.Windows.Forms.RadioButton();
            this.radioDraw = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.GroupDraw = new System.Windows.Forms.GroupBox();
            this.groupMatrix.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraphics)).BeginInit();
            this.groupMoPhong.SuspendLayout();
            this.groupTool.SuspendLayout();
            this.groupInput.SuspendLayout();
            this.GroupDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMatrix
            // 
            this.groupMatrix.Controls.Add(this.lvMatrix);
            this.groupMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMatrix.Location = new System.Drawing.Point(13, 32);
            this.groupMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.groupMatrix.Name = "groupMatrix";
            this.groupMatrix.Padding = new System.Windows.Forms.Padding(4);
            this.groupMatrix.Size = new System.Drawing.Size(375, 222);
            this.groupMatrix.TabIndex = 0;
            this.groupMatrix.TabStop = false;
            this.groupMatrix.Text = "Matrix";
            // 
            // lvMatrix
            // 
            this.lvMatrix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvMatrix.GridLines = true;
            this.lvMatrix.Location = new System.Drawing.Point(7, 23);
            this.lvMatrix.Name = "lvMatrix";
            this.lvMatrix.Size = new System.Drawing.Size(360, 190);
            this.lvMatrix.TabIndex = 1;
            this.lvMatrix.UseCompatibleStateImageBehavior = false;
            this.lvMatrix.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tậpToolStripMenuItem,
            this.thuậtToánToolStripMenuItem,
            this.thongTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(977, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tậpToolStripMenuItem
            // 
            this.tậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStrip,
            this.saveToolStrip,
            this.exitToolStrip});
            this.tậpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tậpToolStripMenuItem.Name = "tậpToolStripMenuItem";
            this.tậpToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.tậpToolStripMenuItem.Text = "Tập Tin";
            // 
            // openToolStrip
            // 
            this.openToolStrip.Name = "openToolStrip";
            this.openToolStrip.Size = new System.Drawing.Size(143, 24);
            this.openToolStrip.Text = "Open File";
            this.openToolStrip.Click += new System.EventHandler(this.openToolStrip_Click);
            // 
            // saveToolStrip
            // 
            this.saveToolStrip.Name = "saveToolStrip";
            this.saveToolStrip.Size = new System.Drawing.Size(143, 24);
            this.saveToolStrip.Text = "Save File";
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(143, 24);
            this.exitToolStrip.Text = "Exit";
            this.exitToolStrip.Click += new System.EventHandler(this.exitToolStrip_Click);
            // 
            // thuậtToánToolStripMenuItem
            // 
            this.thuậtToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dijsktraToolStripMenuItem});
            this.thuậtToánToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.thuậtToánToolStripMenuItem.Name = "thuậtToánToolStripMenuItem";
            this.thuậtToánToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.thuậtToánToolStripMenuItem.Text = "Thuật Toán";
            // 
            // dijsktraToolStripMenuItem
            // 
            this.dijsktraToolStripMenuItem.Name = "dijsktraToolStripMenuItem";
            this.dijsktraToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.dijsktraToolStripMenuItem.Text = "Dijsktra";
            // 
            // thongTinToolStripMenuItem
            // 
            this.thongTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.thongTinToolStripMenuItem.Name = "thongTinToolStripMenuItem";
            this.thongTinToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.thongTinToolStripMenuItem.Text = "Thông Tin";
            this.thongTinToolStripMenuItem.Click += new System.EventHandler(this.thongTinToolStripMenuItem_Click);
            // 
            // groupGraph
            // 
            this.groupGraph.Controls.Add(this.picGraphics);
            this.groupGraph.Location = new System.Drawing.Point(396, 32);
            this.groupGraph.Margin = new System.Windows.Forms.Padding(4);
            this.groupGraph.Name = "groupGraph";
            this.groupGraph.Padding = new System.Windows.Forms.Padding(4);
            this.groupGraph.Size = new System.Drawing.Size(553, 339);
            this.groupGraph.TabIndex = 2;
            this.groupGraph.TabStop = false;
            this.groupGraph.Text = "Graph";
            // 
            // picGraphics
            // 
            this.picGraphics.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picGraphics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGraphics.Location = new System.Drawing.Point(7, 19);
            this.picGraphics.Name = "picGraphics";
            this.picGraphics.Size = new System.Drawing.Size(539, 313);
            this.picGraphics.TabIndex = 1;
            this.picGraphics.TabStop = false;
            // 
            // groupMoPhong
            // 
            this.groupMoPhong.Controls.Add(this.listMoPhong);
            this.groupMoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMoPhong.Location = new System.Drawing.Point(13, 447);
            this.groupMoPhong.Margin = new System.Windows.Forms.Padding(4);
            this.groupMoPhong.Name = "groupMoPhong";
            this.groupMoPhong.Padding = new System.Windows.Forms.Padding(4);
            this.groupMoPhong.Size = new System.Drawing.Size(936, 236);
            this.groupMoPhong.TabIndex = 3;
            this.groupMoPhong.TabStop = false;
            this.groupMoPhong.Text = "Mô Phỏng";
            // 
            // listMoPhong
            // 
            this.listMoPhong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listMoPhong.GridLines = true;
            this.listMoPhong.Location = new System.Drawing.Point(7, 23);
            this.listMoPhong.Name = "listMoPhong";
            this.listMoPhong.Size = new System.Drawing.Size(922, 207);
            this.listMoPhong.TabIndex = 1;
            this.listMoPhong.UseCompatibleStateImageBehavior = false;
            this.listMoPhong.View = System.Windows.Forms.View.Details;
            // 
            // groupTool
            // 
            this.groupTool.Controls.Add(this.btnRungTungBuoc);
            this.groupTool.Controls.Add(this.btnRunAll);
            this.groupTool.Controls.Add(this.label4);
            this.groupTool.Controls.Add(this.label3);
            this.groupTool.Controls.Add(this.cboFrom);
            this.groupTool.Controls.Add(this.cboTo);
            this.groupTool.Location = new System.Drawing.Point(13, 337);
            this.groupTool.Name = "groupTool";
            this.groupTool.Size = new System.Drawing.Size(216, 103);
            this.groupTool.TabIndex = 2;
            this.groupTool.TabStop = false;
            this.groupTool.Text = "Tools";
            // 
            // btnRungTungBuoc
            // 
            this.btnRungTungBuoc.Location = new System.Drawing.Point(121, 66);
            this.btnRungTungBuoc.Name = "btnRungTungBuoc";
            this.btnRungTungBuoc.Size = new System.Drawing.Size(58, 23);
            this.btnRungTungBuoc.TabIndex = 11;
            this.btnRungTungBuoc.Text = "Run";
            this.btnRungTungBuoc.UseVisualStyleBackColor = true;
            // 
            // btnRunAll
            // 
            this.btnRunAll.Location = new System.Drawing.Point(9, 66);
            this.btnRunAll.Name = "btnRunAll";
            this.btnRunAll.Size = new System.Drawing.Size(71, 23);
            this.btnRunAll.TabIndex = 11;
            this.btnRunAll.Text = "Run All";
            this.btnRunAll.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // cboFrom
            // 
            this.cboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(7, 36);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(91, 24);
            this.cboFrom.TabIndex = 7;
            // 
            // cboTo
            // 
            this.cboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(112, 36);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(91, 24);
            this.cboTo.TabIndex = 9;
            // 
            // btnDiChuyen
            // 
            this.btnDiChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiChuyen.Location = new System.Drawing.Point(21, 67);
            this.btnDiChuyen.Name = "btnDiChuyen";
            this.btnDiChuyen.Size = new System.Drawing.Size(84, 23);
            this.btnDiChuyen.TabIndex = 5;
            this.btnDiChuyen.Text = "Di Chuyển";
            this.btnDiChuyen.UseVisualStyleBackColor = true;
            // 
            // btnNoi
            // 
            this.btnNoi.Location = new System.Drawing.Point(21, 106);
            this.btnNoi.Name = "btnNoi";
            this.btnNoi.Size = new System.Drawing.Size(84, 23);
            this.btnNoi.TabIndex = 5;
            this.btnNoi.Text = "Nối";
            this.btnNoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(403, 378);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(539, 62);
            this.txtResult.TabIndex = 2;
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.domainDemo);
            this.groupInput.Controls.Add(this.radioDemo);
            this.groupInput.Controls.Add(this.radioDraw);
            this.groupInput.Location = new System.Drawing.Point(13, 261);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(216, 71);
            this.groupInput.TabIndex = 6;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Input";
            // 
            // domainDemo
            // 
            this.domainDemo.Location = new System.Drawing.Point(160, 28);
            this.domainDemo.Name = "domainDemo";
            this.domainDemo.Size = new System.Drawing.Size(43, 23);
            this.domainDemo.TabIndex = 2;
            // 
            // radioDemo
            // 
            this.radioDemo.Location = new System.Drawing.Point(86, 22);
            this.radioDemo.Name = "radioDemo";
            this.radioDemo.Size = new System.Drawing.Size(74, 32);
            this.radioDemo.TabIndex = 1;
            this.radioDemo.TabStop = true;
            this.radioDemo.Text = "Demo";
            this.radioDemo.UseVisualStyleBackColor = true;
            this.radioDemo.CheckedChanged += new System.EventHandler(this.radioDemo_CheckedChanged);
            // 
            // radioDraw
            // 
            this.radioDraw.Location = new System.Drawing.Point(6, 22);
            this.radioDraw.Name = "radioDraw";
            this.radioDraw.Size = new System.Drawing.Size(74, 32);
            this.radioDraw.TabIndex = 0;
            this.radioDraw.TabStop = true;
            this.radioDraw.Text = "Draw";
            this.radioDraw.UseVisualStyleBackColor = true;
            this.radioDraw.CheckedChanged += new System.EventHandler(this.radioDraw_CheckedChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(21, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // GroupDraw
            // 
            this.GroupDraw.Controls.Add(this.btnXoa);
            this.GroupDraw.Controls.Add(this.btnDiChuyen);
            this.GroupDraw.Controls.Add(this.btnNoi);
            this.GroupDraw.Controls.Add(this.btnThem);
            this.GroupDraw.Location = new System.Drawing.Point(257, 261);
            this.GroupDraw.Name = "GroupDraw";
            this.GroupDraw.Size = new System.Drawing.Size(123, 180);
            this.GroupDraw.TabIndex = 7;
            this.GroupDraw.TabStop = false;
            this.GroupDraw.Text = "Draw";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(977, 688);
            this.Controls.Add(this.GroupDraw);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.groupTool);
            this.Controls.Add(this.groupMoPhong);
            this.Controls.Add(this.groupGraph);
            this.Controls.Add(this.groupMatrix);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupMatrix.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGraphics)).EndInit();
            this.groupMoPhong.ResumeLayout(false);
            this.groupTool.ResumeLayout(false);
            this.groupTool.PerformLayout();
            this.groupInput.ResumeLayout(false);
            this.GroupDraw.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMatrix;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStrip;
        private System.Windows.Forms.ToolStripMenuItem thuậtToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijsktraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupGraph;
        private System.Windows.Forms.ListView lvMatrix;
        private System.Windows.Forms.PictureBox picGraphics;
        private System.Windows.Forms.GroupBox groupMoPhong;
        private System.Windows.Forms.ListView listMoPhong;
        private System.Windows.Forms.GroupBox groupTool;
        private System.Windows.Forms.Button btnRunAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.Button btnDiChuyen;
        private System.Windows.Forms.Button btnNoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnRungTungBuoc;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox GroupDraw;
        private System.Windows.Forms.RadioButton radioDraw;
        private System.Windows.Forms.DomainUpDown domainDemo;
        private System.Windows.Forms.RadioButton radioDemo;
    }
}

