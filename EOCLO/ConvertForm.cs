using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EOCLO
{
    /// <summary>
    /// 時間変換ウィンドウのクラス
    /// </summary>
    public partial class ConvertForm : Form
    {
        // ウィンドウの境界線を表現するために配置したLabelの配列
        Label[] borderLines;

        // 1つ前の操作で選択していた項目
        DateTime prevDate;
        int prevHour = 0;
        int prevMinute = 0;
        int prevSecond = 0;

        // 指定日時
        DateTime assignTime;

        // マウスの位置
        int mouseX;
        int mouseY;

        // MainFormで「開く」ボタンを押すたびにインスタンス化されることがないようにする
        private static ConvertForm _instance;
        /// <summary>
        /// ConvertFormを1つだけインスタンス化する
        /// </summary>
        public static ConvertForm Instance
        {
            get
            {
                // インスタンス化されていないとき || 破棄されているとき
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new ConvertForm();
                }
                return _instance;
            }
        }

        // 他のクラスからインスタンス化されることがないようにprivateにする
        private ConvertForm()
        {
            InitializeComponent();

            // DateTimePickerのプロパティの設定
            dateTimePicker.MinDate = Constants.BaseTime.ToLocalTime().Date;
            dateTimePicker.MaxDate = DateTime.Now.AddYears(1);
            dateTimePicker.BackColor = Color.FromArgb(220, 220, 220);
            dateTimePicker.ForeColor = Color.FromArgb(40, 40, 40);

            // 時間の設定
            // 今日が基準日のとき
            if (DateTime.Now.Date == Constants.BaseTime.ToLocalTime().Date)
            {
                SetComboBoxItem(hourComboBox, Constants.BaseTime.ToLocalTime().Hour, 23);
                SetComboBoxItem(minuteComboBox, Constants.BaseTime.ToLocalTime().Minute, 59);
            }
            else
            {
                SetComboBoxItem(hourComboBox, 0, 23);
                SetComboBoxItem(minuteComboBox, 0, 59);
            }
            // 秒の設定
            for (int i = 0; i <= 59; i++)
            {
                secondComboBox.Items.Add(i);
            }
            // コンボボックスの初期値を現在時刻に設定
            hourComboBox.SelectedIndex = secondComboBox.Items.IndexOf(DateTime.Now.Hour);
            minuteComboBox.SelectedIndex = secondComboBox.Items.IndexOf(DateTime.Now.Minute);
            secondComboBox.SelectedIndex = secondComboBox.Items.IndexOf(DateTime.Now.Second);
            prevDate = dateTimePicker.Value.Date;
            prevHour = hourComboBox.SelectedIndex;
            prevMinute = minuteComboBox.SelectedIndex;
            prevSecond = secondComboBox.SelectedIndex;

            switchComboBox.Items.Add("日時を指定してエオルゼア時間とその前後の月齢を表示");
            switchComboBox.Items.Add("指定日以降に指定した月齢になる日時を表示");
            switchComboBox.SelectedIndex = 0;

            moonAgeComboBox.ItemHeight = Constants.moonImages[0].Height;
            for (int i = 0; i < Constants.moonAgeNames.Length; i++)
            {
                moonAgeComboBox.Items.Add(Constants.moonAgeNames[i]);
            }
            moonAgeComboBox.SelectedIndex = 0;

            // labelは数が多いので配列にまとめる
            Label[] labels = { titleLabel, etLabel, etDisplay, moonAgeLabel, moonAgeDisplay, hourLabel, minuteLabel, secondLabel };
            // 各コントロールのプロパティの設定
            Utility.SetFormsStyle(this, labels, closeButton, convertButton, dataGridView);
            outputButton.BackColor = Color.FromArgb(100, 100, 100);
            outputButton.ForeColor = Color.FromArgb(240, 240, 240);
            outputButton.Enabled = false;
            // DataGridViewにセルを追加しておく
            dataGridView.Rows.Add(9);
            // 境界線を描くLabelを配列に入れる
            borderLines = new Label[] { borderTop, borderBottom, borderLeft, borderRight };
            Utility.SetBorderLines(this, borderLines);

            // タイマースタート
            timer.Start();
        }

        private void ConvertForm_Load(object sender, EventArgs e)
        {
            // 初期設定時にDataGridViewのセルの選択解除・コンストラクター内では動作しなかった
            dataGridView.ClearSelection();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // タイマーを使って境界線の描画を更新
            Utility.SwitchBorderLine(this, borderLines);
        }

        private void switchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // switchComboBoxの選択項目によって操作する項目を変える
            if (switchComboBox.SelectedIndex == 0)
            {
                hourComboBox.Enabled = true;
                minuteComboBox.Enabled = true;
                secondComboBox.Enabled = true;
                moonAgeComboBox.Enabled = false;
                moonAgeComboBox.ForeColor = Color.FromArgb(120, 120, 120);
                moonAgeComboBox.BackColor = Color.FromArgb(235, 235, 235);
            }
            else if (switchComboBox.SelectedIndex == 1)
            {
                hourComboBox.Enabled = false;
                minuteComboBox.Enabled = false;
                secondComboBox.Enabled = false;
                moonAgeComboBox.Enabled = true;
                moonAgeComboBox.ForeColor = SystemColors.WindowText;
                moonAgeComboBox.BackColor = SystemColors.Window;
            }
        }

        private void moonAgeComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // moonAgeComboBoxに画像を追加
            e.DrawBackground();
            e.Graphics.DrawImage(Constants.moonImages[e.Index], e.Bounds.X, e.Bounds.Y,
                Constants.moonImages[e.Index].Size.Width, Constants.moonImages[e.Index].Size.Height);
            e.Graphics.DrawString(moonAgeComboBox.Items[e.Index].ToString(), e.Font,
                new SolidBrush(e.ForeColor), Constants.moonImages[e.Index].Size.Width + e.Bounds.X, e.Bounds.Y+2);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // 今選択しているのが基準日のとき && 前に選択していたのが基準日ではないとき
            if (dateTimePicker.Value.Date == dateTimePicker.MinDate && prevDate != dateTimePicker.MinDate)
            {
                SetComboBoxItem(hourComboBox, Constants.BaseTime.ToLocalTime().Hour, 23);
                SetComboBoxItem(minuteComboBox, Constants.BaseTime.ToLocalTime().Minute, 59);
            }
            // 今選択しているのが基準日以外のとき && 前に選択していたのが基準日のとき
            else if(dateTimePicker.Value.Date != dateTimePicker.MinDate && prevDate == dateTimePicker.MinDate)
            {
                SetComboBoxItem(hourComboBox, 0, 23);
                SetComboBoxItem(minuteComboBox, 0, 59);
            }
            // 選択している日付を記憶
            prevDate = dateTimePicker.Value.Date;
        }

        private void hourComboBox_Leave(object sender, EventArgs e)
        {
            // 選択している時を記憶
            prevHour = TestComboBoxText(hourComboBox, prevHour);
        }

        private void minuteComboBox_Leave(object sender, EventArgs e)
        {
            // 選択している分を記憶
            prevMinute = TestComboBoxText(minuteComboBox, prevMinute);
        }

        private void secondComboBox_Leave(object sender, EventArgs e)
        {
            // 選択している秒を記憶
            prevSecond = TestComboBoxText(secondComboBox, prevSecond);
        }

        /// <summary>
        /// 入力された文字を数字に変換、できなければ1つ前に選択していた数字を代入
        /// </summary>
        /// <param name="comboBoxKind"> コンボボックスの種類 </param>
        /// <param name="prevSelected"> 1つ前に選択していた項目 </param>
        /// <returns> 選択している要素番号 </returns>
        private int TestComboBoxText(ComboBox comboBoxKind, int prevSelected)
        {
            int result = 0;
            try
            {
                result = int.Parse(comboBoxKind.Text);
            }
            catch
            {
                result = prevSelected;
            }

            return comboBoxKind.SelectedIndex = comboBoxKind.Items.IndexOf(result);
        }

        /// <summary>
        /// コンボボックスの項目の設定
        /// </summary>
        /// <param name="comboBoxKind"> コンボボックスの種類 </param>
        /// <param name="comboBoxMin"> コンボボックスの最小値 </param>
        /// <param name="comboBoxMax"> コンボボックスの最大値 </param>
        private void SetComboBoxItem(ComboBox comboBoxKind, int comboBoxMin, int comboBoxMax)
        {
            // コンボボックスのどの項目を選択しているか
            int storedItem = 0;

            // 選択項目を記憶
            if (comboBoxKind.SelectedItem != null)
            {
                storedItem = (int)comboBoxKind.SelectedItem;
            }
            // 初期設定時はnullになるのでこちらを実行
            else
            {
                storedItem = 0;
            }

            // ここでComboBox.SelectedItemがnullになる
            comboBoxKind.Items.Clear();

            // 項目の設定
            for (int i = comboBoxMin; i <= comboBoxMax; i++)
            {
                comboBoxKind.Items.Add(i);
            }

            SetComboBoxIndex(comboBoxKind, comboBoxMin, comboBoxMax, storedItem);
        }

        /// <summary>
        /// 記憶した項目からコンボボックスの要素番号を設定
        /// </summary>
        /// <param name="comboBoxKind"> コンボボックスの種類 </param>
        /// <param name="comboBoxMin"> コンボボックスの最小値 </param>
        /// <param name="comboBoxMax"> コンボボックスの最大値 </param>
        /// <param name="storedItem"> 1つ前に選択していた項目 </param>
        private void SetComboBoxIndex(ComboBox comboBoxKind, int comboBoxMin, int comboBoxMax, int storedItem)
        {
            // 選択した項目が最小値以下のとき最小値を設定
            if (storedItem <= comboBoxMin)
            {
                comboBoxKind.SelectedIndex = 0;
            }
            // 最大値以上のとき最大値を設定
            else if (storedItem >= comboBoxMax)
            {
                comboBoxKind.SelectedIndex = comboBoxKind.Items.Count - 1;
            }
            // それ以外ならそのまま
            else
            {
                comboBoxKind.SelectedIndex = comboBoxKind.Items.IndexOf(storedItem);
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // 日時を指定してエオルゼア時間とエオルゼアの月齢を表示
            if (switchComboBox.SelectedIndex == 0)
            {
                try
                {
                    // 日時を指定
                    assignTime = new DateTime(
                        dateTimePicker.Value.Year,
                        dateTimePicker.Value.Month,
                        dateTimePicker.Value.Day,
                        (int)hourComboBox.SelectedItem,
                        (int)minuteComboBox.SelectedItem,
                        (int)secondComboBox.SelectedItem);

                    // 指定した日時をUTCに変換後エオルゼア時間を表示
                    TimeSpan differenceTime = assignTime.ToUniversalTime() - Constants.BaseTime;
                    etDisplay.Text = Utility.GetEorzeaHour(Utility.GetEorzeaTime(differenceTime)).ToString("00")
                        + ":" + Utility.GetEorzeaMinute(Utility.GetEorzeaTime(differenceTime)).ToString("00");

                    // エオルゼアの月齢を表示
                    int moonIndex = Utility.GetMoonAgeIndex(differenceTime);
                    moonAgeDisplay.Text = Constants.moonAgeNames[moonIndex];
                    moonImageBox.Image = Constants.moonImages[moonIndex];
                    dataGridView.Rows.Clear();
                    Utility.SetMoonAgeColumns(dataGridView, moonImageColumn, moonIndex);
                    Utility.SetMoonAgeTime(dataGridView, Utility.GetMoonTime(differenceTime));
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("正しい日時を設定してください。", "エラー");
                }
            }
            // 指定日以降に指定した月齢になる日時を表示
            else
            {
                TimeSpan differenceTime = prevDate.ToUniversalTime() - Constants.BaseTime;
                int moonIndex = Utility.GetMoonAgeIndex(differenceTime);
                int differenceMoon = 0;
                // 上で求めた月齢と指定した月齢の差
                if (moonAgeComboBox.SelectedIndex >= moonIndex)
                {
                    differenceMoon = moonAgeComboBox.SelectedIndex - moonIndex;
                }
                else
                {
                    differenceMoon = Constants.moonAgeNames.Length - (moonIndex + 1) + (moonAgeComboBox.SelectedIndex + 1);
                }
                // 基準日から指定日までの月齢周期は何回か・月齢変化のタイミングを半周分早める
                int moonNumber = (int)((differenceTime.TotalMinutes + (Constants.SwitchMoon / 2)) / Constants.CycleMoon);
                // 指定日に指定した月齢になる時刻・早めた月齢変化のタイミングを戻す
                DateTime moonTime = Constants.BaseTime.AddMinutes((moonNumber * Constants.CycleMoon)
                    - (Constants.SwitchMoon / 2) + (Constants.SwitchMoon * (moonIndex + differenceMoon)));

                dataGridView.Rows.Clear();
                dataGridView.Rows.Add(9);

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].Cells[0].Value = Constants.moonImages[moonAgeComboBox.SelectedIndex];
                    dataGridView.Rows[i].Cells[1].Value = Constants.moonAgeNames[moonAgeComboBox.SelectedIndex];
                    dataGridView.Rows[i].Cells[2].Value = moonTime.AddMinutes(Constants.CycleMoon * i).ToLocalTime().ToString("yyyy/MM/dd HH:mm")
                        + " ～ " + moonTime.AddMinutes((Constants.CycleMoon * i) + (Constants.SwitchMoon - 1)).ToLocalTime().ToString("yyyy/MM/dd HH:mm");
                }
                dataGridView.ClearSelection();

                etDisplay.Text = "- - : - -";
                moonAgeDisplay.Text = "";
                moonImageBox.Image = null;
            }

            outputButton.Enabled = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // マウスの現在位置を取得
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // ウィンドウを移動
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            // CSVに出力
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "新規ファイル.csv";
            string folderPath = Directory.GetCurrentDirectory();
            sfd.InitialDirectory = folderPath;
            sfd.Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.Title = "名前を付けて保存";
            sfd.RestoreDirectory = true;
            // 既に存在するファイル名を指定したとき警告する・デフォルトでtrue
            //sfd.OverwritePrompt = true;
            // 存在しないパスが指定されたとき警告を表示する・デフォルトでtrue
            //sfd.CheckPathExists = true;

            // ダイアログを表示・OKボタンをクリックしたとき
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    using (StreamWriter sw = new StreamWriter(stream, Encoding.UTF8))
                    {
                        if (moonAgeDisplay.Text != "")
                        {
                            sw.WriteLine("指定日時," + assignTime);
                            sw.WriteLine(etLabel.Text + "," + etDisplay.Text);
                            sw.WriteLine(moonAgeLabel.Text + "," + moonAgeDisplay.Text);
                            sw.WriteLine("\n指定日時前後の月齢と日時");
                        }
                        else
                        {
                            sw.WriteLine("指定日以降の月齢と日時");
                        }
                        sw.Write(moonAgeColumn.HeaderText + "," + localTimeColumn.HeaderText);
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            sw.WriteLine();
                            for (int j = 1; j < dataGridView.Columns.Count; j++)
                            {
                                if (j != 1)
                                {
                                    sw.Write(",");
                                }
                                sw.Write(dataGridView[j, i].Value);
                            }
                            if (moonAgeDisplay.Text != "" && i == 4)
                            {
                                sw.Write(",←");
                            }
                        }
                    }
                }
            }
        }
    }
}
