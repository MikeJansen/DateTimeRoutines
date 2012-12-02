using System;using System.Threading;

public class StaticThreads
{
    //testing static threads
    public static void Main1()
    {

        Thread myThread1 = new Thread(new
        ThreadStart(StaticThreads.DoSomething));
        Thread myThread2 = new Thread(new
        ThreadStart(StaticThreads.DoSomething));
        Thread myThread3 = new Thread(new
        ThreadStart(StaticThreads.DoSomething));

        myThread1.Name = "Thread 1";
        myThread2.Name = "Thread 2";
        myThread3.Name = "Thread 3";

        Console.WriteLine("Press ENTER to start,");
        Console.WriteLine("and ENTER again to stop.");
        Console.ReadLine();

        myThread1.Start();
        Thread.Sleep(300);
        myThread2.Start();
        Thread.Sleep(300);
        myThread3.Start();

        Console.ReadLine();
        myThread1.Abort();
        myThread2.Abort();
        myThread3.Abort();

    }

    public static void DoSomething()
    {
        while (true)
        {
            Console.WriteLine(Thread.CurrentThread.Name + DateTime.Now);
            Thread.Sleep(1000);
        }
    }
}
