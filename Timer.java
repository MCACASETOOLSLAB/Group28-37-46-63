import java.io.*;

public class Timer implements Runnable
{
    Thread t;
    long limit;
    Channel q;
    
    public Timer(long l,Channel q)
    {
        this.q=q;
        limit=l;
        t=new Thread(this,"Timer");
    }
    
    public void run()
    {
        try{
             Thread.sleep(limit);
        }catch(InterruptedException e)
        {
            System.err.println("Thread interrupted");
        }
        q.timeup=true;
    }
}

  
