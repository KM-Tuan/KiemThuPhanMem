namespace BaiTapLon_45_Tuan
{
    partial class FormRegister_45_Tuan
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
            this.tbRegisterU_45_Tuan = new System.Windows.Forms.TextBox();
            this.tbRegisterP_45_Tuan = new System.Windows.Forms.TextBox();
            this.tbRegisterCP_45_Tuan = new System.Windows.Forms.TextBox();
            this.btRegister_45_Tuan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRegisterU_45_Tuan
            // 
            this.tbRegisterU_45_Tuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRegisterU_45_Tuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterU_45_Tuan.Location = new System.Drawing.Point(222, 31);
            this.tbRegisterU_45_Tuan.Multiline = true;
            this.tbRegisterU_45_Tuan.Name = "tbRegisterU_45_Tuan";
            this.tbRegisterU_45_Tuan.Size = new System.Drawing.Size(223, 34);
            this.tbRegisterU_45_Tuan.TabIndex = 0;
            // 
            // tbRegisterP_45_Tuan
            // 
            this.tbRegisterP_45_Tuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRegisterP_45_Tuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterP_45_Tuan.Location = new System.Drawing.Point(222, 71);
            this.tbRegisterP_45_Tuan.Multiline = true;
            this.tbRegisterP_45_Tuan.Name = "tbRegisterP_45_Tuan";
            this.tbRegisterP_45_Tuan.PasswordChar = '*';
            this.tbRegisterP_45_Tuan.Size = new System.Drawing.Size(223, 34);
            this.tbRegisterP_45_Tuan.TabIndex = 1;
            // 
            // tbRegisterCP_45_Tuan
            // 
            this.tbRegisterCP_45_Tuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRegisterCP_45_Tuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterCP_45_Tuan.Location = new System.Drawing.Point(222, 111);
            this.tbRegisterCP_45_Tuan.Multiline = true;
            this.tbRegisterCP_45_Tuan.Name = "tbRegisterCP_45_Tuan";
            this.tbRegisterCP_45_Tuan.PasswordChar = '*';
            this.tbRegisterCP_45_Tuan.Size = new System.Drawing.Size(223, 34);
            this.tbRegisterCP_45_Tuan.TabIndex = 2;
            // 
            // btRegister_45_Tuan
            // 
            this.btRegister_45_Tuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister_45_Tuan.Location = new System.Drawing.Point(175, 174);
            this.btRegister_45_Tuan.Name = "btRegister_45_Tuan";
            this.btRegister_45_Tuan.Size = new System.Drawing.Size(140, 42);
            this.btRegister_45_Tuan.TabIndex = 3;
            this.btRegister_45_Tuan.Text = "Đăng ký";
            this.btRegister_45_Tuan.UseVisualStyleBackColor = true;
            this.btRegister_45_Tuan.Click += new System.EventHandler(this.btRegister_45_Tuan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Confirm Password";
            // 
            // FormRegister_45_Tuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 228);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRegister_45_Tuan);
            this.Controls.Add(this.tbRegisterCP_45_Tuan);
            this.Controls.Add(this.tbRegisterP_45_Tuan);
            this.Controls.Add(this.tbRegisterU_45_Tuan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegister_45_Tuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister_45_Tuan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRegisterU_45_Tuan;
        private System.Windows.Forms.TextBox tbRegisterP_45_Tuan;
        private System.Windows.Forms.TextBox tbRegisterCP_45_Tuan;
        private System.Windows.Forms.Button btRegister_45_Tuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}