namespace Employee_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpboxlogin = new System.Windows.Forms.GroupBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.grpboxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxlogin
            // 
            this.grpboxlogin.BackColor = System.Drawing.Color.Snow;
            this.grpboxlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.grpboxlogin.Controls.Add(this.txtpassword);
            this.grpboxlogin.Controls.Add(this.txtusername);
            this.grpboxlogin.Controls.Add(this.btnlogin);
            this.grpboxlogin.Controls.Add(this.lblpassword);
            this.grpboxlogin.Controls.Add(this.lblusername);
            this.grpboxlogin.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxlogin.ForeColor = System.Drawing.Color.Navy;
            this.grpboxlogin.Location = new System.Drawing.Point(251, 147);
            this.grpboxlogin.Name = "grpboxlogin";
            this.grpboxlogin.Size = new System.Drawing.Size(421, 329);
            this.grpboxlogin.TabIndex = 2;
            this.grpboxlogin.TabStop = false;
            this.grpboxlogin.Text = "Employee Login";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(40, 211);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(258, 28);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(40, 118);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(264, 28);
            this.txtusername.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Navy;
            this.btnlogin.Location = new System.Drawing.Point(150, 272);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(148, 32);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.Navy;
            this.lblpassword.Location = new System.Drawing.Point(36, 174);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(100, 21);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblusername.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Navy;
            this.lblusername.Location = new System.Drawing.Point(36, 81);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(106, 21);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 681);
            this.Controls.Add(this.grpboxlogin);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxlogin.ResumeLayout(false);
            this.grpboxlogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
    }
}

