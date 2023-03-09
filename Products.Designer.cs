namespace IMS
{
    partial class Products
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
            this.label3 = new System.Windows.Forms.Label();
            this.protxtbox = new System.Windows.Forms.TextBox();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(219, 755);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.comboBox1);
            this.LeftPanel.Controls.Add(this.a);
            this.LeftPanel.Controls.Add(this.Pricetxt);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.BarcodeTxt);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.protxtbox);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Size = new System.Drawing.Size(219, 702);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.protxtbox, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Pricetxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.a, 0);
            this.LeftPanel.Controls.SetChildIndex(this.comboBox1, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(930, 53);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(930, 702);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Name";
            // 
            // protxtbox
            // 
            this.protxtbox.Location = new System.Drawing.Point(6, 65);
            this.protxtbox.Name = "protxtbox";
            this.protxtbox.Size = new System.Drawing.Size(207, 20);
            this.protxtbox.TabIndex = 2;
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Location = new System.Drawing.Point(6, 104);
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(207, 20);
            this.BarcodeTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Barcode";
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(6, 143);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(207, 20);
            this.Pricetxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(3, 166);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(49, 13);
            this.a.TabIndex = 7;
            this.a.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 755);
            this.Name = "Products";
            this.Text = "Products";
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox protxtbox;
        private System.Windows.Forms.Label label3;
    }
}