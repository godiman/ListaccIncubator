        
            // Ant on chess board

package antonchessboard2;

import java.util.Scanner;

/**
 *
 * @author Gooditech
 */
public class AntOnChessBoard2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //scanner object
       Scanner input = new Scanner(System.in);
       
       //Declaration of variables
       int position = 1;
       int x = 1, y=1;
       int last_x,last_y;
       int numbers;
       boolean found = false; 
       
       //Get input from the user
        System.out.println("Enter any number to check the position");
            numbers = input.nextInt();
        
        while(numbers!= position ){
            
            
            //increment y by 1
            y=y+1;
            position = position+1;
            last_y = y;
                 if (numbers==position) 
                {
                  //System.out.println(x+" "+y);
                    break;
                }
                 
                 
                //increment x by 1
            x = x+1;
            position = position+1;
            last_x = x;
                if (numbers==position) 
                {
                    //System.out.println(x+" "+y);
                    break;
                }
            
            
            
            //Reduce y till y=1
            for (; y>1; ) 
            {
                y= y-1;
                position = position+1;
                        if (position==numbers) 
                    {
                       // System.out.println(x+" "+y);
                        break;
                    }
            }
            
                 if (numbers==position) {
                     //System.out.println(x+" "+y);
                    break;
                 }
            //Increment the last value of x
            x = last_x;
            x = x+1;
            position= position+1;
            last_x = x;
                 if (numbers==position) 
                {
                    //System.out.println(x+" "+y);
                    break;
                }
            
            for (; y < last_y+1; ) 
            {
                 y = y+1;
                position = position+1;
                //last_y = y;
                if (numbers==position) 
                {
                    //System.out.println(x+" "+y);
                    break;
                }
            }
                if (numbers==position) 
                {
                    //System.out.println(x+" "+y);
                    break;
                }
           
                
                // Reduce x till is 1
            for (; x >1; ) 
            {
                x=x-1;
                position = position+1;
                if (numbers==position) 
                {
                    //System.out.println(x+" "+y);
                    break;
                }
            }
            
            if ((numbers>9) && (position >9))  
            {
                for (; y < last_y+1; ) 
                {
                            y = y+1;
                            position = position+1;
                        if (numbers==position) 
                        {
                            //System.out.println(x+" "+y);
                            break;
                        }
                }
                     if (numbers==position) 
                        {
                            //System.out.println(x+" "+y);
                            break;
                        }
                
                for (; x < last_x+1; ) 
                {
                            x = x+1;
                            position = position+1;
                        if (numbers==position) 
                        {
                            //System.out.println(x+" "+y);
                            break;
                        }
                }
                     if (numbers==position) 
                        {
                            //System.out.println(x+" "+y);
                            break;
                        }
            }
            
                     if (numbers==position) 
                        {
                            //System.out.println(x+" "+y);
                            break;
                        }
            
             
        }
        System.out.println(x+" "+y);
      
    }
    
}
