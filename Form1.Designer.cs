
namespace BiliBiliVideoDownloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.URLLabel = new System.Windows.Forms.Label();
            this.dirlabel1 = new System.Windows.Forms.Label();
            this.dirbutton1 = new System.Windows.Forms.Button();
            this.getCookielabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(200, 42);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(369, 20);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "软件界面有一点丑，但是不影响这个比较牛马的下载器";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 27);
            this.textBox1.TabIndex = 1;
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.Location = new System.Drawing.Point(41, 89);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(249, 20);
            this.URLLabel.TabIndex = 2;
            this.URLLabel.Text = "请在这里输入你要下载的视频的链接";
            // 
            // dirlabel1
            // 
            this.dirlabel1.AutoSize = true;
            this.dirlabel1.Location = new System.Drawing.Point(508, 89);
            this.dirlabel1.Name = "dirlabel1";
            this.dirlabel1.Size = new System.Drawing.Size(189, 20);
            this.dirlabel1.TabIndex = 3;
            this.dirlabel1.Text = "请在这里选择您的下载目录";
            // 
            // dirbutton1
            // 
            this.dirbutton1.Location = new System.Drawing.Point(554, 129);
            this.dirbutton1.Name = "dirbutton1";
            this.dirbutton1.Size = new System.Drawing.Size(94, 29);
            this.dirbutton1.TabIndex = 4;
            this.dirbutton1.Text = "选择目录";
            this.dirbutton1.UseVisualStyleBackColor = true;
            this.dirbutton1.Click += new System.EventHandler(this.dirbutton1_Click);
            // 
            // getCookielabel1
            // 
            this.getCookielabel1.AutoSize = true;
            this.getCookielabel1.Location = new System.Drawing.Point(41, 241);
            this.getCookielabel1.Name = "getCookielabel1";
            this.getCookielabel1.Size = new System.Drawing.Size(293, 20);
            this.getCookielabel1.TabIndex = 5;
            this.getCookielabel1.Text = "请在这里选择你的cookie数据库文件(可选)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "最后，准备好下载了吗？";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "开始下载";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(554, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "会员下载";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "如果选择了cookie文件,请使用会员下载";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getCookielabel1);
            this.Controls.Add(this.dirbutton1);
            this.Controls.Add(this.dirlabel1);
            this.Controls.Add(this.URLLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InstructionLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BiliBiliVideoDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.Label dirlabel1;
        private System.Windows.Forms.Button dirbutton1;
        private System.Windows.Forms.Label getCookielabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}

