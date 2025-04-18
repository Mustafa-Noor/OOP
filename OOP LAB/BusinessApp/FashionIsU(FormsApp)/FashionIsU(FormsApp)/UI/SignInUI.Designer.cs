﻿namespace FashionIsU_FormsApp_.UI
{
    partial class SignInUI
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
            this.components = new System.ComponentModel.Container();
            this.SignInbtn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.RoleCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // SignInbtn
            // 
            this.SignInbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SignInbtn.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.SignInbtn.Location = new System.Drawing.Point(468, 415);
            this.SignInbtn.Name = "SignInbtn";
            this.SignInbtn.Size = new System.Drawing.Size(169, 42);
            this.SignInbtn.TabIndex = 48;
            this.SignInbtn.Text = "Sign In";
            this.SignInbtn.UseVisualStyleBackColor = false;
            this.SignInbtn.Click += new System.EventHandler(this.SignInbtn_Click);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Location = new System.Drawing.Point(379, 350);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(201, 22);
            this.password.TabIndex = 47;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.Location = new System.Drawing.Point(379, 298);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(201, 22);
            this.username.TabIndex = 46;
            // 
            // RoleCombo
            // 
            this.RoleCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleCombo.FormattingEnabled = true;
            this.RoleCombo.Items.AddRange(new object[] {
            "Employee",
            "Customer"});
            this.RoleCombo.Location = new System.Drawing.Point(379, 247);
            this.RoleCombo.Name = "RoleCombo";
            this.RoleCombo.Size = new System.Drawing.Size(201, 24);
            this.RoleCombo.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 44;
            this.label5.Text = "Select Role";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 38);
            this.label4.TabIndex = 43;
            this.label4.Text = "Sign In Page";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SignUpLink
            // 
            this.SignUpLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLink.Location = new System.Drawing.Point(513, 490);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(67, 23);
            this.SignUpLink.TabIndex = 42;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "SignUp";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(312, 490);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(177, 23);
            this.label.TabIndex = 41;
            this.label.Text = "Or just Sign Up Here..";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Password (6-Digits)";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(276, 296);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(88, 23);
            this.UsernameLabel.TabIndex = 39;
            this.UsernameLabel.Text = "Username";
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NamePanel.Controls.Add(this.label1);
            this.NamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(934, 62);
            this.NamePanel.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fashion Is U";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Welcome To Fashion Is U";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReturnBtn.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.ReturnBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ReturnBtn.Location = new System.Drawing.Point(251, 415);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(169, 42);
            this.ReturnBtn.TabIndex = 77;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // SignInUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.SignInbtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.RoleCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SignUpLink);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.NamePanel);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(952, 608);
            this.Name = "SignInUI";
            this.Text = "Sign In Page";
            this.Load += new System.EventHandler(this.SignInUI_Load);
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignInbtn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.ComboBox RoleCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel SignUpLink;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}