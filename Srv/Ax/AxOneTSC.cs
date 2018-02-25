using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Threading;

public class AxOneTSC : SynchronizationContext
{
    // 线程同步队列,发送接收socket回调都放到该队列,由poll线程统一执行

    private readonly ConcurrentQueue<Action> queue = new ConcurrentQueue<Action>();
    // Use this for initialization
    private void Add(Action ac)
    {
        this.queue.Enqueue(ac);
    }
    
    void Start()
	{

	}

    // Update is called once per frame
    public void Update()
	{
        while(true)
        {
            Action a;
            if(!this.queue.TryDequeue(out a))
            {
                return;

            }
            a();
        }

	}
    public override void Post(SendOrPostCallback d, object state)
    {
        this.Add(() => { d(state); });
    }
}
