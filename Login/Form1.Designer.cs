
namespace Login
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
            this.first_name_txt = new System.Windows.Forms.TextBox();
            this.sign_up_btn = new System.Windows.Forms.Button();
            this.first_name_lbl = new System.Windows.Forms.Label();
            this.last_name_lbl = new System.Windows.Forms.Label();
            this.last_name_txt = new System.Windows.Forms.TextBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // first_name_txt
            // 
            this.first_name_txt.Location = new System.Drawing.Point(253, 153);
            this.first_name_txt.Name = "first_name_txt";
            this.first_name_txt.Size = new System.Drawing.Size(202, 31);
            this.first_name_txt.TabIndex = 0;
            // 
            // sign_up_btn
            // 
            this.sign_up_btn.Location = new System.Drawing.Point(253, 602);
            this.sign_up_btn.Name = "sign_up_btn";
            this.sign_up_btn.Size = new System.Drawing.Size(183, 65);
            this.sign_up_btn.TabIndex = 1;
            this.sign_up_btn.Text = "Sign Up";
            this.sign_up_btn.UseVisualStyleBackColor = true;
            this.sign_up_btn.Click += new System.EventHandler(this.sign_up_btn_Click);
            // 
            // first_name_lbl
            // 
            this.first_name_lbl.AutoSize = true;
            this.first_name_lbl.Location = new System.Drawing.Point(103, 156);
            this.first_name_lbl.Name = "first_name_lbl";
            this.first_name_lbl.Size = new System.Drawing.Size(116, 25);
            this.first_name_lbl.TabIndex = 2;
            this.first_name_lbl.Text = "First Name";
            // 
            // last_name_lbl
            // 
            this.last_name_lbl.AutoSize = true;
            this.last_name_lbl.Location = new System.Drawing.Point(103, 256);
            this.last_name_lbl.Name = "last_name_lbl";
            this.last_name_lbl.Size = new System.Drawing.Size(115, 25);
            this.last_name_lbl.TabIndex = 3;
            this.last_name_lbl.Text = "Last Name";
            // 
            // last_name_txt
            // 
            this.last_name_txt.Location = new System.Drawing.Point(253, 250);
            this.last_name_txt.Name = "last_name_txt";
            this.last_name_txt.Size = new System.Drawing.Size(202, 31);
            this.last_name_txt.TabIndex = 4;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(103, 369);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(72, 25);
            this.email_lbl.TabIndex = 5;
            this.email_lbl.Text = "E-mail";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(253, 363);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(202, 31);
            this.email_txt.TabIndex = 6;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(56, 602);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(149, 65);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(253, 456);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(202, 31);
            this.password_txt.TabIndex = 8;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(103, 462);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(106, 25);
            this.password_lbl.TabIndex = 9;
            this.password_lbl.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 51);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registration";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(477, 602);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(149, 65);
            this.clear_btn.TabIndex = 11;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 710);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.last_name_txt);
            this.Controls.Add(this.last_name_lbl);
            this.Controls.Add(this.first_name_lbl);
            this.Controls.Add(this.sign_up_btn);
            this.Controls.Add(this.first_name_txt);
            this.Name = "Form1";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_name_txt;
        private System.Windows.Forms.Button sign_up_btn;
        private System.Windows.Forms.Label first_name_lbl;
        private System.Windows.Forms.Label last_name_lbl;
        private System.Windows.Forms.TextBox last_name_txt;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear_btn;
    }
}

