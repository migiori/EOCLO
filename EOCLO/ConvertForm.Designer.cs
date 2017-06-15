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
            this.components = new System.ComponentModel.Container();
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.border = new System.Windows.Forms.Label();
            this.moonImageBox = new System.Windows.Forms.PictureBox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.moonAgeComboBox = new System.Windows.Forms.ComboBox();
            this.switchComboBox = new System.Windows.Forms.ComboBox();
            this.outputButton = new System.Windows.Forms.Button();
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
            this.etDisplay.Location = new System.Drawing.Point(95, 136);
            this.etDisplay.Name = "etDisplay";
            this.etDisplay.Size = new System.Drawing.Size(61, 26);
            this.etDisplay.TabIndex = 14;
            this.etDisplay.Text = "- - : - -";
            // 
            // convertButton
            // 
            this.convertButton.FlatAppearance.BorderSize = 0;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Location = new System.Drawing.Point(225, 95);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(60, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "変換";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // secondComboBox
            // 
            this.secondComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondComboBox.Location = new System.Drawing.Point(150, 95);
            this.secondComboBox.MaxLength = 2;
            this.secondComboBox.Name = "secondComboBox";
            this.secondComboBox.Size = new System.Drawing.Size(36, 20);
            this.secondComboBox.TabIndex = 4;
            this.secondComboBox.Leave += new System.EventHandler(this.secondComboBox_Leave);
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(190, 100);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(17, 12);
            this.secondLabel.TabIndex = 13;
            this.secondLabel.Text = "秒";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(125, 100);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(17, 12);
            this.minuteLabel.TabIndex = 12;
            this.minuteLabel.Text = "分";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(60, 100);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(17, 12);
            this.hourLabel.TabIndex = 11;
            this.hourLabel.Text = "時";
            // 
            // hourComboBox
            // 
            this.hourComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hourComboBox.FormattingEnabled = true;
            this.hourComboBox.Location = new System.Drawing.Point(20, 95);
            this.hourComboBox.MaxLength = 2;
            this.hourComboBox.Name = "hourComboBox";
            this.hourComboBox.Size = new System.Drawing.Size(36, 20);
            this.hourComboBox.TabIndex = 2;
            this.hourComboBox.Leave += new System.EventHandler(this.hourComboBox_Leave);
            // 
            // minuteComboBox
            // 
            this.minuteComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minuteComboBox.FormattingEnabled = true;
            this.minuteComboBox.Location = new System.Drawing.Point(85, 95);
            this.minuteComboBox.MaxLength = 2;
            this.minuteComboBox.Name = "minuteComboBox";
            this.minuteComboBox.Size = new System.Drawing.Size(36, 20);
            this.minuteComboBox.TabIndex = 3;
            this.minuteComboBox.Leave += new System.EventHandler(this.minuteComboBox_Leave);
            // 
            // etLabel
            // 
            this.etLabel.AutoSize = true;
            this.etLabel.Location = new System.Drawing.Point(20, 145);
            this.etLabel.Name = "etLabel";
            this.etLabel.Size = new System.Drawing.Size(76, 12);
            this.etLabel.TabIndex = 16;
            this.etLabel.Text = "エオルゼア時間";
            // 
            // moonAgeLabel
            // 
            this.moonAgeLabel.AutoSize = true;
            this.moonAgeLabel.Location = new System.Drawing.Point(165, 145);
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
            this.moonAgeDisplay.Location = new System.Drawing.Point(215, 147);
            this.moonAgeDisplay.Name = "moonAgeDisplay";
            this.moonAgeDisplay.Size = new System.Drawing.Size(8, 11);
            this.moonAgeDisplay.TabIndex = 18;
            this.moonAgeDisplay.Text = " ";
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
            this.dataGridView.Location = new System.Drawing.Point(15, 170);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.Size = new System.Drawing.Size(345, 214);
            this.dataGridView.TabIndex = 19;
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
            this.moonAgeColumn.Width = 95;
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
            this.closeButton.Location = new System.Drawing.Point(347, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 28);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "×";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(347, 28);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "　　 　EOCLO - エオルゼアクロック";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleLabel_MouseMove);
            // 
            // borderBottom
            // 
            this.borderBottom.BackColor = System.Drawing.Color.Black;
            this.borderBottom.Location = new System.Drawing.Point(0, 0);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(100, 23);
            this.borderBottom.TabIndex = 25;
            // 
            // borderLeft
            // 
            this.borderLeft.BackColor = System.Drawing.Color.Black;
            this.borderLeft.Location = new System.Drawing.Point(0, 0);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(100, 23);
            this.borderLeft.TabIndex = 26;
            // 
            // borderRight
            // 
            this.borderRight.BackColor = System.Drawing.Color.Black;
            this.borderRight.Location = new System.Drawing.Point(0, 0);
            this.borderRight.Name = "borderRight";
            this.borderRight.Size = new System.Drawing.Size(100, 23);
            this.borderRight.TabIndex = 27;
            // 
            // borderTop
            // 
            this.borderTop.BackColor = System.Drawing.Color.Black;
            this.borderTop.Location = new System.Drawing.Point(0, 0);
            this.borderTop.Name = "borderTop";
            this.borderTop.Size = new System.Drawing.Size(100, 23);
            this.borderTop.TabIndex = 28;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(20, 66);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(185, 19);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // border
            // 
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border.Location = new System.Drawing.Point(25, 130);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(325, 1);
            this.border.TabIndex = 30;
            // 
            // moonImageBox
            // 
            this.moonImageBox.BackColor = System.Drawing.Color.Transparent;
            this.moonImageBox.Location = new System.Drawing.Point(197, 140);
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
            this.moonAgeComboBox.Location = new System.Drawing.Point(225, 65);
            this.moonAgeComboBox.Name = "moonAgeComboBox";
            this.moonAgeComboBox.Size = new System.Drawing.Size(130, 20);
            this.moonAgeComboBox.TabIndex = 5;
            this.moonAgeComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.moonAgeComboBox_DrawItem);
            // 
            // switchComboBox
            // 
            this.switchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.switchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchComboBox.Location = new System.Drawing.Point(20, 36);
            this.switchComboBox.Name = "switchComboBox";
            this.switchComboBox.Size = new System.Drawing.Size(300, 20);
            this.switchComboBox.TabIndex = 0;
            this.switchComboBox.SelectedIndexChanged += new System.EventHandler(this.switchComboBox_SelectedIndexChanged);
            // 
            // outputButton
            // 
            this.outputButton.FlatAppearance.BorderSize = 0;
            this.outputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputButton.Location = new System.Drawing.Point(295, 95);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(60, 23);
            this.outputButton.TabIndex = 33;
            this.outputButton.Text = "保存";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 400);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.switchComboBox);
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
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.ComboBox moonAgeComboBox;
        private System.Windows.Forms.ComboBox switchComboBox;
        private System.Windows.Forms.DataGridViewImageColumn moonImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moonAgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localTimeColumn;
        private System.Windows.Forms.Button outputButton;
    }
}