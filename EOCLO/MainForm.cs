using System;
using System.Windows.Forms;

namespace EOCLO
{
    /// <summary>
    /// メインウィンドウのクラス
    /// </summary>
    public partial class MainForm : Form
    {
        // ウィンドウの境界線を表現するために配置したLabelの配列
        Label[] borderLines;

        // 今の月齢になった日時
        DateTime moonTime;

        // マウスの位置
        int mouseX;
        int mouseY;
        
        public MainForm()
        {
            InitializeComponent();

            // 各コントロールの設定
            // Labelは数が多いので配列にまとめる
            Label[] labels = { titleLabel, ltLabel, etLabel, ltDisplay, timeZoneDisplay, etDisplay, moonAgeLabel, moonAgeDisplay, convertLabel };
            Utility.SetFormsStyle(this, labels, closeButton, convertButton, dataGridView);

            borderLines = new Label[]{ borderTop, borderBottom, borderLeft, borderRight };
            Utility.SetBorderLines(this, borderLines);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // PCの日時の設定が基準日時よりも前ならアプリが動作しないようにする
            DateTime utcNow = DateTime.UtcNow;
            if (utcNow < Constants.BaseTime)
            {
                MessageBox.Show("エオルゼア時間を正常に表示できません。PCの日付と時刻を正しく設定し直してください。");
                //convertButton.Enabled = false;
                this.Close();
            }
            else
            {
                // タイマースタート
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 現在のUTCとローカル日時を取得
            DateTime utcNow = DateTime.UtcNow;
            DateTime localTime = utcNow.ToLocalTime();

            // ローカル日時の表示
            ltDisplay.Text = localTime.ToString("yyyy/MM/dd HH:mm:ss");
            timeZoneDisplay.Text = localTime.ToString("(UTCzzz)");

            // 現在のUTCからエオルゼア時間を求めて結果を表示
            TimeSpan differenceTime = utcNow - Constants.BaseTime;
            etDisplay.Text = Utility.GetEorzeaHour(Utility.GetEorzeaTime(differenceTime)).ToString("00")
                    + ":" + Utility.GetEorzeaMinute(Utility.GetEorzeaTime(differenceTime)).ToString("00");

            // 初期設定時 || 月齢変化のタイミングでDataGridViewを更新
            if (moonImageBox.Image == null
                || utcNow.ToString("yyyy/MM/dd HH:mm:ss") == moonTime.AddMinutes(Constants.SwitchMoon).ToString("yyyy/MM/dd HH:mm:ss"))
            {
                int moonIndex = Utility.GetMoonAgeIndex(differenceTime);
                moonTime = Utility.GetMoonTime(differenceTime);
                moonAgeDisplay.Text = Constants.moonAgeNames[moonIndex];
                moonImageBox.Image = Constants.moonImages[moonIndex];
                dataGridView.Rows.Clear();
                Utility.SetMoonAgeColumns(dataGridView, moonImageColumn, moonIndex);
                Utility.SetMoonAgeTime(dataGridView, moonTime);
            }

            // 境界線の色を更新
            Utility.SwitchBorderLine(this, borderLines);
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // 時間変換ウィンドウを開く
            ConvertForm.Instance.Show();
            ConvertForm.Instance.Activate();
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

        // Formの周りに影を付けたかった
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        const int CS_DROPSHADOW = 0x00020000;
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= CS_DROPSHADOW;
        //        return cp;
        //    }
        //}
    }
}
