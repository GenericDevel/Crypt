namespace Crypt_Csharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDES = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeDES = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plain Text";
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(105, 29);
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(267, 21);
            this.txtPlain.TabIndex = 1;
            this.txtPlain.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "DES Text";
            // 
            // txtDES
            // 
            this.txtDES.Location = new System.Drawing.Point(105, 56);
            this.txtDES.Name = "txtDES";
            this.txtDES.Size = new System.Drawing.Size(267, 21);
            this.txtDES.TabIndex = 1;
            this.txtDES.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "DeDES Text";
            // 
            // txtDeDES
            // 
            this.txtDeDES.Location = new System.Drawing.Point(105, 83);
            this.txtDeDES.Name = "txtDeDES";
            this.txtDeDES.Size = new System.Drawing.Size(267, 21);
            this.txtDeDES.TabIndex = 1;
            this.txtDeDES.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "MD5 Text";
            // 
            // txtMD5
            // 
            this.txtMD5.Location = new System.Drawing.Point(105, 110);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(267, 21);
            this.txtMD5.TabIndex = 1;
            this.txtMD5.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 221);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeDES);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Crypt Demo";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeDES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.Button button1;
    }
}

