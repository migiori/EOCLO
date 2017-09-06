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
        /// コントロールのプロパティの設定
        /// </summary>
        /// <param name="form"> Formクラス</param>
        /// <param name="labels"> Labelを入れた配列 </param>
        /// <param name="closeButton"> 「×」ボタン </param>
        /// <param name="convertButton">  「開く」または「変換」ボタン </param>
        /// <param name="dataGridView"> DataGridView </param>
        public static void SetControlProperty(Form form, Label[] labels, Button closeButton, Button convertButton, DataGridView dataGridView)
        {
            // 各コントロールの色の設定
            form.BackColor = Color.FromArgb(60, 60, 60);
            Color textColor = Constants.TextColor;
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].ForeColor = textColor;
            }
            closeButton.ForeColor = Constants.ButtonForeColor;
            convertButton.BackColor = Constants.ButtonBackColor;
            convertButton.ForeColor = Constants.ButtonForeColor;

            // dataGridViewのスタイルを変更
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 80, 80);
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewContentAlignment alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].HeaderCell.Style.Alignment = alignment;
            dataGridView.Columns[2].HeaderCell.Style.Alignment = alignment;
            dataGridView.Columns[1].DefaultCellStyle.Alignment = alignment;
            dataGridView.Columns[2].DefaultCellStyle.Alignment = alignment;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dataGridView.ForeColor = Color.FromArgb(200, 200, 200);
            // dataGridView.Heightの初期値は25
            dataGridView.Height += 21 * Constants.RowCount;
            // 画像未設定時に×画像が表示されないようにする
            dataGridView.Columns[0].DefaultCellStyle.NullValue = null;
        }

        /// <summary>
        /// formの境界線の初期設定
        /// </summary>
        /// <param name="form"> Formクラス </param>
        /// <param name="borderLines"> 境界線の配列 </param>
        public static void SetBorderLines(Form form, Label[] borderLines)
        {
            Size width = new Size(form.Width, 1);
            Size height = new Size(1, form.Height);
            borderLines[0].Size = width;
            borderLines[1].Size = width;
            borderLines[2].Size = height;
            borderLines[3].Size = height;
            //Point origin = new Point(0, 0);
            //borderLines[0].Location = origin;
            borderLines[1].Location = new Point(0, form.Height - 1);
            //borderLines[2].Location = origin;
            borderLines[3].Location = new Point(form.Width - 1, 0);
        }

        /// <summary>
        /// formがアクティブのときの境界線の色
        /// </summary>
        /// <param name="form"> Formクラス </param>
        /// <param name="borderLines"> 境界線の配列 </param>
        public static void ActiveBorderLine(Form form, Label[] borderLines)
        {
            for (int i = 0; i < borderLines.Length; i++)
            {
                borderLines[i].BackColor = SystemColors.ActiveCaption;
            }
        }

        /// <summary>
        /// formが非アクティブのときの境界線の色
        /// </summary>
        /// <param name="form"> Formクラス </param>
        /// <param name="borderLines"> 境界線の配列 </param>
        public static void DeactiveBorderLine(Form form, Label[] borderLines)
        {
            for (int i = 0; i < borderLines.Length; i++)
            {
                borderLines[i].BackColor = Color.Black;
            }
        }

        /// <summary>
        /// 指定日時と基準日時の差からエオルゼア時間を計算
        /// </summary>
        /// <param name="differenceTime"> 指定日時と基準日時の差 </param>
        /// <returns> エオルゼアの1日が何分経過したか </returns>
        public static int GetEorzeaTime(TimeSpan differenceTime)
        {
            // エオルゼア時間の1日が地球時間で何秒経過しているか
            double eorzeaDayTime = differenceTime.TotalSeconds % (Constants.EorzeaDay * 60);
            // 地球時間のeorzeaDayTime秒がエオルゼア時間で何秒か
            int eorzeaTimeSec = (int)((eorzeaDayTime * 1440) / Constants.EorzeaDay);
            // エオルゼアの1日が何分経過したか
            return eorzeaTimeSec / 60;
        }

        /// <summary>
        /// エオルゼアの1日の経過時間からエオルゼア時間で何時になるか計算
        /// </summary>
        /// <param name="minute"> エオルゼアの1日が何分経過したか </param>
        /// <returns> エオルゼア時間で何時か </returns>
        public static int GetEorzeaHour(int minute)
        {
            return minute / 60;
        }

        /// <summary>
        /// エオルゼアの1日の経過時間からエオルゼア時間で何分になるか計算
        /// </summary>
        /// <param name="minute"> エオルゼアの1日が何分経過したか </param>
        /// <returns> エオルゼア時間で何分か </returns>
        public static int GetEorzeaMinute(int minute)
        {
            return minute % 60;
        }

        /// <summary>
        /// 指定日時と基準日時の差からConstants.MoonAgeNamesの要素番号を取得
        /// </summary>
        /// <param name="differenceTime"> 指定日時と基準日時の差 </param>
        /// <returns> Constants.MoonAgeNamesの要素番号 </returns>
        public static int GetMoonAgeIndex(TimeSpan differenceTime)
        {
            int result = 0;
            // 月齢が変化する日時を月の出の時間に合わせるために半日分早める
            double adjustTime = differenceTime.TotalMinutes + (Constants.EorzeaDay / 2);
            for (int i = 0; i < Constants.MoonAgeNames.Length; i++)
            {
                // adjustTimeを月齢周期で割った余りからConstants.MoonAgeNamesの要素番号を求める
                if (adjustTime % Constants.MoonCycle < Constants.EorzeaDay * (i + 1))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Constants.MoonAgeNamesの要素番号からConstants.MoonImagesの要素番号を取得
        /// </summary>
        /// <param name="moonAgeIndex"> Constants.MoonAgeNamesの要素番号 </param>
        /// <returns> Constants.MoonImagesの要素番号 </returns>
        public static int GetMoonImagesIndex(int moonAgeIndex)
        {
            int result = 0;
            for (int i = 0; i < Constants.MoonImages.Length; i += 2)
            {
                // 0か8の倍数(新月・上弦・満月・下弦)のとき
                if (moonAgeIndex == i * 4)
                {
                    result = i;
                    break;
                }
                // 8の倍数未満(それ以外)のとき
                else if (moonAgeIndex < 4 * (i + 2))
                {
                    result = i + 1;
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// 指定日時と基準日時の差から月齢が変化した日時を取得
        /// </summary>
        /// <param name="differenceTime"> 指定日時と基準日時の差 </param>
        /// <returns> 指定日時の月齢に変化した日時 </returns>
        public static DateTime GetMoonAgeChangeTime(TimeSpan differenceTime)
        {
            // 基準日時から指定日時までに何回月齢が変化したか・月齢が変化する日時を月の出の時間に合わせるために半日分早める
            int moonAgeCount = (int)((differenceTime.TotalMinutes + (Constants.EorzeaDay / 2)) / Constants.EorzeaDay);
            // 指定日時の月齢に変化した日時・上で早めた時間を戻す
            return Constants.BaseTime.AddMinutes((moonAgeCount * Constants.EorzeaDay) - (Constants.EorzeaDay / 2));
        }

        /// <summary>
        /// dataGridViewに月齢とその月齢に変化した(する)日時を追加
        /// </summary>
        /// <param name="dataGridView"> DataGridView </param>
        /// <param name="moonAgeIndex"> Constants.MoonAgeNamesの要素番号 </param>
        /// <param name="moonAgeChangeTime"> 指定日時の月齢に変化した日時 </param>
        public static void SetMoonAgeAndTime(DataGridView dataGridView, int moonAgeIndex, DateTime moonAgeChangeTime)
        {
            // 要素数32の配列Constants.MoonAgeNamesから、[moonAgeIndex]を中心にConstants.RowCount個の要素を取り出してdataGridViewに追加する
            int halfRowCount = Constants.RowCount / 2;
            int start = moonAgeIndex - halfRowCount;
            int end = moonAgeIndex + halfRowCount;
            if (moonAgeIndex < halfRowCount)
            {
                start += Constants.MoonAgeNames.Length;
                AlignMoonAge(dataGridView, start, end);
            }
            else if (moonAgeIndex > Constants.MoonAgeNames.Length - (halfRowCount + 1))
            {
                end -= Constants.MoonAgeNames.Length;
                AlignMoonAge(dataGridView, start, end);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    dataGridView.Rows.Add(Constants.MoonImages[GetMoonImagesIndex(i)], Constants.MoonAgeNames[i]);
                }
            }

            // dataGridViewに月齢が変化した(する)日時を追加
            for (int i = -halfRowCount; i <= halfRowCount; i++)
            {
                dataGridView.Rows[i + halfRowCount].Cells[dataGridView.Columns.Count - 1].Value
                    = moonAgeChangeTime.AddMinutes(Constants.EorzeaDay * i).ToLocalTime().ToString("yyyy/MM/dd HH:mm") + " ～";
            }

            // 指定日時の行の色を変える
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView[i, halfRowCount].Style.BackColor = Color.FromArgb(80, 100, 160);
                dataGridView[i, halfRowCount].Style.ForeColor = Color.FromArgb(220, 220, 220);
            }
            dataGridView.ClearSelection();
        }

        /// <summary>
        /// 月齢をdataGridViewに追加するために整列
        /// </summary>
        /// <param name="dataGridView"> DataGridView </param>
        /// <param name="start"> 最初に列に追加するConstants.MoonAgeNamesの要素番号 </param>
        /// <param name="end"> 最後に列に追加するConstants.MoonAgeNamesの要素番号 </param>
        private static void AlignMoonAge(DataGridView dataGridView, int start, int end)
        {
            for (int i = start; i < Constants.MoonAgeNames.Length; i++)
            {
                dataGridView.Rows.Add(Constants.MoonImages[GetMoonImagesIndex(i)], Constants.MoonAgeNames[i]);
            }
            for (int i = 0; i <= end; i++)
            {
                dataGridView.Rows.Add(Constants.MoonImages[GetMoonImagesIndex(i)], Constants.MoonAgeNames[i]);
            }
        }
    }
}
