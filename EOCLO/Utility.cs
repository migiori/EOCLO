using System;
using System.Drawing;
using System.Windows.Forms;

namespace EOCLO
{
    /// <summary>
    /// 各Formクラス共通で使うメソッドをまとめたクラス
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// コントロールのスタイルの設定
        /// </summary>
        /// <param name="form"> Formクラス</param>
        /// <param name="labels"> Labelを入れた配列 </param>
        /// <param name="closeButton"> 「閉じる」ボタン </param>
        /// <param name="convertButton">  時間変換ウィンドウを「開く」ボタン </param>
        /// <param name="dataGridView"> DataGridView </param>
        public static void SetFormsStyle(Form form, Label[] labels, Button closeButton, Button convertButton, DataGridView dataGridView)
        {
            // 各コントロールの色の設定
            form.BackColor = Color.FromArgb(60, 60, 60);
            Color textColor = Color.FromArgb(200, 200, 200);
            for (int i = 0;i<labels.Length; i++)
            {
                labels[i].ForeColor = textColor;
            }
            closeButton.ForeColor = Color.FromArgb(240, 240, 240);
            convertButton.BackColor = Color.FromArgb(100, 100, 100);
            convertButton.ForeColor = Color.FromArgb(240, 240, 240);

            // DataGridViewのスタイルを変更
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 80, 80);
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dataGridView.ForeColor = textColor;
            // 画像未設定時に×画像が表示されないようにする
            dataGridView.Columns[0].DefaultCellStyle.NullValue = null;
        }

        /// <summary>
        /// Formの境界線の初期設定
        /// </summary>
        /// <param name="form"> Formクラス </param>
        /// <param name="borderLines"> 境界線(Label)の配列 </param>
        public static void SetBorderLines(Form form, Label[] borderLines)
        {
            borderLines[0].Size = new Size(form.Size.Width, 1);
            borderLines[1].Size = new Size(form.Size.Width, 1);
            borderLines[2].Size = new Size(1, form.Size.Height);
            borderLines[3].Size = new Size(1, form.Size.Height);
            borderLines[0].Location = new Point(0, 0);
            borderLines[1].Location = new Point(0, form.Height - 1);
            borderLines[2].Location = new Point(0, 0);
            borderLines[3].Location = new Point(form.Width - 1, 0);
        }

        /// <summary>
        /// Formの境界線の色の切替
        /// </summary>
        /// <param name="form"> Formクラス </param>
        /// <param name="borderLines"> 境界線(Label)の配列 </param>
        public static void SwitchBorderLine(Form form, Label[] borderLines)
        {
            if (Form.ActiveForm == form)
            {
                for (int i = 0; i < borderLines.Length; i++)
                {
                    borderLines[i].BackColor = SystemColors.ActiveCaption;
                }
            }
            else
            {
                for (int i = 0; i < borderLines.Length; i++)
                {
                    borderLines[i].BackColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// 指定日時と基準日時の差を元にエオルゼア時間を計算
        /// </summary>
        /// <param name="differenceTime"> 指定日時と基準日時の差 </param>
        /// <returns> エオルゼアで1日が何分経過したか </returns>
        public static int GetEorzeaTime(TimeSpan differenceTime)
        {
            // エオルゼア時間の1日が地球時間で何秒経過しているか
            double eorzeaDayTime = differenceTime.TotalSeconds % (Constants.EorzeaDayMin * 60);
            // 地球時間のeorzeaDayTime秒がエオルゼア時間で何秒か
            int eorzeaTimeSec = (int)((eorzeaDayTime * 1440) / Constants.EorzeaDayMin);
            // エオルゼアの1日が何分経過したか
            return eorzeaTimeSec / 60;
        }

        /// <summary>
        /// エオルゼア時間で何時か
        /// </summary>
        /// <param name="minute"> エオルゼアの1日が何分経過したか </param>
        /// <returns> エオルゼア時間で何時か </returns>
        public static int GetEorzeaHour(int minute)
        {
            return minute / 60;
        }

        /// <summary>
        /// エオルゼア時間で何分か
        /// </summary>
        /// <param name="minute"> エオルゼアの1日が何分経過したか </param>
        /// <returns> エオルゼア時間で何分か </returns>
        public static int GetEorzeaMinute(int minute)
        {
            return minute % 60;
        }

        /// <summary>
        /// 指定日時と基準日時の差からエオルゼアの月齢を要素番号で取得
        /// </summary>
        /// <param name="differenceTime"> 指定日時と基準日時の差 </param>
        /// <returns> 月齢配列の要素番号 </returns>
        public static int GetMoonAgeIndex(TimeSpan differenceTime)
        {
            int result = 0;

            // 基準日に丁度新月で始めるために月齢変化のタイミングを半周分早める
            double adjustTime = differenceTime.TotalMinutes + (Constants.SwitchMoon / 2);
            // 今の月齢を求める
            for (int i = 0; i < Constants.moonAgeNames.Length; i++)
            {
                // adjustTimeを月齢周期で割った余りから月齢を求める
                if (adjustTime % Constants.CycleMoon < Constants.SwitchMoon * (i + 1))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// DataGridViewに追加する月齢の設定
        /// </summary>
        /// <param name="dataGridView"> DataGridView </param>
        /// <param name="imageColumn"> DataGridViewImageColumn </param>
        /// <param name="moonIndex"> 月齢配列の要素番号 </param>
        public static void SetMoonAgeColumns(DataGridView dataGridView, DataGridViewImageColumn imageColumn, int moonIndex)
        {
            // Icon型ではなくImage型のデータを表示する
            // デフォルトでfalse
            //imageColumn.ValuesAreIcons = false;

            // 要素数8の配列moonAgeNamesから、[moonIndex]を中心に9個の要素を取り出してDataGridViewに追加する
            int number = 0;
            if (moonIndex < 4)
            {
                number = moonIndex + 4;
            }
            else
            {
                number = moonIndex - 4;
            }
            for (int i = number; i < Constants.moonAgeNames.Length; i++)
            {
                SetMoonAgeRows(dataGridView, imageColumn, i);
            }
            for (int i = 0; i <= number; i++)
            {
                SetMoonAgeRows(dataGridView, imageColumn, i);
            }

            // 指定した時間の行の色を変える
            Color backColor = Color.FromArgb(80, 100, 160);
            Color foreColor = Color.FromArgb(220, 220, 220);
            for(int i =0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView[i, 4].Style.BackColor = backColor;
                dataGridView[i, 4].Style.ForeColor = foreColor;
            }

            dataGridView.ClearSelection();
        }

        /// <summary>
        /// DataGridViewに月齢を追加
        /// </summary>
        /// <param name="dataGridView"> DataGridView </param>
        /// <param name="imageColumn"> DataGridViewImageColumn </param>
        /// <param name="moonIndex"> 月齢配列の要素番号 </param>
        private static void SetMoonAgeRows(DataGridView dataGridView, DataGridViewImageColumn imageColumn, int moonIndex)
        {
            // イメージを縦横の比率を維持して拡大・縮小表示する
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView.Rows.Add(Constants.moonImages[moonIndex], Constants.moonAgeNames[moonIndex]);
        }

        /// <summary>
        /// 月齢が変化した日時を取得
        /// </summary>
        /// <param name="differenceTime"> 指定日時と基準日時の差 </param>
        /// <returns> 月齢が変化した日時 </returns>
        public static DateTime GetMoonTime(TimeSpan differenceTime)
        {
            // 基準日から指定日時までに何回月齢が変化したか・月齢変化のタイミングを半周分早める
            int moonNumber = (int)((differenceTime.TotalMinutes + (Constants.SwitchMoon / 2)) / Constants.SwitchMoon);
            // 指定日時の月齢に変化した日時・上で早めた月齢変化のタイミングを戻す
            return Constants.BaseTime.AddMinutes((moonNumber * Constants.SwitchMoon) - (Constants.SwitchMoon / 2));
        }

        /// <summary>
        /// 月齢に対するローカル時間の設定
        /// </summary>
        /// <param name="dataGridView"> DataGridView </param>
        /// <param name="moonTime"> 月齢が変化した日時 </param>
        public static void SetMoonAgeTime(DataGridView dataGridView, DateTime moonTime)
        {
            // 月齢変化の日時をmoonTimeと前後4回分求める
            for (int i = -4; i <= 4; i++)
            {
                dataGridView.Rows[i + 4].Cells[dataGridView.Columns.Count - 1].Value
                    = moonTime.AddMinutes(Constants.SwitchMoon * i).ToLocalTime().ToString("yyyy/MM/dd HH:mm") + " ～";
            }
        }
    }
}
