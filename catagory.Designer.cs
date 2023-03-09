namespace IMS
{
    partial class catagory
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
            this.label4 = new System.Windows.Forms.Label();
            this.CattxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ActiveDD = new System.Windows.Forms.ComboBox();
            this.carerrorlabel = new System.Windows.Forms.Label();
            this.acriveerrorlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Size = new System.Drawing.Size(255, 735);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ActiveDD);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.CattxtBox);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.acriveerrorlabel);
            this.LeftPanel.Controls.Add(this.carerrorlabel);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LeftPanel.Size = new System.Drawing.Size(255, 673);
            this.LeftPanel.Controls.SetChildIndex(this.carerrorlabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.acriveerrorlabel, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CattxtBox, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ActiveDD, 0);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Size = new System.Drawing.Size(789, 61);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(789, 674);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "In-Active";
            // 
            // CattxtBox
            // 
            this.CattxtBox.Location = new System.Drawing.Point(7, 209);
            this.CattxtBox.Name = "CattxtBox";
            this.CattxtBox.Size = new System.Drawing.Size(241, 23);
            this.CattxtBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category Name";
            // 
            // ActiveDD
            // 
            this.ActiveDD.FormattingEnabled = true;
            this.ActiveDD.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.ActiveDD.Location = new System.Drawing.Point(7, 254);
            this.ActiveDD.Name = "ActiveDD";
            this.ActiveDD.Size = new System.Drawing.Size(241, 23);
            this.ActiveDD.TabIndex = 9;
            // 
            // carerrorlabel
            // 
            this.carerrorlabel.AutoSize = true;
            this.carerrorlabel.BackColor = System.Drawing.Color.Gray;
            this.carerrorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carerrorlabel.ForeColor = System.Drawing.Color.Maroon;
            this.carerrorlabel.Location = new System.Drawing.Point(93, 189);
            this.carerrorlabel.Name = "carerrorlabel";
            this.carerrorlabel.Size = new System.Drawing.Size(20, 25);
            this.carerrorlabel.TabIndex = 10;
            this.carerrorlabel.Text = "*";
            this.carerrorlabel.Visible = false;
            this.carerrorlabel.Click += new System.EventHandler(this.carerrorlabel_Click);
            // 
            // acriveerrorlabel
            // 
            this.acriveerrorlabel.AutoSize = true;
            this.acriveerrorlabel.BackColor = System.Drawing.Color.Gray;
            this.acriveerrorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acriveerrorlabel.ForeColor = System.Drawing.Color.Maroon;
            this.acriveerrorlabel.Location = new System.Drawing.Point(92, 235);
            this.acriveerrorlabel.Name = "acriveerrorlabel";
            this.acriveerrorlabel.Size = new System.Drawing.Size(20, 25);
            this.acriveerrorlabel.TabIndex = 11;
            this.acriveerrorlabel.Text = "*";
            this.acriveerrorlabel.Visible = false;
            // 
            // catagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 735);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "catagory";
            this.Text = "catagory";
            this.Load += new System.EventHandler(this.catagory_Load);
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CattxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ActiveDD;
        private System.Windows.Forms.Label carerrorlabel;
        private System.Windows.Forms.Label acriveerrorlabel;
    }
}