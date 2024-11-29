namespace _00__单例模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region HungryMan

            HungryMan man1 = HungryMan.GetInstance();
            man1.Eat();

            HungryMan man2 = HungryMan.GetInstance();
            man2.Eat();

            Console.WriteLine("\n\n");

            #endregion

            #region LockLazyMan

            //NormalLazyMan lazyMan1 = NormalLazyMan.GetInstance();
            //lazyMan1.Eat();

            //NormalLazyMan lazyMan2 = NormalLazyMan.GetInstance();
            //lazyMan2.Eat();

            Console.WriteLine("NormalLazyMan 多线程竞争");

            for (int i = 0; i < 10; i++)
            {
                new Thread(() => { NormalLazyMan.GetInstance(); }).Start();
            }

            Console.WriteLine("\n\n");

            #endregion

            #region LockLazyMan

            //LockLazyMan lockLazyMan1 = LockLazyMan.GetInstance();
            //lockLazyMan1.Eat();

            //LockLazyMan lockLazyMan2 = LockLazyMan.GetInstance();
            //lockLazyMan2.Eat();

            Console.WriteLine("LockLazyMan 多线程竞争");

            for (int i = 0; i < 10; i++)
            {
                new Thread(() =>
                {
                    (LockLazyMan.GetInstance()).Eat();
                }).Start();
            }

            #endregion

            Console.ReadKey();
        }
    }
}
