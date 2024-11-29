namespace _00__单例模式
{
    internal class LockLazyMan
    {
        private LockLazyMan() { }

        // volatile 避免指针重排，保证线程安全
        private static volatile LockLazyMan instance;
        private static readonly object locker = new object();

        public void Eat() => Console.WriteLine("吃饭");

        public static LockLazyMan GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LockLazyMan();
                        Console.WriteLine($"LockLazyMain is created by {Thread.CurrentThread.ManagedThreadId}.");
                    }
                }
            }

            return instance;
        }
    }
}
