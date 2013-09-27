import java.io.*;

public class Receiver implements Runnable
{
    Channel q;
    Thread t;
    
    public Receiver(Channel q)
    {
        this.q=q;
        t=new Thread(this,"Cons");
        t.start();
    }
    
    public void run()
    {
        while(!q.done){
            q.get();
        }
    }
    
}

            
        
