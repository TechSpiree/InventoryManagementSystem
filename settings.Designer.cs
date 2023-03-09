namespace IMS
{
    partial class settings
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
            this.DBTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ServerTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ISCBDD = new System.Windows.Forms.CheckBox();
            this.ServerErrorLabel = new System.Windows.Forms.Label();
            this.DBErrorLabel = new System.Windows.Forms.Label();
            this.usernamerrorlabel = new System.Windows.Forms.Label();
            this.passerrorlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(255, 765);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ISCBDD);
            this.LeftPanel.Controls.Add(this.PassTxt);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.UsernameTxt);
            this.LeftPanel.Controls.Add(this.label6);
            this.LeftPanel.Controls.Add(this.DBTxt);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.SaveBtn);
            this.LeftPanel.Controls.Add(this.ServerTxt);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Controls.Add(this.ServerErrorLabel);
            this.LeftPanel.Controls.Add(this.DBErrorLabel);
            this.LeftPanel.Controls.Add(this.usernamerrorlabel);
            this.LeftPanel.Controls.Add(this.passerrorlabel);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(5);
            this.LeftPanel.Size = new System.Drawing.Size(255, 703);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(255, 62);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(167, 23);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(255, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(896, 61);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(255, 61);
            this.panel4.Size = new System.Drawing.Size(896, 704);
            // 
            // DBTxt
            // 
            this.DBTxt.Location = new System.Drawing.Point(3, 159);
            this.DBTxt.Name = "DBTxt";
            this.DBTxt.Size = new System.Drawing.Size(244, 23);
            this.DBTxt.TabIndex = 9;
            this.DBTxt.TextChanged += new System.EventHandler(this.DBTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Database";
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderSize = 2;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(3, 322);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(248, 52);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ServerTxt
            // 
            this.ServerTxt.Location = new System.Drawing.Point(4, 106);
            this.ServerTxt.Multiline = true;
            this.ServerTxt.Name = "ServerTxt";
            this.ServerTxt.Size = new System.Drawing.Size(244, 23);
            this.ServerTxt.TabIndex = 6;
            this.ServerTxt.TextChanged += new System.EventHandler(this.ServerTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Source";
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(2, 262);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(243, 23);
            this.PassTxt.TabIndex = 13;
            this.PassTxt.UseSystemPasswordChar = true;
            this.PassTxt.TextChanged += new System.EventHandler(this.PassTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(2, 209);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(248, 23);
            this.UsernameTxt.TabIndex = 11;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.UsernameTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Username";
            // 
            // ISCBDD
            // 
            this.ISCBDD.AutoSize = true;
            this.ISCBDD.Location = new System.Drawing.Point(7, 293);
            this.ISCBDD.Name = "ISCBDD";
            this.ISCBDD.Size = new System.Drawing.Size(125, 19);
            this.ISCBDD.TabIndex = 14;
            this.ISCBDD.Text = "Integrated Security";
            this.ISCBDD.UseVisualStyleBackColor = true;
            this.ISCBDD.CheckedChanged += new System.EventHandler(this.ISCBDD_CheckedChanged);
            // 
            // ServerErrorLabel
            // 
            this.ServerErrorLabel.AutoSize = true;
            this.ServerErrorLabel.BackColor = System.Drawing.Color.Gray;
            this.ServerErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ServerErrorLabel.Location = new System.Drawing.Point(225, 88);
            this.ServerErrorLabel.Name = "ServerErrorLabel";
            this.ServerErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.ServerErrorLabel.TabIndex = 15;
            this.ServerErrorLabel.Text = "*";
            this.ServerErrorLabel.Visible = false;
            // 
            // DBErrorLabel
            // 
            this.DBErrorLabel.AutoSize = true;
            this.DBErrorLabel.BackColor = System.Drawing.Color.Gray;
            this.DBErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.DBErrorLabel.Location = new System.Drawing.Point(227, 141);
            this.DBErrorLabel.Name = "DBErrorLabel";
            this.DBErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.DBErrorLabel.TabIndex = 16;
            this.DBErrorLabel.Text = "*";
            this.DBErrorLabel.Visible = false;
            // 
            // usernamerrorlabel
            // 
            this.usernamerrorlabel.AutoSize = true;
            this.usernamerrorlabel.BackColor = System.Drawing.Color.Gray;
            this.usernamerrorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamerrorlabel.ForeColor = System.Drawing.Color.Maroon;
            this.usernamerrorlabel.Location = new System.Drawing.Point(225, 190);
            this.usernamerrorlabel.Name = "usernamerrorlabel";
            this.usernamerrorlabel.Size = new System.Drawing.Size(20, 25);
            this.usernamerrorlabel.TabIndex = 17;
            this.usernamerrorlabel.Text = "*";
            this.usernamerrorlabel.Visible = false;
            // 
            // passerrorlabel
            // 
            this.passerrorlabel.AutoSize = true;
            this.passerrorlabel.BackColor = System.Drawing.Color.Gray;
            this.passerrorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passerrorlabel.ForeColor = System.Drawing.Color.Maroon;
            this.passerrorlabel.Location = new System.Drawing.Point(225, 243);
            this.passerrorlabel.Name = "passerrorlabel";
            this.passerrorlabel.Size = new System.Drawing.Size(20, 25);
            this.passerrorlabel.TabIndex = 18;
            this.passerrorlabel.Text = "*";
            this.passerrorlabel.Visible = false;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 765);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DBTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox ServerTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ISCBDD;
        private System.Windows.Forms.Label ServerErrorLabel;
        private System.Windows.Forms.Label DBErrorLabel;
        private System.Windows.Forms.Label usernamerrorlabel;
        private System.Windows.Forms.Label passerrorlabel;
    }
}