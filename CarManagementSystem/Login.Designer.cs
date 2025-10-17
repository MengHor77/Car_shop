using System.Drawing;

namespace CarManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.checkBox_showpassword = new System.Windows.Forms.CheckBox();
            this.pictureBox_big = new System.Windows.Forms.PictureBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_big)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_username.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(55, 188);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(399, 38);
            this.textBox_username.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 54);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login Accuont";
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(55, 303);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(399, 38);
            this.textBox_password.TabIndex = 8;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // button_login
            // 
            this.button_login.AutoSize = true;
            this.button_login.BackColor = System.Drawing.Color.Blue;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(55, 420);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(400, 52);
            this.button_login.TabIndex = 9;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // checkBox_showpassword
            // 
            this.checkBox_showpassword.AutoSize = true;
            this.checkBox_showpassword.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_showpassword.ForeColor = System.Drawing.Color.White;
            this.checkBox_showpassword.Location = new System.Drawing.Point(285, 350);
            this.checkBox_showpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_showpassword.Name = "checkBox_showpassword";
            this.checkBox_showpassword.Size = new System.Drawing.Size(161, 24);
            this.checkBox_showpassword.TabIndex = 11;
            this.checkBox_showpassword.Text = "Show password";
            this.checkBox_showpassword.UseVisualStyleBackColor = true;
            this.checkBox_showpassword.CheckedChanged += new System.EventHandler(this.checkBox_showpassword_CheckedChanged);
            // 
            // pictureBox_big
            // 
            this.pictureBox_big.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_big.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_big.Image")));
            this.pictureBox_big.Location = new System.Drawing.Point(584, 54);
            this.pictureBox_big.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_big.Name = "pictureBox_big";
            this.pictureBox_big.Size = new System.Drawing.Size(467, 430);
            this.pictureBox_big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_big.TabIndex = 6;
            this.pictureBox_big.TabStop = false;
            this.pictureBox_big.Click += new System.EventHandler(this.pictureBox_big_Click);
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.labelpassword.Location = new System.Drawing.Point(53, 346);
            this.labelpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(0, 17);
            this.labelpassword.TabIndex = 13;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.labelusername.Location = new System.Drawing.Point(53, 231);
            this.labelusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(0, 17);
            this.labelusername.TabIndex = 14;
            // 
            // label4
            // 
            //this.label4.AutoSize = true;
            //this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.label4.ForeColor = System.Drawing.Color.Orange;
            //this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.label4.Location = new System.Drawing.Point(577, 9);
            //this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            //this.label4.Name = "label4";
            //this.label4.Size = new System.Drawing.Size(211, 40);
            //this.label4.TabIndex = 15;
            //this.label4.Text = "POS SYSTEM";
            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 22F, FontStyle.Bold | FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(400, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "MY POS SYSTEM";
            this.label4.TextAlign = ContentAlignment.MiddleCenter;

            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.checkBox_showpassword);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_big);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1082, 550);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_big)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.CheckBox checkBox_showpassword;
        private System.Windows.Forms.PictureBox pictureBox_big;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label label4;
    }
}

