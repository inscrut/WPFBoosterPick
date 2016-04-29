namespace WPFBoosterPick
{
    public class DB
    {
        /// <summary>
        /// Колличество эпических карт
        /// </summary>
        public int epic_count { get; set; }
        /// <summary>
        /// Колличество легендарных карт
        /// </summary>
        public int leg_count { get; set; }
        /// <summary>
        /// Колличество золотых обычных карт
        /// </summary>
        public int g_com_count { get; set; }
        /// <summary>
        /// Колличество золотых редких карт
        /// </summary>
        public int g_rare_count { get; set; }
        /// <summary>
        /// Колличество золотых эпических карт
        /// </summary>
        public int g_epic_count { get; set; }
        /// <summary>
        /// Колличество золотых легендарных карт
        /// </summary>
        public int g_leg_count { get; set; }

        /// <summary>
        /// Создать пустой класс
        /// </summary>
        public DB()
        {
            epic_count = 0;
            leg_count = 0;
            g_com_count = 0;
            g_rare_count = 0;
            g_epic_count = 0;
            g_leg_count = 0;
        }
    }
}
