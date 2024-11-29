namespace _00__单例模式
{
    internal class HungryMan
    {
        private static HungryMan instance = new HungryMan();
        private HungryMan()
        {
            Console.WriteLine("饿汉已创建");
        }
        
        public static HungryMan GetInstance()
        {
            return instance;
        }

        public void Eat()
        {
            Console.WriteLine("吃饭");
        }
    }
}
