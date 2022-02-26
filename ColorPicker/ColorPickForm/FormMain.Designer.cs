namespace ColorPick
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textIn = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxTop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(181, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            // 
            // textIn
            // 
            this.textIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textIn.Location = new System.Drawing.Point(47, 92);
            this.textIn.MaxLength = 6;
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(100, 21);
            this.textIn.TabIndex = 3;
            this.textIn.Text = "000000";
            this.textIn.TextChanged += new System.EventHandler(this.textIn_TextChanged);
            this.textIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIn_KeyPress);
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(47, 136);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(35, 21);
            this.textBoxR.TabIndex = 4;
            this.textBoxR.Text = "0";
            this.textBoxR.TextChanged += new System.EventHandler(this.textBoxRGB_TextChanged);
            this.textBoxR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRGB_KeyPress);
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(88, 136);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(35, 21);
            this.textBoxG.TabIndex = 4;
            this.textBoxG.Text = "0";
            this.textBoxG.TextChanged += new System.EventHandler(this.textBoxRGB_TextChanged);
            this.textBoxG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRGB_KeyPress);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(129, 136);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(35, 21);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.Text = "0";
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxRGB_TextChanged);
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRGB_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "0,0,0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(45, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 6;
            this.label16.Text = "#000000";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(181, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 85);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cursor\r\nColor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Input\r\nColor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "RGB";
            // 
            // checkBoxTop
            // 
            this.checkBoxTop.AutoSize = true;
            this.checkBoxTop.Checked = true;
            this.checkBoxTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTop.Location = new System.Drawing.Point(47, 69);
            this.checkBoxTop.Name = "checkBoxTop";
            this.checkBoxTop.Size = new System.Drawing.Size(66, 16);
            this.checkBoxTop.TabIndex = 11;
            this.checkBoxTop.Text = "TopMost";
            this.checkBoxTop.UseVisualStyleBackColor = true;
            this.checkBoxTop.CheckedChanged += new System.EventHandler(this.checkBoxTop_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 183);
            this.Controls.Add(this.checkBoxTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textIn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "ColorPick";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textIn;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxTop;
    }
}

