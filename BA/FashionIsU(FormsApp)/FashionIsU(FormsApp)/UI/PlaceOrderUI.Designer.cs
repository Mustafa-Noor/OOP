namespace FashionIsU_FormsApp_.UI
{
    partial class PlaceOrderUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BuyItemLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentMethodLABEL = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.PaymentCombo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SetPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AmountLabelAfterPayment = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PlaceOrderbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.BuyItemLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 86);
            this.panel1.TabIndex = 8;
            // 
            // BuyItemLabel
            // 
            this.BuyItemLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BuyItemLabel.AutoSize = true;
            this.BuyItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuyItemLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.BuyItemLabel.Font = new System.Drawing.Font("Palatino Linotype", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyItemLabel.ForeColor = System.Drawing.Color.White;
            this.BuyItemLabel.Location = new System.Drawing.Point(264, 17);
            this.BuyItemLabel.Name = "BuyItemLabel";
            this.BuyItemLabel.Size = new System.Drawing.Size(332, 45);
            this.BuyItemLabel.TabIndex = 2;
            this.BuyItemLabel.Text = "Place An Order Page";
            this.BuyItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address
            // 
            this.address.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.address.Location = new System.Drawing.Point(312, 503);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(468, 22);
            this.address.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Enter Your Delivery Address";
            // 
            // PaymentMethodLABEL
            // 
            this.PaymentMethodLABEL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaymentMethodLABEL.AutoSize = true;
            this.PaymentMethodLABEL.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLABEL.ForeColor = System.Drawing.Color.White;
            this.PaymentMethodLABEL.Location = new System.Drawing.Point(106, 117);
            this.PaymentMethodLABEL.Name = "PaymentMethodLABEL";
            this.PaymentMethodLABEL.Size = new System.Drawing.Size(226, 23);
            this.PaymentMethodLABEL.TabIndex = 48;
            this.PaymentMethodLABEL.Text = "Select Your Payment Method";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AmountLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(132, 100);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(464, 27);
            this.AmountLabel.TabIndex = 52;
            this.AmountLabel.Text = "Your Total Amount According To Your Cart is : Rs ";
            // 
            // PaymentCombo
            // 
            this.PaymentCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaymentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentCombo.FormattingEnabled = true;
            this.PaymentCombo.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.PaymentCombo.Location = new System.Drawing.Point(367, 117);
            this.PaymentCombo.Name = "PaymentCombo";
            this.PaymentCombo.Size = new System.Drawing.Size(201, 24);
            this.PaymentCombo.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.SetPayment);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PaymentMethodLABEL);
            this.panel2.Controls.Add(this.PaymentCombo);
            this.panel2.Location = new System.Drawing.Point(41, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 210);
            this.panel2.TabIndex = 54;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SetPayment
            // 
            this.SetPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SetPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SetPayment.Location = new System.Drawing.Point(555, 159);
            this.SetPayment.Name = "SetPayment";
            this.SetPayment.Size = new System.Drawing.Size(165, 36);
            this.SetPayment.TabIndex = 54;
            this.SetPayment.Text = "Set Payment Method";
            this.SetPayment.UseVisualStyleBackColor = false;
            this.SetPayment.Click += new System.EventHandler(this.SetPayment_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 27);
            this.label1.TabIndex = 54;
            this.label1.Text = "Cash on Delivery will cost 300Rs and Card will give you a Discount of 20%";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.AmountLabelAfterPayment);
            this.panel3.Location = new System.Drawing.Point(41, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 74);
            this.panel3.TabIndex = 55;
            // 
            // AmountLabelAfterPayment
            // 
            this.AmountLabelAfterPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AmountLabelAfterPayment.AutoSize = true;
            this.AmountLabelAfterPayment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AmountLabelAfterPayment.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabelAfterPayment.ForeColor = System.Drawing.Color.White;
            this.AmountLabelAfterPayment.Location = new System.Drawing.Point(28, 30);
            this.AmountLabelAfterPayment.Name = "AmountLabelAfterPayment";
            this.AmountLabelAfterPayment.Size = new System.Drawing.Size(593, 27);
            this.AmountLabelAfterPayment.TabIndex = 53;
            this.AmountLabelAfterPayment.Text = "Your Total Amount After Your Payment Method Selection Is : Rs ";
            this.AmountLabelAfterPayment.Click += new System.EventHandler(this.AmountLabelAfterPayment_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PlaceOrderbtn
            // 
            this.PlaceOrderbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlaceOrderbtn.BackColor = System.Drawing.Color.Black;
            this.PlaceOrderbtn.Font = new System.Drawing.Font("Palatino Linotype", 10F);
            this.PlaceOrderbtn.ForeColor = System.Drawing.Color.White;
            this.PlaceOrderbtn.Location = new System.Drawing.Point(324, 577);
            this.PlaceOrderbtn.Name = "PlaceOrderbtn";
            this.PlaceOrderbtn.Size = new System.Drawing.Size(222, 50);
            this.PlaceOrderbtn.TabIndex = 89;
            this.PlaceOrderbtn.Text = "Place Order";
            this.PlaceOrderbtn.UseVisualStyleBackColor = false;
            this.PlaceOrderbtn.Click += new System.EventHandler(this.PlaceOrderbtn_Click);
            // 
            // PlaceOrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.PlaceOrderbtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "PlaceOrderUI";
            this.Text = "PlaceOrderUI";
            this.Load += new System.EventHandler(this.PlaceOrderUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BuyItemLabel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PaymentMethodLABEL;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ComboBox PaymentCombo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label AmountLabelAfterPayment;
        private System.Windows.Forms.Button SetPayment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button PlaceOrderbtn;
    }
}