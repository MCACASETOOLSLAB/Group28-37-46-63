import java.io.*;

public class SNW
{
    public static void main(String[] args)
    {
        int tm=2000;
        System.out.println("Timer set to : "+tm+"ms approximately.\n");
        Channel q = new Channel();
        
        new Receiver(q);
        new Sender(q);
        /*for(int i=0;Receiver.arr[Receiver.index]!=-1;i++){
            System.out.print(Receiver.arr[Receiver.index]+"  ");
        }*/
    }
}
