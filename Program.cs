using System;
using System.Threading;
public class MyThread
{
    public void Thread1()
    {
        Thread t = Thread.CurrentThread;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(t.Name + " is running "+i);

        }
    }
}
public class ThreadExample
{
    public static void Main()
    {
        MyThread mt = new MyThread();
        Thread t1 = new Thread(new ThreadStart(mt.Thread1));
        Thread t2 = new Thread(new ThreadStart(mt.Thread1));
        Thread t3 = new Thread(new ThreadStart(mt.Thread1));
        t1.Name = "Player1";
        t2.Name = "Player2";
        t3.Name = "Player3";
        t3.Priority = ThreadPriority.Highest;
        t2.Priority = ThreadPriority.Normal;
        t1.Priority = ThreadPriority.Lowest;

        t1.Start();
        t2.Start();
        t3.Start();
    }
}