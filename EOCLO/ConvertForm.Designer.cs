namespace EOCLO
{
    partial class ConvertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertForm));
            this.etDisplay = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.secondComboBox = new System.Windows.Forms.ComboBox();
            this.secondLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.hourComboBox = new System.Windows.Forms.ComboBox();
            this.minuteComboBox = new System.Windows.Forms.ComboBox();
            this.etLabel = new System.Windows.Forms.Label();
            this.moonAgeLabel = new System.Windows.Forms.Label();
            this.moonAgeDisplay = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.moonImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.moonAgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.borderBottom = new System.Windows.Forms.Label();
            this.borderLeft = new System.Windows.Forms.Label();
            this.borderRight = new System.Windows.Forms.Label();
            this.borderTop = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.border = new System.Windows.Forms.Label();
            this.moonImageBox = new System.Windows.Forms.PictureBox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.moonAgeComboBox = new System.Windows.Forms.ComboBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // etDisplay
            // 
            this.etDisplay.AutoSize = true;
            this.etDisplay.BackColor = System.Drawing.Color.Transparent;
            this.etDisplay.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.etDisplay.Location = new System.Drawing.Point(95, 211);
            this.etDisplay.Name = "etDisplay";
            this.etDisplay.Size = new System.Drawing.Size(61, 26);
            this.etDisplay.TabIndex = 14;
            this.etDisplay.Text = "- - : - -";
            // 
            // convertButton
            // 
            this.convertButton.FlatAppearance.BorderSize = 0;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Location = new System.Drawing.Point(230, 170);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(60, 23);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "変換";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // secondComboBox
            // 
            this.secondComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondComboBox.Location = new System.Drawing.Point(150, 140);
            this.secondComboBox.MaxLength = 2;
            this.secondComboBox.Name = "secondComboBox";
            this.secondComboBox.Size = new System.Drawing.Size(36, 20);
            this.secondComboBox.TabIndex = 7;
            this.secondComboBox.Leave += new System.EventHandler(this.SecondComboBox_Leave);
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(190, 145);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(17, 12);
            this.secondLabel.TabIndex = 13;
            this.secondLabel.Text = "秒";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(125, 145);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(17, 12);
            this.minuteLabel.TabIndex = 12;
            this.minuteLabel.Text = "分";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(60, 145);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(17, 12);
            this.hourLabel.TabIndex = 11;
            this.hourLabel.Text = "時";
            // 
            // hourComboBox
            // 
            this.hourComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hourComboBox.FormattingEnabled = true;
            this.hourComboBox.Location = new System.Drawing.Point(20, 140);
            this.hourComboBox.MaxLength = 2;
            this.hourComboBox.Name = "hourComboBox";
            this.hourComboBox.Size = new System.Drawing.Size(36, 20);
            this.hourComboBox.TabIndex = 5;
            this.hourComboBox.Leave += new System.EventHandler(this.HourComboBox_Leave);
            // 
            // minuteComboBox
            // 
            this.minuteComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minuteComboBox.FormattingEnabled = true;
            this.minuteComboBox.Location = new System.Drawing.Point(85, 140);
            this.minuteComboBox.MaxLength = 2;
            this.minuteComboBox.Name = "minuteComboBox";
            this.minuteComboBox.Size = new System.Drawing.Size(36, 20);
            this.minuteComboBox.TabIndex = 6;
            this.minuteComboBox.Leave += new System.EventHandler(this.MinuteComboBox_Leave);
            // 
            // etLabel
            // 
            this.etLabel.AutoSize = true;
            this.etLabel.Location = new System.Drawing.Point(20, 220);
            this.etLabel.Name = "etLabel";
            this.etLabel.Size = new System.Drawing.Size(76, 12);
            this.etLabel.TabIndex = 16;
            this.etLabel.Text = "エオルゼア時間";
            // 
            // moonAgeLabel
            // 
            this.moonAgeLabel.AutoSize = true;
            this.moonAgeLabel.Location = new System.Drawing.Point(165, 220);
            this.moonAgeLabel.Name = "moonAgeLabel";
            this.moonAgeLabel.Size = new System.Drawing.Size(29, 12);
            this.moonAgeLabel.TabIndex = 17;
            this.moonAgeLabel.Text = "月齢";
            // 
            // moonAgeDisplay
            // 
            this.moonAgeDisplay.AutoSize = true;
            this.moonAgeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.moonAgeDisplay.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.moonAgeDisplay.Location = new System.Drawing.Point(215, 222);
            this.moonAgeDisplay.Name = "moonAgeDisplay";
            this.moonAgeDisplay.Size = new System.Drawing.Size(27, 11);
            this.moonAgeDisplay.TabIndex = 18;
            this.moonAgeDisplay.Text = "－－";
            this.moonAgeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moonImageColumn,
            this.moonAgeColumn,
            this.localTimeColumn});
            this.dataGridView.Enabled = false;
            this.dataGridView.Location = new System.Drawing.Point(15, 245);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(360, 25);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.TabStop = false;
            // 
            // moonImageColumn
            // 
            this.moonImageColumn.HeaderText = "";
            this.moonImageColumn.Name = "moonImageColumn";
            this.moonImageColumn.ReadOnly = true;
            this.moonImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.moonImageColumn.Width = 30;
            // 
            // moonAgeColumn
            // 
            this.moonAgeColumn.HeaderText = "月齢";
            this.moonAgeColumn.Name = "moonAgeColumn";
            this.moonAgeColumn.ReadOnly = true;
            this.moonAgeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.moonAgeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.moonAgeColumn.Width = 110;
            // 
            // localTimeColumn
            // 
            this.localTimeColumn.HeaderText = "ローカル時間";
            this.localTimeColumn.Name = "localTimeColumn";
            this.localTimeColumn.ReadOnly = true;
            this.localTimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.localTimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.localTimeColumn.Width = 217;
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(362, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 28);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "×";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(362, 28);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "　　 　EOCLO  - EORZEA CLOCK -";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseMove);
            // 
            // borderBottom
            // 
            this.borderBottom.Location = new System.Drawing.Point(0, 0);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(100, 23);
            this.borderBottom.TabIndex = 25;
            // 
            // borderLeft
            // 
            this.borderLeft.Location = new System.Drawing.Point(0, 0);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(100, 23);
            this.borderLeft.TabIndex = 26;
            // 
            // borderRight
            // 
            this.borderRight.Location = new System.Drawing.Point(0, 0);
            this.borderRight.Name = "borderRight";
            this.borderRight.Size = new System.Drawing.Size(100, 23);
            this.borderRight.TabIndex = 27;
            // 
            // borderTop
            // 
            this.borderTop.Location = new System.Drawing.Point(0, 0);
            this.borderTop.Name = "borderTop";
            this.borderTop.Size = new System.Drawing.Size(100, 23);
            this.borderTop.TabIndex = 28;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(20, 111);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(185, 19);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // border
            // 
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border.Location = new System.Drawing.Point(25, 205);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(340, 1);
            this.border.TabIndex = 30;
            // 
            // moonImageBox
            // 
            this.moonImageBox.BackColor = System.Drawing.Color.Transparent;
            this.moonImageBox.Location = new System.Drawing.Point(197, 215);
            this.moonImageBox.Name = "moonImageBox";
            this.moonImageBox.Size = new System.Drawing.Size(16, 16);
            this.moonImageBox.TabIndex = 23;
            this.moonImageBox.TabStop = false;
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.Image = global::EOCLO.Properties.Resources.IconW32;
            this.iconBox.InitialImage = null;
            this.iconBox.Location = new System.Drawing.Point(4, 4);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(20, 20);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconBox.TabIndex = 22;
            this.iconBox.TabStop = false;
            // 
            // moonAgeComboBox
            // 
            this.moonAgeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.moonAgeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.moonAgeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moonAgeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moonAgeComboBox.Location = new System.Drawing.Point(20, 170);
            this.moonAgeComboBox.Name = "moonAgeComboBox";
            this.moonAgeComboBox.Size = new System.Drawing.Size(140, 20);
            this.moonAgeComboBox.TabIndex = 8;
            this.moonAgeComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MoonAgeComboBox_DrawItem);
            // 
            // outputButton
            // 
            this.outputButton.FlatAppearance.BorderSize = 0;
            this.outputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputButton.Location = new System.Drawing.Point(310, 170);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(60, 23);
            this.outputButton.TabIndex = 10;
            this.outputButton.Text = "出力";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(292, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "指定した日時のエオルゼア時間とエオルゼアの月齢を表示";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(300, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "指定日以降にエオルゼアで指定した月齢になる日時を表示";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 80);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(304, 16);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "指定日に指定したエオルゼア時間になるローカル時間を表示";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 285);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.moonAgeComboBox);
            this.Controls.Add(this.border);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.borderTop);
            this.Controls.Add(this.borderRight);
            this.Controls.Add(this.borderLeft);
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.moonImageBox);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.moonAgeDisplay);
            this.Controls.Add(this.moonAgeLabel);
            this.Controls.Add(this.etLabel);
            this.Controls.Add(this.etDisplay);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.secondComboBox);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.hourComboBox);
            this.Controls.Add(this.minuteComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConvertForm";
            this.Text = "LT・ET変換";
            this.Activated += new System.EventHandler(this.ConvertForm_Activated);
            this.Deactivate += new System.EventHandler(this.ConvertForm_Deactivate);
            this.Load += new System.EventHandler(this.ConvertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etDisplay;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.ComboBox secondComboBox;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.ComboBox hourComboBox;
        private System.Windows.Forms.ComboBox minuteComboBox;
        private System.Windows.Forms.Label etLabel;
        private System.Windows.Forms.Label moonAgeLabel;
        private System.Windows.Forms.Label moonAgeDisplay;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox moonImageBox;
        private System.Windows.Forms.Label borderBottom;
        private System.Windows.Forms.Label borderLeft;
        private System.Windows.Forms.Label borderRight;
        private System.Windows.Forms.Label borderTop;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.ComboBox moonAgeComboBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.DataGridViewImageColumn moonImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moonAgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localTimeColumn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}