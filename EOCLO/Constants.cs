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
        /// 基準となる日時の指定
        /// </summary>
        public static readonly DateTime BaseTime = new DateTime(2010, 9, 16, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// エオルゼアの1日(24時間)は地球時間の70分
        /// </summary>
        public const int EorzeaDayMin = 70;

        /// <summary>
        /// 月齢名を格納しておく配列
        /// </summary>
        public static readonly string[] moonAgeNames = { "新月", "新月と下弦の間", "下弦の月", "下弦と満月の間", "満月", "満月と上弦の間", "上弦の月", "上弦と新月の間" };

        /// <summary>
        /// エオルゼアで月齢が変わるのは地球時間の280分
        /// </summary>
        public static readonly int SwitchMoon = 280;
        /// <summary>
        /// エオルゼアの月齢周期
        /// </summary>
        public static readonly int CycleMoon = SwitchMoon * moonAgeNames.Length;

        /// <summary>
        /// ImageListだと画像の境界線が汚くなるのでImageの配列を定義
        /// </summary>
        public static readonly Image[] moonImages = new Image[moonAgeNames.Length];

        static Constants()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            for (int i = 0; i < moonAgeNames.Length; i++)
            {
                Stream stream = assembly.GetManifestResourceStream("EOCLO.Resources.Moon" + i + ".png");
                Bitmap img = new Bitmap(stream);
                moonImages[i] = img;
            }
        }
    }
}
