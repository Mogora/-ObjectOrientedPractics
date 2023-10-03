using System.Drawing;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит данные об используемых цветах.
    /// </summary>
    public static class AppColor
    {
        /// <summary>
        /// Цвет корреткного значения.
        /// </summary>
        public static Color CorrectColor = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static Color ErrorColor = Color.FromArgb(255, 182, 193);
    }
}
