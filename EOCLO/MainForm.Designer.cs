namespace EOCLO
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ltLabel = new System.Windows.Forms.Label();
            this.etLabel = new System.Windows.Forms.Label();
            this.ltDisplay = new System.Windows.Forms.Label();
            this.etDisplay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.convertLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.moonAgeLabel = new System.Windows.Forms.Label();
            this.moonAgeDisplay = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.moonImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.moonAgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleLabel = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.moonImageBox = new System.Windows.Forms.PictureBox();
            this.borderTop = new System.Windows.Forms.Label();
            this.borderBottom = new System.Windows.Forms.Label();
            this.borderLeft = new System.Windows.Forms.Label();
            this.borderRight = new System.Windows.Forms.Label();
            this.timeZoneDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ltLabel
            // 
            this.ltLabel.AutoSize = true;
            this.ltLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ltLabel.Location = new System.Drawing.Point(15, 40);
            this.ltLabel.Name = "ltLabel";
            this.ltLabel.Size = new System.Drawing.Size(53, 12);
            this.ltLabel.TabIndex = 1;
            this.ltLabel.Text = "現在時刻";
            // 
            // etLabel
            // 
            this.etLabel.AutoSize = true;
            this.etLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.etLabel.Location = new System.Drawing.Point(15, 90);
            this.etLabel.Name = "etLabel";
            this.etLabel.Size = new System.Drawing.Size(76, 12);
            this.etLabel.TabIndex = 2;
            this.etLabel.Text = "エオルゼア時間";
            // 
            // ltDisplay
            // 
            this.ltDisplay.AutoSize = true;
            this.ltDisplay.BackColor = System.Drawing.Color.Transparent;
            this.ltDisplay.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.ltDisplay.Location = new System.Drawing.Point(90, 31);
            this.ltDisplay.Name = "ltDisplay";
            this.ltDisplay.Size = new System.Drawing.Size(202, 26);
            this.ltDisplay.TabIndex = 3;
            this.ltDisplay.Text = "0000/00/00  00:00:00\r\n";
            this.ltDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // etDisplay
            // 
            this.etDisplay.AutoSize = true;
            this.etDisplay.BackColor = System.Drawing.Color.Transparent;
            this.etDisplay.Font = new System.Drawing.Font("Open Sans", 14F, System.Drawing.FontStyle.Bold);
            this.etDisplay.Location = new System.Drawing.Point(90, 81);
            this.etDisplay.Name = "etDisplay";
            this.etDisplay.Size = new System.Drawing.Size(61, 26);
            this.etDisplay.TabIndex = 4;
            this.etDisplay.Text = "00:00";
            this.etDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // convertLabel
            // 
            this.convertLabel.AutoSize = true;
            this.convertLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.convertLabel.Location = new System.Drawing.Point(25, 160);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(181, 12);
            this.convertLabel.TabIndex = 5;
            this.convertLabel.Text = "ローカル時間やエオルゼア時間を変換";
            this.convertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.SystemColors.Control;
            this.convertButton.FlatAppearance.BorderSize = 0;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.convertButton.Location = new System.Drawing.Point(220, 155);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "開く";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // moonAgeLabel
            // 
            this.moonAgeLabel.AutoSize = true;
            this.moonAgeLabel.Location = new System.Drawing.Point(160, 90);
            this.moonAgeLabel.Name = "moonAgeLabel";
            this.moonAgeLabel.Size = new System.Drawing.Size(29, 12);
            this.moonAgeLabel.TabIndex = 7;
            this.moonAgeLabel.Text = "月齢";
            // 
            // moonAgeDisplay
            // 
            this.moonAgeDisplay.AutoSize = true;
            this.moonAgeDisplay.BackColor = System.Drawing.Color.Transparent;
            this.moonAgeDisplay.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.moonAgeDisplay.Location = new System.Drawing.Point(210, 92);
            this.moonAgeDisplay.Name = "moonAgeDisplay";
            this.moonAgeDisplay.Size = new System.Drawing.Size(27, 11);
            this.moonAgeDisplay.TabIndex = 8;
            this.moonAgeDisplay.Text = "－－";
            this.moonAgeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // border
            // 
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border.Location = new System.Drawing.Point(25, 145);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(270, 1);
            this.border.TabIndex = 9;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(292, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 28);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "×";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.dataGridView.Location = new System.Drawing.Point(15, 110);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.Size = new System.Drawing.Size(290, 25);
            this.dataGridView.TabIndex = 13;
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
            this.moonAgeColumn.Width = 120;
            // 
            // localTimeColumn
            // 
            this.localTimeColumn.HeaderText = "ローカル時間";
            this.localTimeColumn.Name = "localTimeColumn";
            this.localTimeColumn.ReadOnly = true;
            this.localTimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.localTimeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.localTimeColumn.Width = 137;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(292, 28);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "　　 　EOCLO  - EORZEA CLOCK -";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseMove);
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
            this.iconBox.TabIndex = 14;
            this.iconBox.TabStop = false;
            // 
            // moonImageBox
            // 
            this.moonImageBox.Location = new System.Drawing.Point(192, 85);
            this.moonImageBox.Name = "moonImageBox";
            this.moonImageBox.Size = new System.Drawing.Size(16, 16);
            this.moonImageBox.TabIndex = 12;
            this.moonImageBox.TabStop = false;
            // 
            // borderTop
            // 
            this.borderTop.Location = new System.Drawing.Point(0, 0);
            this.borderTop.Name = "borderTop";
            this.borderTop.Size = new System.Drawing.Size(100, 23);
            this.borderTop.TabIndex = 15;
            // 
            // borderBottom
            // 
            this.borderBottom.Location = new System.Drawing.Point(0, 0);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(100, 23);
            this.borderBottom.TabIndex = 16;
            // 
            // borderLeft
            // 
            this.borderLeft.Location = new System.Drawing.Point(0, 0);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(100, 23);
            this.borderLeft.TabIndex = 17;
            // 
            // borderRight
            // 
            this.borderRight.Location = new System.Drawing.Point(0, 0);
            this.borderRight.Name = "borderRight";
            this.borderRight.Size = new System.Drawing.Size(100, 23);
            this.borderRight.TabIndex = 18;
            // 
            // timeZoneDisplay
            // 
            this.timeZoneDisplay.AutoSize = true;
            this.timeZoneDisplay.BackColor = System.Drawing.Color.Transparent;
            this.timeZoneDisplay.Font = new System.Drawing.Font("Open Sans", 10F);
            this.timeZoneDisplay.Location = new System.Drawing.Point(202, 55);
            this.timeZoneDisplay.Name = "timeZoneDisplay";
            this.timeZoneDisplay.Size = new System.Drawing.Size(88, 19);
            this.timeZoneDisplay.TabIndex = 19;
            this.timeZoneDisplay.Text = "(UTC+00:00)";
            this.timeZoneDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(320, 188);
            this.Controls.Add(this.timeZoneDisplay);
            this.Controls.Add(this.borderRight);
            this.Controls.Add(this.borderLeft);
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.borderTop);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.moonImageBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.border);
            this.Controls.Add(this.moonAgeDisplay);
            this.Controls.Add(this.moonAgeLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.etDisplay);
            this.Controls.Add(this.ltDisplay);
            this.Controls.Add(this.etLabel);
            this.Controls.Add(this.ltLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EOCLO - エオルゼアクロック";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moonImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ltLabel;
        private System.Windows.Forms.Label etLabel;
        private System.Windows.Forms.Label ltDisplay;
        private System.Windows.Forms.Label etDisplay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label moonAgeLabel;
        private System.Windows.Forms.Label moonAgeDisplay;
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox moonImageBox;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label borderTop;
        private System.Windows.Forms.Label borderBottom;
        private System.Windows.Forms.Label borderLeft;
        private System.Windows.Forms.Label borderRight;
        private System.Windows.Forms.Label timeZoneDisplay;
        private System.Windows.Forms.DataGridViewImageColumn moonImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moonAgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localTimeColumn;
    }
}

