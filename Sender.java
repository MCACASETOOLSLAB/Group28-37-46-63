import java.io.*;

public class Receiver implements Runnable
{
    Channel q;
    Thread t;
    static int i=0;
    //static int arr[];
    static int index=0;
    
    public Receiver(Channel q)
    {
        this.q=q;
        t=new Thread(this,"Cons");
        t.start();
        /*arr=new int[10];
        for(int i=0;i<index;i++){
            arr[i]=-1;
        }*/
    }
    
    public void run()
    {
        while(!q.done){
            q.get();
        }
    }
    
}

            
        
