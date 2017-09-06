using System;
using System.Windows.Forms;

namespace EOCLO
{
    /// <summary>
    /// メインウィンドウのクラス
    /// </summary>
    public partial class MainForm : Form
    {
        // ウィンドウの境界線を表現するための配列
        Label[] borderLines;

        // 今の月齢になった日時
        DateTime moonAgeChangeTime;

        // マウスの位置
        int mouseX;
        int mouseY;

        public MainForm()
        {
            InitializeComponent();

            // 各コントロールのプロパティの設定
            // Labelは数が多いので配列にまとめる
            Label[] labels = { titleLabel, ltLabel, etLabel, ltDisplay, timeZoneDisplay, etDisplay, moonAgeLabel, moonAgeDisplay, convertLabel };
            Utility.SetControlProperty(this, labels, closeButton, convertButton, dataGridView);
            // dataGridViewの行数によってFormの高さやコントロールの位置を変える
            border.Top = dataGridView.Bottom + 10;
            convertButton.Top = border.Top + 10;
            convertLabel.Top = convertButton.Top + 5;
            this.Height = convertButton.Bottom + 10;
            // 境界線を描くLabelを配列に入れる
            borderLines = new Label[] { borderTop, borderBottom, borderLeft, borderRight };
            Utility.SetBorderLines(this, borderLines);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // PCの日時の設定が基準日時よりも前ならアプリが動作しないようにする
            if (DateTime.UtcNow < Constants.BaseTime)
            {
                MessageBox.Show("エオルゼア時間を正常に表示できません。PCの日付と時刻を正しく設定し直してください。");
                this.Close();
            }
            else
            {
                timer.Start();
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            Utility.ActiveBorderLine(this, borderLines);
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            Utility.DeactiveBorderLine(this, borderLines);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // 現在のUTCとローカル時間を取得
            DateTime utcNow = DateTime.UtcNow;
            DateTime localTime = utcNow.ToLocalTime();

            // ローカル時間を表示
            ltDisplay.Text = localTime.ToString("yyyy/MM/dd  HH:mm:ss");
            timeZoneDisplay.Text = localTime.ToString("(UTCzzz)");

            // エオルゼア時間を表示
            TimeSpan differenceTime = utcNow - Constants.BaseTime;
            int eorzeaTime = Utility.GetEorzeaTime(differenceTime);
            etDisplay.Text = Utility.GetEorzeaHour(eorzeaTime).ToString("00") + ":" + Utility.GetEorzeaMinute(eorzeaTime).ToString("00");

            // 初期設定時 || 月齢が変化する日時にdataGridViewを更新
            if (moonImageBox.Image == null
                || utcNow.ToString("yyyy/MM/dd HH:mm:ss") == moonAgeChangeTime.AddMinutes(Constants.EorzeaDay).ToString("yyyy/MM/dd HH:mm:ss"))
            {
                // エオルゼアの月齢を表示
                int moonAgeIndex = Utility.GetMoonAgeIndex(differenceTime);
                moonAgeDisplay.Text = Constants.MoonAgeNames[moonAgeIndex];
                moonImageBox.Image = Constants.MoonImages[Utility.GetMoonImagesIndex(moonAgeIndex)];

                // dataGridViewに表示
                dataGridView.Rows.Clear();
                moonAgeChangeTime = Utility.GetMoonAgeChangeTime(differenceTime);
                Utility.SetMoonAgeAndTime(dataGridView, moonAgeIndex, moonAgeChangeTime);
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // 時間変換ウィンドウを開く
            ConvertForm.Instance.Show();
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
