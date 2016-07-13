namespace SEOAutomation.Winform
{
    partial class ConfigAdwordEdit
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
            this.Header = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantityClick = new System.Windows.Forms.TextBox();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIntervalClick = new System.Windows.Forms.TextBox();
            this.txtPageLimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTextLink = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTextBackLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAdsen = new System.Windows.Forms.CheckBox();
            this.chkBackLink = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtGridAdwordConfig = new System.Windows.Forms.DataGridView();
            this.colDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdWordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkQuantityClick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntervalClick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBackLink = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TextLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBackLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAdsen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PageLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAdwordConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Control;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Enabled = false;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.DimGray;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1113, 31);
            this.Header.TabIndex = 1;
            this.Header.Text = "Config View Link";
            this.Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(107, 48);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(442, 20);
            this.txtURL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity Click";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interval Click";
            // 
            // txtQuantityClick
            // 
            this.txtQuantityClick.Location = new System.Drawing.Point(107, 117);
            this.txtQuantityClick.Name = "txtQuantityClick";
            this.txtQuantityClick.Size = new System.Drawing.Size(214, 20);
            this.txtQuantityClick.TabIndex = 11;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(107, 74);
            this.txtKeyWord.Multiline = true;
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(938, 33);
            this.txtKeyWord.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "KeyWord";
            // 
            // txtIntervalClick
            // 
            this.txtIntervalClick.Location = new System.Drawing.Point(438, 118);
            this.txtIntervalClick.Name = "txtIntervalClick";
            this.txtIntervalClick.Size = new System.Drawing.Size(182, 20);
            this.txtIntervalClick.TabIndex = 14;
            // 
            // txtPageLimit
            // 
            this.txtPageLimit.Location = new System.Drawing.Point(726, 114);
            this.txtPageLimit.Name = "txtPageLimit";
            this.txtPageLimit.Size = new System.Drawing.Size(319, 20);
            this.txtPageLimit.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(649, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Page Limit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTextLink);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKeyWord);
            this.groupBox1.Controls.Add(this.txtPageLimit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Controls.Add(this.txtIntervalClick);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtQuantityClick);
            this.groupBox1.Location = new System.Drawing.Point(28, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 209);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Config";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(645, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(588, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Text Link";
            // 
            // txtTextLink
            // 
            this.txtTextLink.Location = new System.Drawing.Point(662, 47);
            this.txtTextLink.Name = "txtTextLink";
            this.txtTextLink.Size = new System.Drawing.Size(383, 20);
            this.txtTextLink.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(709, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(412, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(89, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(68, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(40, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "*";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(905, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 27);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTextBackLink);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkAdsen);
            this.groupBox2.Controls.Add(this.chkBackLink);
            this.groupBox2.Location = new System.Drawing.Point(28, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1056, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Back Link";
            // 
            // txtTextBackLink
            // 
            this.txtTextBackLink.Location = new System.Drawing.Point(778, 19);
            this.txtTextBackLink.Multiline = true;
            this.txtTextBackLink.Name = "txtTextBackLink";
            this.txtTextBackLink.Size = new System.Drawing.Size(267, 58);
            this.txtTextBackLink.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "TextBack Link";
            // 
            // chkAdsen
            // 
            this.chkAdsen.AutoSize = true;
            this.chkAdsen.Location = new System.Drawing.Point(493, 40);
            this.chkAdsen.Name = "chkAdsen";
            this.chkAdsen.Size = new System.Drawing.Size(56, 17);
            this.chkAdsen.TabIndex = 2;
            this.chkAdsen.Text = "Adsen";
            this.chkAdsen.UseVisualStyleBackColor = true;
            // 
            // chkBackLink
            // 
            this.chkBackLink.AutoSize = true;
            this.chkBackLink.Location = new System.Drawing.Point(271, 41);
            this.chkBackLink.Name = "chkBackLink";
            this.chkBackLink.Size = new System.Drawing.Size(70, 17);
            this.chkBackLink.TabIndex = 1;
            this.chkBackLink.Text = "Back link";
            this.chkBackLink.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1000, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 27);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtGridAdwordConfig
            // 
            this.dtGridAdwordConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAdwordConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelete,
            this.url,
            this.AdWordID,
            this.KeyWord,
            this.LinkQuantityClick,
            this.IntervalClick,
            this.IsBackLink,
            this.TextLink,
            this.TextBackLink,
            this.IsAdsen,
            this.PageLimit});
            this.dtGridAdwordConfig.Location = new System.Drawing.Point(28, 414);
            this.dtGridAdwordConfig.Name = "dtGridAdwordConfig";
            this.dtGridAdwordConfig.Size = new System.Drawing.Size(1056, 150);
            this.dtGridAdwordConfig.TabIndex = 20;
            this.dtGridAdwordConfig.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridAdwordConfig_CellDoubleClick);
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDelete.Width = 40;
            // 
            // url
            // 
            this.url.DataPropertyName = "URL";
            this.url.HeaderText = "URL";
            this.url.Name = "url";
            this.url.Width = 200;
            // 
            // AdWordID
            // 
            this.AdWordID.DataPropertyName = "ID";
            this.AdWordID.HeaderText = "ID";
            this.AdWordID.Name = "AdWordID";
            this.AdWordID.Visible = false;
            // 
            // KeyWord
            // 
            this.KeyWord.DataPropertyName = "KeyWord";
            this.KeyWord.HeaderText = "Key Word";
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Width = 200;
            // 
            // LinkQuantityClick
            // 
            this.LinkQuantityClick.DataPropertyName = "LinkQuantityClick";
            this.LinkQuantityClick.HeaderText = "Quantity Click";
            this.LinkQuantityClick.Name = "LinkQuantityClick";
            this.LinkQuantityClick.Width = 70;
            // 
            // IntervalClick
            // 
            this.IntervalClick.DataPropertyName = "IntervalClick";
            this.IntervalClick.HeaderText = "Inteval Click";
            this.IntervalClick.Name = "IntervalClick";
            this.IntervalClick.Width = 70;
            // 
            // IsBackLink
            // 
            this.IsBackLink.DataPropertyName = "IsBackLink";
            this.IsBackLink.HeaderText = "Back Link";
            this.IsBackLink.Name = "IsBackLink";
            this.IsBackLink.Width = 70;
            // 
            // TextLink
            // 
            this.TextLink.DataPropertyName = "TextLink";
            this.TextLink.HeaderText = "Text Link";
            this.TextLink.Name = "TextLink";
            this.TextLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TextLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TextLink.Width = 150;
            // 
            // TextBackLink
            // 
            this.TextBackLink.DataPropertyName = "TextBackLink";
            this.TextBackLink.HeaderText = "Text BackLink";
            this.TextBackLink.Name = "TextBackLink";
            // 
            // IsAdsen
            // 
            this.IsAdsen.DataPropertyName = "IsAdsen";
            this.IsAdsen.HeaderText = "Is Adsen";
            this.IsAdsen.Name = "IsAdsen";
            this.IsAdsen.Width = 70;
            // 
            // PageLimit
            // 
            this.PageLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PageLimit.DataPropertyName = "PageLimit";
            this.PageLimit.HeaderText = "Page Limit";
            this.PageLimit.Name = "PageLimit";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(803, 382);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 27);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear text";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ConfigAdwordEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 591);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtGridAdwordConfig);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Header);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigAdwordEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.ConfigAdwordEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAdwordConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantityClick;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIntervalClick;
        private System.Windows.Forms.TextBox txtPageLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTextBackLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAdsen;
        private System.Windows.Forms.CheckBox chkBackLink;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtGridAdwordConfig;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTextLink;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdWordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkQuantityClick;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntervalClick;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsBackLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextBackLink;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAdsen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageLimit;
    }
}

