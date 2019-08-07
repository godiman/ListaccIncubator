        
            // Ant on chess board

package antonchessboard2;

import java.util.Scanner;

/**
 *
 * @author Gooditech
 */
public class AntOnChessBoard2 {
    
     static Scanner input = new Scanner(System.in);
       
       //Declaration of variables
      static int position = 1;
      static int x = 1, y = 1;
      static int last_x,last_y = y;
      static int numbers;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        //scanner object
      
       
       
       //Get input from the user
        System.out.println("Enter any number to check the position");
         
        
        while((numbers = input.nextInt())!= 0 )
        {     
           
            up();
            if (numbers == position) {
                break;
            }
        }
        
       // System.out.println(x + " " + y);
    }
    
    public static void up(){
        while(y < last_y + 1)
        {
            y += 1;
            position += 1;
            if (numbers == position) {
                break;
            }
        }
        last_y = y;
         String.format("%d  %d", x , y);
    }
    
}
