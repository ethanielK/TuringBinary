namespace _00__单例模式
{
    internal class NormalLazyMan
    {
        private static NormalLazyMan instance;

        private NormalLazyMan() { }

        public void Eat() => Console.WriteLine("吃饭");

        public static NormalLazyMan GetInstance()
        {
            Console.WriteLine($"LazyMan is created by {Thread.CurrentThread.ManagedThreadId}");
            return instance ?? (instance = new NormalLazyMan());
        }
    }
}
