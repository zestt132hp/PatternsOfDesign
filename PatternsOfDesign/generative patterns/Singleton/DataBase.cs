namespace PatternsOfDesign.generative_patterns.Singleton
{
    class DataBase
    {
        private static DataBase _instance;
#pragma warning disable 649
        private static object _lock;
#pragma warning restore 649

        private DataBase()
        {
            //создаём подключение к бд
            _instance = this;
        }

        public static DataBase GetInstance()
        {
            lock (_lock)
            {
                return _instance ?? new DataBase();
            }
        }

        public void Query(string query)
        {
        }
    }
}
