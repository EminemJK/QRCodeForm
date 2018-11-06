namespace QRCodeForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.btnQR = new System.Windows.Forms.Button();
            this.picBoxQRCode = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numLogoBorderSize = new System.Windows.Forms.NumericUpDown();
            this.lbLogoBorderSize = new System.Windows.Forms.Label();
            this.numLogoSize = new System.Windows.Forms.NumericUpDown();
            this.lbLogoSize = new System.Windows.Forms.Label();
            this.plBackgroundColor = new System.Windows.Forms.Panel();
            this.plQrColor = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchLogo = new System.Windows.Forms.Button();
            this.numQRSize = new System.Windows.Forms.NumericUpDown();
            this.btnSavePic = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnLogoClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLogoBorderSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLogoSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQRSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输出内容：";
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.Location = new System.Drawing.Point(106, 20);
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.Size = new System.Drawing.Size(244, 21);
            this.txtBoxOutput.TabIndex = 1;
            this.txtBoxOutput.Text = "https://www.cnblogs.com/EminemJK/";
            // 
            // btnQR
            // 
            this.btnQR.Location = new System.Drawing.Point(297, 186);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(60, 60);
            this.btnQR.TabIndex = 2;
            this.btnQR.Text = "生成";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // picBoxQRCode
            // 
            this.picBoxQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxQRCode.Location = new System.Drawing.Point(387, 20);
            this.picBoxQRCode.Name = "picBoxQRCode";
            this.picBoxQRCode.Size = new System.Drawing.Size(250, 250);
            this.picBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxQRCode.TabIndex = 3;
            this.picBoxQRCode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Logo Image：";
            // 
            // txtLogo
            // 
            this.txtLogo.Location = new System.Drawing.Point(106, 103);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.ReadOnly = true;
            this.txtLogo.Size = new System.Drawing.Size(174, 21);
            this.txtLogo.TabIndex = 5;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxLogo.Location = new System.Drawing.Point(107, 130);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(121, 115);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 8;
            this.picBoxLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "像素大小：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogoClear);
            this.groupBox1.Controls.Add(this.numLogoBorderSize);
            this.groupBox1.Controls.Add(this.lbLogoBorderSize);
            this.groupBox1.Controls.Add(this.numLogoSize);
            this.groupBox1.Controls.Add(this.lbLogoSize);
            this.groupBox1.Controls.Add(this.plBackgroundColor);
            this.groupBox1.Controls.Add(this.plQrColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSearchLogo);
            this.groupBox1.Controls.Add(this.numQRSize);
            this.groupBox1.Controls.Add(this.txtBoxOutput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picBoxLogo);
            this.groupBox1.Controls.Add(this.btnQR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLogo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 286);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生成设置";
            // 
            // numLogoBorderSize
            // 
            this.numLogoBorderSize.Location = new System.Drawing.Point(306, 159);
            this.numLogoBorderSize.Name = "numLogoBorderSize";
            this.numLogoBorderSize.Size = new System.Drawing.Size(51, 21);
            this.numLogoBorderSize.TabIndex = 20;
            this.numLogoBorderSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // lbLogoBorderSize
            // 
            this.lbLogoBorderSize.AutoSize = true;
            this.lbLogoBorderSize.Location = new System.Drawing.Point(235, 161);
            this.lbLogoBorderSize.Name = "lbLogoBorderSize";
            this.lbLogoBorderSize.Size = new System.Drawing.Size(65, 12);
            this.lbLogoBorderSize.TabIndex = 19;
            this.lbLogoBorderSize.Text = "logo边框：";
            // 
            // numLogoSize
            // 
            this.numLogoSize.Location = new System.Drawing.Point(307, 132);
            this.numLogoSize.Name = "numLogoSize";
            this.numLogoSize.Size = new System.Drawing.Size(50, 21);
            this.numLogoSize.TabIndex = 18;
            this.numLogoSize.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lbLogoSize
            // 
            this.lbLogoSize.AutoSize = true;
            this.lbLogoSize.Location = new System.Drawing.Point(236, 134);
            this.lbLogoSize.Name = "lbLogoSize";
            this.lbLogoSize.Size = new System.Drawing.Size(65, 12);
            this.lbLogoSize.TabIndex = 17;
            this.lbLogoSize.Text = "logo大小：";
            // 
            // plBackgroundColor
            // 
            this.plBackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plBackgroundColor.ForeColor = System.Drawing.Color.White;
            this.plBackgroundColor.Location = new System.Drawing.Point(234, 73);
            this.plBackgroundColor.Name = "plBackgroundColor";
            this.plBackgroundColor.Size = new System.Drawing.Size(59, 24);
            this.plBackgroundColor.TabIndex = 16;
            this.plBackgroundColor.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // plQrColor
            // 
            this.plQrColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plQrColor.ForeColor = System.Drawing.Color.White;
            this.plQrColor.Location = new System.Drawing.Point(107, 73);
            this.plQrColor.Name = "plQrColor";
            this.plQrColor.Size = new System.Drawing.Size(59, 24);
            this.plQrColor.TabIndex = 15;
            this.plQrColor.Click += new System.EventHandler(this.ColorPicker_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "条码色：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "前背景色：";
            // 
            // btnSearchLogo
            // 
            this.btnSearchLogo.Location = new System.Drawing.Point(286, 103);
            this.btnSearchLogo.Name = "btnSearchLogo";
            this.btnSearchLogo.Size = new System.Drawing.Size(29, 23);
            this.btnSearchLogo.TabIndex = 12;
            this.btnSearchLogo.Text = "..";
            this.btnSearchLogo.UseVisualStyleBackColor = true;
            this.btnSearchLogo.Click += new System.EventHandler(this.btnSearchLogo_Click);
            // 
            // numQRSize
            // 
            this.numQRSize.Location = new System.Drawing.Point(107, 46);
            this.numQRSize.Name = "numQRSize";
            this.numQRSize.Size = new System.Drawing.Size(60, 21);
            this.numQRSize.TabIndex = 11;
            this.numQRSize.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnSavePic
            // 
            this.btnSavePic.Location = new System.Drawing.Point(549, 276);
            this.btnSavePic.Name = "btnSavePic";
            this.btnSavePic.Size = new System.Drawing.Size(88, 28);
            this.btnSavePic.TabIndex = 21;
            this.btnSavePic.Text = "另存为...";
            this.btnSavePic.UseVisualStyleBackColor = true;
            this.btnSavePic.Click += new System.EventHandler(this.btnSavePic_Click);
            // 
            // btnLogoClear
            // 
            this.btnLogoClear.Location = new System.Drawing.Point(321, 103);
            this.btnLogoClear.Name = "btnLogoClear";
            this.btnLogoClear.Size = new System.Drawing.Size(29, 23);
            this.btnLogoClear.TabIndex = 21;
            this.btnLogoClear.Text = "×";
            this.btnLogoClear.UseVisualStyleBackColor = true;
            this.btnLogoClear.Click += new System.EventHandler(this.btnLogoClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 310);
            this.Controls.Add(this.btnSavePic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBoxQRCode);
            this.Name = "MainForm";
            this.Text = "二维码生成测试";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLogoBorderSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLogoSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQRSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.PictureBox picBoxQRCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numQRSize;
        private System.Windows.Forms.Panel plBackgroundColor;
        private System.Windows.Forms.Panel plQrColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchLogo;
        private System.Windows.Forms.NumericUpDown numLogoBorderSize;
        private System.Windows.Forms.Label lbLogoBorderSize;
        private System.Windows.Forms.NumericUpDown numLogoSize;
        private System.Windows.Forms.Label lbLogoSize;
        private System.Windows.Forms.Button btnSavePic;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnLogoClear;
    }
}

