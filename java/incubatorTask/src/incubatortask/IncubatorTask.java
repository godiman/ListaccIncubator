/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package incubatortask;

import java.util.Scanner;

/**
 *
 * @author Gooditech
 */
public class IncubatorTask {
    
     //Scanner object
        static Scanner input = new Scanner(System.in);
        
        //variables declaration
      static int x=1,y=1,last_x,last_y ;
      static int position = 1, ant;
      static boolean found = false;
       
       public static void f_Up()
       {
           //for the first up movement
                y=+1;               
                position=+1;
                last_y=y;
        
       }
       
       public static void s_Up()
       {
           
           for (; y <=  last_y; y++) {
               position=+1;
               if (position == ant) {
                   break;
               }
           }
       }
       
       public static void down()
       {
           last_y = y;
           for (; y > 1; y--) 
           {
              position=+1;
               if (position == ant) {
                   break;
               }
           }
       }
       
       public static void right()
       {
           x = x+1;
           position=+1;
           last_x = x;
          
       }
       
       public static void s_right()
       {
           last_x = x;
           for (; x <= last_x; x++) {
               position=+1;
               
           }
       }
       
        public static void left()
        {
           
           last_x = x;
           for (; x > 1; x--) 
           {
              position=+1;
               if (position == ant) {
                   break;
               }
           }
        
        }
    

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
      
       //Gets input from the user
        System.out.println("Enter anny number to check the position");
        ant = input.nextInt();
      
        while((position!= ant) && (ant!=0 ))
        
        {
            
             //ant = input.nextInt();
             
           f_Up();
            if (position == ant) {
                break;
            }
            right();
            if (position == ant) {
                break;
            }
            down();
            if (position == ant) {
                break;
            }
            s_right();
            if (position == ant) {
                break;
            }
            s_Up();
            if (position == ant) {
                break;
            }
            left();
            
        }
        
        System.out.println(x+" "+y);
       
    }
    
}
