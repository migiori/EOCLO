using System;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace EOCLO
{
    /// <summary>
    /// 定数を定義するクラス
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Formを背景とするLabelの前景色
        /// </summary>
        public static readonly Color TextColor = Color.FromArgb(210, 210, 210);

        /// <summary>
        /// Buttonの背景色
        /// </summary>
        public static readonly Color ButtonBackColor = Color.FromArgb(100, 100, 100);

        /// <summary>
        /// Buttonの前景色
        /// </summary>
        public static readonly Color ButtonForeColor = Color.FromArgb(240, 240, 240);

        /// <summary>
        /// DataGridViewの行数
        /// </summary>
        public static readonly int RowCount = 9;

        /// <summary>
        /// 時間や月齢を変換するときに基準となる日時
        /// </summary>
        public static readonly DateTime BaseTime = new DateTime(2010, 4, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// エオルゼアの1日(24時間)は地球時間の70分
        /// </summary>
        public const int EorzeaDay = 70;

        /// <summary>
        /// 月齢名の配列
        /// </summary>
        public static readonly string[] MoonAgeNames = {
            "新月 (一日月)",
            "二日月",
            "三日月",
            "四日月",
            "五日月",
            "六日月",
            "七日月",
            "八日月",
            "上弦 (九日月)",
            "十日月",
            "十一日月",
            "十二日月",
            "十三日月",
            "十四日月",
            "十五日月",
            "十六日月",
            "満月 (十七日月)",
            "十八日月",
            "十九日月",
            "二十日月",
            "二十一日月",
            "二十二日月",
            "二十三日月",
            "二十四日月",
            "下弦 (二十五日月)",
            "二十六日月",
            "二十七日月",
            "二十八日月",
            "二十九日月",
            "三十日月",
            "三十一日月",
            "三十二日月" };

        /// <summary>
        /// エオルゼアの月齢周期
        /// </summary>
        public static readonly int MoonCycle = EorzeaDay * MoonAgeNames.Length;

        /// <summary>
        /// ImageListだと画像の境界線が汚くなるので月のImageの配列を定義
        /// </summary>
        public static readonly Image[] MoonImages = new Image[8];

        static Constants()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            for (int i = 0; i < MoonImages.Length; i++)
            {
                Stream stream = assembly.GetManifestResourceStream("EOCLO.Resources.Moon" + i + ".png");
                Bitmap img = new Bitmap(stream);
                MoonImages[i] = img;
            }
        }
    }
}
