import java.io.*;

public class Sender implements Runnable
{
    Channel q;
    Thread t;
    public static int i=0;
    
    public Sender(Channel q)
    {
        this.q=q;
        t=new Thread(this,"Prod");
        t.start();
        
    }
    
    public void run()
    {
        int k=0;
        while(!q.done){
            
            q.put(i);
            i=(i+1)%2;
            k++;
            if(k==5)q.done=true;
        }
    }
    
}

            
        
