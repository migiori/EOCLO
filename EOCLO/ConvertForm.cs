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
        // ウィンドウの境界線を表現するための配列
        Label[] borderLines;

        // moonAgeComboBox.Enabled == falseのときのmoonAgeComboBoxの色
        Color moonAgeBackColor = Color.FromArgb(235, 235, 235);
        Color moonAgeForeColor = Color.FromArgb(120, 120, 120);

        // 1つ前の操作で選択していた項目の要素番号
        DateTime prevDate;
        int prevHourIndex = 0;
        int prevMinuteIndex = 0;
        int prevSecondIndex = 0;

        // 1つ前の操作でどのRadioButtonを選択していたか
        bool checkedRadio1 = false;
        bool checkedRadio23 = false;

        // 指定日時
        DateTime assignTime;

        // radioButton3を選択したときのdataGridViewの行数
        int radio3RowCount = 0;

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

        // 他のクラスからインスタンス化されないようにprivateにする
        private ConvertForm()
        {
            InitializeComponent();

            // dateTimePickerのプロパティの設定
            dateTimePicker.MinDate = Constants.BaseTime.ToLocalTime().Date;
            dateTimePicker.MaxDate = DateTime.Now.AddYears(1);
            // 指定しても色が変わらない
            //dateTimePicker.BackColor = Color.FromArgb(220, 220, 220);
            //dateTimePicker.ForeColor = Color.FromArgb(40, 40, 40);

            // 時間の設定
            // 今日が基準日かどうか
            if (DateTime.Now.Date == Constants.BaseTime.ToLocalTime().Date)
            {
                SetBaseTime();
            }
            else
            {
                SetTime();
            }
            for (int i = 0; i <= 59; i++)
            {
                secondComboBox.Items.Add(i);
            }
            // ComboBoxの初期値を現在時刻に設定
            hourComboBox.SelectedIndex = secondComboBox.Items.IndexOf(DateTime.Now.Hour);
            minuteComboBox.SelectedIndex = secondComboBox.Items.IndexOf(DateTime.Now.Minute);
            secondComboBox.SelectedIndex = secondComboBox.Items.IndexOf(DateTime.Now.Second);
            prevDate = dateTimePicker.Value.Date;
            prevHourIndex = hourComboBox.SelectedIndex;
            prevMinuteIndex = minuteComboBox.SelectedIndex;
            prevSecondIndex = secondComboBox.SelectedIndex;

            // moonAgeComboBoxの設定
            moonAgeComboBox.ItemHeight = Constants.MoonImages[0].Height;
            for (int i = 0; i < Constants.MoonAgeNames.Length; i++)
            {
                moonAgeComboBox.Items.Add(Constants.MoonAgeNames[i]);
            }
            moonAgeComboBox.SelectedIndex = 0;

            // 各コントロールのプロパティの設定
            // Labelは数が多いので配列にまとめる
            Label[] labels = { titleLabel, etLabel, etDisplay, moonAgeLabel, moonAgeDisplay, hourLabel, minuteLabel, secondLabel };
            Utility.SetControlProperty(this, labels, closeButton, convertButton, dataGridView);
            // dataGridViewの行数によってFormの高さを変える
            this.Height = dataGridView.Bottom + 15;
            checkedRadio1 = true;
            radioButton1.Checked = true;
            radioButton1.ForeColor = Constants.TextColor;
            radioButton2.ForeColor = Constants.TextColor;
            radioButton3.ForeColor = Constants.TextColor;
            moonAgeComboBox.Enabled = false;
            moonAgeComboBox.BackColor = moonAgeBackColor;
            moonAgeComboBox.ForeColor = moonAgeForeColor;
            outputButton.BackColor = Constants.ButtonBackColor;
            outputButton.ForeColor = Constants.ButtonForeColor;
            outputButton.Enabled = false;
            // dataGridViewにセルを追加しておく
            dataGridView.Rows.Add(Constants.RowCount);
            // 境界線を描くLabelを配列に入れる
            borderLines = new Label[] { borderTop, borderBottom, borderLeft, borderRight };
            Utility.SetBorderLines(this, borderLines);
        }

        private void ConvertForm_Load(object sender, EventArgs e)
        {
            // 初期設定時にdataGridViewのセルの選択解除・コンストラクター内では動作しない
            dataGridView.ClearSelection();
        }

        private void ConvertForm_Activated(object sender, EventArgs e)
        {
            Utility.ActiveBorderLine(this, borderLines);
        }

        private void ConvertForm_Deactivate(object sender, EventArgs e)
        {
            Utility.DeactiveBorderLine(this, borderLines);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                hourComboBox.Enabled = true;
                minuteComboBox.Enabled = true;
                secondComboBox.Enabled = true;
                moonAgeComboBox.Enabled = false;
                moonAgeComboBox.BackColor = moonAgeBackColor;
                moonAgeComboBox.ForeColor = moonAgeForeColor;

                // 基準日を選択しているとき && 1つ前に選択していたのがradioButton2かradioButton3のとき
                if (dateTimePicker.Value.Date == Constants.BaseTime.ToLocalTime().Date && checkedRadio23 == true)
                {
                    SetBaseTime();
                }
                checkedRadio1 = true;
                checkedRadio23 = false;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                hourComboBox.Enabled = false;
                minuteComboBox.Enabled = false;
                secondComboBox.Enabled = false;
                moonAgeComboBox.Enabled = true;
                moonAgeComboBox.ForeColor = SystemColors.WindowText;
                moonAgeComboBox.BackColor = SystemColors.Window;
            }

            // 基準日を選択しているとき && 1つ前に選択していたのがradioButton1のとき
            if (dateTimePicker.Value.Date == Constants.BaseTime.ToLocalTime().Date && checkedRadio1 == true)
            {
                SetTime();
            }
            checkedRadio1 = false;
            checkedRadio23 = true;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                hourComboBox.Enabled = true;
                minuteComboBox.Enabled = false;
                secondComboBox.Enabled = false;
                moonAgeComboBox.Enabled = false;
                moonAgeComboBox.BackColor = moonAgeBackColor;
                moonAgeComboBox.ForeColor = moonAgeForeColor;

                // 基準日を選択しているとき && 1つ前に選択していたのがradioButton1のとき
                if (dateTimePicker.Value.Date == Constants.BaseTime.ToLocalTime().Date && checkedRadio1 == true)
                {
                    SetTime();
                }
                checkedRadio1 = false;
                checkedRadio23 = true;
            }
        }

        private void HourComboBox_Leave(object sender, EventArgs e)
        {
            prevHourIndex = TestComboBoxText(hourComboBox, prevHourIndex);
        }

        private void MinuteComboBox_Leave(object sender, EventArgs e)
        {
            prevMinuteIndex = TestComboBoxText(minuteComboBox, prevMinuteIndex);
        }

        private void SecondComboBox_Leave(object sender, EventArgs e)
        {
            prevSecondIndex = TestComboBoxText(secondComboBox, prevSecondIndex);
        }

        /// <summary>
        /// 入力された文字を数字に変換、できなければ1つ前に選択していた数字を代入
        /// </summary>
        /// <param name="comboBoxKind"> ComboBoxの種類 </param>
        /// <param name="prevTimeIndex"> 1つ前に選択していた項目 </param>
        /// <returns> 選択する項目とその要素番号 </returns>
        private int TestComboBoxText(ComboBox comboBoxKind, int prevTimeIndex)
        {
            int result = 0;
            try
            {
                result = int.Parse(comboBoxKind.Text);
            }
            catch
            {
                result = prevTimeIndex;
            }
            return comboBoxKind.SelectedIndex = comboBoxKind.Items.IndexOf(result);
        }

        private void MoonAgeComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // moonAgeComboBoxに画像を追加
            e.DrawBackground();
            Image moonImage = Constants.MoonImages[Utility.GetMoonImagesIndex(e.Index)];
            e.Graphics.DrawImage(moonImage, e.Bounds.X, e.Bounds.Y, moonImage.Size.Width, moonImage.Size.Height);
            e.Graphics.DrawString(moonAgeComboBox.Items[e.Index].ToString(), e.Font,
                new SolidBrush(e.ForeColor), moonImage.Size.Width + e.Bounds.X, e.Bounds.Y + 2);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                // 今選択しているのが基準日のとき && 前に選択していたのが基準日ではないとき
                if (dateTimePicker.Value.Date == dateTimePicker.MinDate && prevDate != dateTimePicker.MinDate)
                {
                    SetBaseTime();
                }
                // 今選択しているのが基準日以外のとき && 前に選択していたのが基準日のとき
                else if (dateTimePicker.Value.Date != dateTimePicker.MinDate && prevDate == dateTimePicker.MinDate)
                {
                    SetTime();
                }
            }
            // 選択している日付を記憶
            prevDate = dateTimePicker.Value.Date;
        }

        // 処理が少し重い
        private void SetBaseTime()
        {
            SetComboBoxItem(hourComboBox, Constants.BaseTime.ToLocalTime().Hour, 23);
            SetComboBoxItem(minuteComboBox, Constants.BaseTime.ToLocalTime().Minute, 59);
        }

        // 同じく少し重い
        private void SetTime()
        {
            SetComboBoxItem(hourComboBox, 0, 23);
            SetComboBoxItem(minuteComboBox, 0, 59);
        }

        /// <summary>
        /// ComboBox内の項目の設定
        /// </summary>
        /// <param name="comboBoxKind"> ComboBoxの種類 </param>
        /// <param name="comboBoxMin"> ComboBox内の項目の最小値 </param>
        /// <param name="comboBoxMax"> ComboBox内の項目の最大値 </param>
        private void SetComboBoxItem(ComboBox comboBoxKind, int comboBoxMin, int comboBoxMax)
        {
            // ComboBox内のどの項目を選択しているか
            int storedItem = 0;
            if (comboBoxKind.SelectedItem != null)
            {
                storedItem = (int)comboBoxKind.SelectedItem;
            }
            // 初期設定時はnullになるのでこちらを実行
            else
            {
                storedItem = 0;
            }

            // ここでComboBox.SelectedItem == nullになる
            comboBoxKind.Items.Clear();

            // 項目の設定
            for (int i = comboBoxMin; i <= comboBoxMax; i++)
            {
                comboBoxKind.Items.Add(i);
            }

            // 記憶した項目が最小値以下のとき最小値を設定
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

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // dataGridViewのlocalTimeColumnの幅
            int longWidth = 217;
            int shortWidth = 200;

            // 指定した日時のエオルゼア時間とエオルゼアの月齢を表示
            if (radioButton1.Checked == true)
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

                    // エオルゼア時間を表示
                    TimeSpan differenceTime = assignTime.ToUniversalTime() - Constants.BaseTime;
                    int eorzeaTime = Utility.GetEorzeaTime(differenceTime);
                    etDisplay.Text = Utility.GetEorzeaHour(eorzeaTime).ToString("00") + ":" + Utility.GetEorzeaMinute(eorzeaTime).ToString("00");

                    // エオルゼアの月齢を表示
                    int moonAgeIndex = Utility.GetMoonAgeIndex(differenceTime);
                    moonAgeDisplay.Text = Constants.MoonAgeNames[moonAgeIndex];
                    moonImageBox.Image = Constants.MoonImages[Utility.GetMoonImagesIndex(moonAgeIndex)];

                    // dataGridViewに表示
                    dataGridView.Rows.Clear();
                    Utility.SetMoonAgeAndTime(dataGridView, moonAgeIndex, Utility.GetMoonAgeChangeTime(differenceTime));

                    dataGridView.Enabled = false;
                    localTimeColumn.Width = longWidth;
                    // Constants.RowCountがradio3RowCountより大きい値のとき
                    if (dataGridView.Rows.Count > radio3RowCount)
                    {
                        // dataGridViewの高さが足りず表示されない行が出てしまうので調整
                        dataGridView.Height = 25 + 21 * dataGridView.Rows.Count;
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("正しい日時を設定してください。", "エラー");
                }
            }
            // 指定日以降にエオルゼアで指定した月齢になる日時を表示
            else if (radioButton2.Checked == true)
            {
                assignTime = dateTimePicker.Value.Date;
                TimeSpan differenceTime = assignTime.ToUniversalTime() - Constants.BaseTime;
                int moonAgeIndex = Utility.GetMoonAgeIndex(differenceTime);
                // 上で求めた月齢と指定した月齢の差
                int differenceMoonAge = moonAgeComboBox.SelectedIndex - moonAgeIndex;
                if (moonAgeComboBox.SelectedIndex < moonAgeIndex)
                {
                    differenceMoonAge += Constants.MoonAgeNames.Length;
                }
                // 基準日時から指定日までの月齢周期は何回か・月齢が変化する日時を月の出の時間に合わせるために半日分早める
                int moonCycleCount = (int)((differenceTime.TotalMinutes + (Constants.EorzeaDay / 2)) / Constants.MoonCycle);
                // 指定日に指定した月齢になる時刻・上で早めた時間を戻す
                DateTime moonChangeTime = Constants.BaseTime.AddMinutes((moonCycleCount * Constants.MoonCycle)
                    - (Constants.EorzeaDay / 2) + (Constants.EorzeaDay * (moonAgeIndex + differenceMoonAge)));

                // dataGridViewに表示
                dataGridView.Rows.Clear();
                dataGridView.Rows.Add(Constants.RowCount);
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].Cells[0].Value = Constants.MoonImages[Utility.GetMoonImagesIndex(moonAgeComboBox.SelectedIndex)];
                    dataGridView.Rows[i].Cells[1].Value = Constants.MoonAgeNames[moonAgeComboBox.SelectedIndex];
                    dataGridView.Rows[i].Cells[2].Value = moonChangeTime.AddMinutes(Constants.MoonCycle * i).ToLocalTime().ToString("yyyy/MM/dd HH:mm")
                        + " ～ " + moonChangeTime.AddMinutes((Constants.MoonCycle * i) + (Constants.EorzeaDay - 1)).ToLocalTime().ToString("yyyy/MM/dd HH:mm");
                }
                dataGridView.ClearSelection();

                etDisplay.Text = "- - : - -";
                moonAgeDisplay.Text = "－－";
                moonImageBox.Image = null;
                dataGridView.Enabled = false;
                localTimeColumn.Width = longWidth;
                // Constants.RowCountがradio3RowCountより大きい値のとき
                if (dataGridView.Rows.Count > radio3RowCount)
                {
                    // dataGridViewの高さが足りず表示されない行が出てしまうので調整
                    dataGridView.Height = 25 + 21 * dataGridView.Rows.Count;
                }
            }
            // 指定日に指定したエオルゼア時間になるローカル時間を表示
            else if (radioButton3.Checked == true)
            {
                assignTime = dateTimePicker.Value.Date;
                TimeSpan differenceTime = assignTime.ToUniversalTime() - Constants.BaseTime;
                // 指定日までにエオルゼア時間で何日経ったか
                int eorzeaDayCount = (int)(differenceTime.TotalMinutes / Constants.EorzeaDay);
                int eorzeaTime = Utility.GetEorzeaTime(differenceTime);
                int eorzeaHour = Utility.GetEorzeaHour(eorzeaTime);
                // 指定日の0時のエオルゼア時間が指定時間より後かどうか
                if ((int)hourComboBox.SelectedItem < eorzeaHour
                    || ((int)hourComboBox.SelectedItem == eorzeaHour && Utility.GetEorzeaMinute(eorzeaTime) != 0))
                {
                    eorzeaDayCount += 1;
                }
                DateTime dateTime = Constants.BaseTime.AddSeconds(Constants.EorzeaDay * 60
                    * (eorzeaDayCount + (double)((int)hourComboBox.SelectedItem) / 24));

                dataGridView.Rows.Clear();
                // 地球時間の1日はエオルゼア時間で20～21日・地球時間の1日(1440分)をエオルゼア時間の1日(70分)で割ると40分余る
                if ((dateTime.ToLocalTime() - dateTime.ToLocalTime().Date).TotalMinutes >= 40)
                {
                    radio3RowCount = 20;
                }
                else
                {
                    radio3RowCount = 21;
                }
                dataGridView.Rows.Add(radio3RowCount);

                // dataGridViewに表示
                int count = 0;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    DateTime dTime = dateTime.AddMinutes(Constants.EorzeaDay * i);
                    TimeSpan tSpan = dTime - Constants.BaseTime;
                    // 基準日時より前の行数を数える
                    if (tSpan.TotalSeconds < 0)
                    {
                        count += 1;
                    }
                    int moonAgeIndex = Utility.GetMoonAgeIndex(tSpan);
                    dataGridView.Rows[i].Cells[0].Value = Constants.MoonImages[Utility.GetMoonImagesIndex(moonAgeIndex)];
                    dataGridView.Rows[i].Cells[1].Value = Constants.MoonAgeNames[moonAgeIndex];
                    dataGridView.Rows[i].Cells[2].Value = dTime.ToLocalTime().ToString("yyyy/MM/dd HH:mm:ss");
                }
                // 月齢が正しく表示されないので基準日時より前の行を削除
                for (int i = 0; i < count; i++)
                {
                    dataGridView.Rows.RemoveAt(0);
                }
                dataGridView.ClearSelection();

                // 時間を2桁で表示
                etDisplay.Text = hourComboBox.SelectedItem.ToString().PadLeft(2, '0') + ":00";
                moonAgeDisplay.Text = "－－";
                moonImageBox.Image = null;
                if (dataGridView.Rows.Count > Constants.RowCount)
                {
                    dataGridView.Enabled = true;
                    localTimeColumn.Width = shortWidth;
                }
                // Constants.RowCountがdataGridView.Rows.Count以上の値のとき
                else
                {
                    dataGridView.Enabled = false;
                    // dataGridViewの高さが余るので調整
                    dataGridView.Height = 25 + 21 * dataGridView.Rows.Count;
                    localTimeColumn.Width = longWidth;
                }
                radio3RowCount = dataGridView.Rows.Count;
            }

            outputButton.Enabled = true;
        }

        private void OutputButton_Click(object sender, EventArgs e)
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

            // ダイアログを表示・OKボタンをクリックしたとき
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    using (StreamWriter sw = new StreamWriter(stream, Encoding.UTF8))
                    {
                        // 指定した日時のエオルゼア時間とエオルゼアの月齢を表示(radioButton1)
                        if (etDisplay.Text != "- - : - -" && moonAgeDisplay.Text != "－－")
                        {
                            sw.WriteLine("指定日時のエオルゼア時間とエオルゼアの月齢");
                            sw.WriteLine("\n指定日時," + assignTime);
                            sw.WriteLine(etLabel.Text + "," + etDisplay.Text);
                            sw.WriteLine(moonAgeLabel.Text + "," + moonAgeDisplay.Text);
                        }
                        // 指定日以降にエオルゼアで指定した月齢になる日時を表示(radioButton2)
                        else if (etDisplay.Text == "- - : - -" && moonAgeDisplay.Text == "－－")
                        {
                            sw.WriteLine("エオルゼアで指定した月齢になるローカル時間");
                            sw.WriteLine("\n指定日," + assignTime.ToShortDateString() + " 以降");
                        }
                        // 指定日に指定したエオルゼア時間になるローカル時間を表示(radioButton3)
                        else if (etDisplay.Text != "- - : - -" && moonAgeDisplay.Text == "－－")
                        {
                            sw.WriteLine("指定したエオルゼア時間になるローカル時間");
                            sw.WriteLine("\n指定日," + assignTime.ToShortDateString());
                            sw.WriteLine("指定した" + etLabel.Text + "," + etDisplay.Text);
                        }
                        sw.Write("\n" + moonAgeColumn.HeaderText + "," + localTimeColumn.HeaderText);
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
                            // 指定した日時のエオルゼア時間とエオルゼアの月齢を表示(radioButton1)・指定日時の行
                            if (etDisplay.Text != "- - : - -" && moonAgeDisplay.Text != "－－" && i == Constants.RowCount / 2)
                            {
                                sw.Write(",◎");
                            }
                        }
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // マウスの現在位置を取得
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // ウィンドウを移動
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }
    }
}
