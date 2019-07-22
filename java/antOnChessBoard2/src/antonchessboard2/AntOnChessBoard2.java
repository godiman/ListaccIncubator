        
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
       int numbers=0;
       boolean found = false; 
       
       //Get input from the user
        System.out.println("Enter any number to check the position");
            numbers = input.nextInt();
        
        while((numbers!=position ) && (numbers> 0) ){
            
            numbers = input.nextInt();
            //increment y by 1
            y=y+1;
            position = position+1;
            last_y = y;
                 if (numbers==position) 
                {
                  
                    break;
                }
                 
                 
                //increment x by 1
            x = x+1;
            position = position+1;
            last_x = x;
                if (numbers==position) 
                {
                    System.out.println(x+" "+y);
                    break;
                }
            
            
            
            //Reduce y till y=1
            for (; y>1; y--) 
            {
                position = position+1;
                        if (position==numbers) 
                    {
                        System.out.println(x+" "+y);
                        break;
                    }
            }
            
                 if (numbers==position) 
                {
                    break;
                }
            
            //Increment the last value of x
            x = last_x;
            x = x+1;
            position= position+1;
            
                 if (numbers==position) 
                {
                    break;
                }
            
           
            y = last_y;
            y = y+1;
            position = position+1;
                if (numbers==position) 
                {
                    break;
                }
                
                // Reduce x till is 1
            for (; x >1; x--) 
            {
                position = position+1;
                if (numbers==position) 
                {
                    break;
                }
            }
            
             
        }
        
      
    }
    
}
