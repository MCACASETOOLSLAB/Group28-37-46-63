import java.io.*;
import java.util.*;

public class Channel
{
    int n;
    boolean flag=false;
    boolean[] timeup={false,false,false,false};
    int time_index=-1;
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
            
            k=r.nextInt(3);
            int l = 800*(k+1);
            
            System.out.println("Sender : Sending "+n+" over the channel   (Estimated Transmission Delay = "+l+"ms)");
            Timer tm=new Timer(5000,this);
            timeup[time_index]=false;
            
            try{
                tm.t.start();
                Thread.sleep(l);
            }catch(InterruptedException e)
            {
                System.err.println("Method interrupted!");
            }
            
            if(!timeup[time_index]){
                flag=true;
                notify();
                
                /*try{
                    //tm.t.join();
                }catch(InterruptedException e)
                {
                    System.err.println("Method interrupted!");
                }
                
                notify();*/
                
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
        k=r.nextInt(2);
        if(k==0){
            System.out.println("Receiver : Received "+n+". Sending acknowledgement "+((n+1)%2)+"\n");
        }else{
            System.out.println("Receiver : Received frame is in error or was not expected. Sending NAK "+n+"\n");
            frame_to_resend=true;
            Sender.i=1-Sender.i;
        }
        flag=false;
        notify();
    }
}

        
              
              
                
             
        
        
