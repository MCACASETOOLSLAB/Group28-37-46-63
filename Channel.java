import java.io.*;
import java.util.*;

public class Channel
{
    int n;
    boolean flag=false;
    boolean timeup=false;
    boolean done=false;
    boolean frame_to_resend=false;
    
    int k=0;
    Random r=new Random();
    
    synchronized public void put(int n)
    {
        while(flag){
            try{
                wait();
            }catch(InterruptedException e)
            {
                System.err.println("Method interrupted!");
            } 
        }
        
        if(frame_to_resend)n=1-n;
        frame_to_resend=false;
        
        this.n=n;
        
        do{
            timeup=false;
            k=r.nextInt(4);
            int l = 600*(k+1);
            
            System.out.println("Sender : Sending "+n+" over the channel   (Estimated RTT = "+l+"ms)");
            Timer tm=new Timer(2000,this);
            
            try{
                tm.t.start();
                Thread.sleep(l);
            }catch(InterruptedException e)
            {
                System.err.println("Method interrupted!");
            }
            
            if(!timeup){
                flag=true;
                
                try{
                    tm.t.join();
                }catch(InterruptedException e)
                {
                    System.err.println("Method interrupted!");
                }
                
                notify();
                
            }
            else{
                System.out.println("Sender : TIME UP!! No ack received. Frame " +n+" will be sent again.\n");
                continue;
            }
        }while(!flag);
    }
    
    synchronized public void get()
    {
        while(!flag){
            try{
                wait();
            }catch(InterruptedException e)
            {
                System.err.println("Method interrupted!");
            }
        }
        k=r.nextInt(4);
        //k=3;
        if(k==3){
            this.n=1-this.n; //frame garbled
        }
        if(this.n==Receiver.i){    //received as expected
            System.out.println("Receiver : Received "+Receiver.i+". Sending acknowledgement "+((n+1)%2)+"\n");
            //Receiver.arr[Receiver.index++]=n;
            Receiver.i=1-Receiver.i;
        }else{
            System.out.println("Receiver : Received frame is in error or was not expected. Sending NAK "+Receiver.i+"\n");
            frame_to_resend=true;
            Sender.i=1-Sender.i;
        }
        flag=false;
        notify();
    }
}

        
              
              
                
             
        
        
