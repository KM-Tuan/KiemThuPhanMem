namespace BaiTapLon_45_Tuan
{
    partial class FormLogin_45_Tuan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername_45_Tuan = new System.Windows.Forms.TextBox();
            this.tbPassword_45_Tuan = new System.Windows.Forms.TextBox();
            this.btLogin_45_Tuan = new System.Windows.Forms.Button();
            this.btRegister_45_Tuan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbUsername_45_Tuan
            // 
            this.tbUsername_45_Tuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsername_45_Tuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername_45_Tuan.Location = new System.Drawing.Point(210, 30);
            this.tbUsername_45_Tuan.Multiline = true;
            this.tbUsername_45_Tuan.Name = "tbUsername_45_Tuan";
            this.tbUsername_45_Tuan.Size = new System.Drawing.Size(223, 34);
            this.tbUsername_45_Tuan.TabIndex = 0;
            // 
            // tbPassword_45_Tuan
            // 
            this.tbPassword_45_Tuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword_45_Tuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword_45_Tuan.Location = new System.Drawing.Point(210, 85);
            this.tbPassword_45_Tuan.Multiline = true;
            this.tbPassword_45_Tuan.Name = "tbPassword_45_Tuan";
            this.tbPassword_45_Tuan.PasswordChar = '*';
            this.tbPassword_45_Tuan.Size = new System.Drawing.Size(223, 34);
            this.tbPassword_45_Tuan.TabIndex = 1;
            // 
            // btLogin_45_Tuan
            // 
            this.btLogin_45_Tuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin_45_Tuan.Location = new System.Drawing.Point(118, 145);
            this.btLogin_45_Tuan.Name = "btLogin_45_Tuan";
            this.btLogin_45_Tuan.Size = new System.Drawing.Size(140, 42);
            this.btLogin_45_Tuan.TabIndex = 2;
            this.btLogin_45_Tuan.Text = "Đăng nhập";
            this.btLogin_45_Tuan.UseVisualStyleBackColor = true;
            this.btLogin_45_Tuan.Click += new System.EventHandler(this.btLogin_45_Tuan_Click);
            // 
            // btRegister_45_Tuan
            // 
            this.btRegister_45_Tuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister_45_Tuan.Location = new System.Drawing.Point(264, 145);
            this.btRegister_45_Tuan.Name = "btRegister_45_Tuan";
            this.btRegister_45_Tuan.Size = new System.Drawing.Size(140, 42);
            this.btRegister_45_Tuan.TabIndex = 3;
            this.btRegister_45_Tuan.Text = "Đăng ký";
            this.btRegister_45_Tuan.UseVisualStyleBackColor = true;
            this.btRegister_45_Tuan.Click += new System.EventHandler(this.btRegister_45_Tuan_Click);
            // 
            // FormLogin_45_Tuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 214);
            this.Controls.Add(this.btRegister_45_Tuan);
            this.Controls.Add(this.btLogin_45_Tuan);
            this.Controls.Add(this.tbPassword_45_Tuan);
            this.Controls.Add(this.tbUsername_45_Tuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin_45_Tuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin_45_Tuan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername_45_Tuan;
        private System.Windows.Forms.TextBox tbPassword_45_Tuan;
        private System.Windows.Forms.Button btLogin_45_Tuan;
        private System.Windows.Forms.Button btRegister_45_Tuan;
    }
}

