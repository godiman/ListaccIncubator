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
    
     
    

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        int numbers, last_x,last_y;
        int x = 1, y = 1, position = 1;
        
        //Gets input from the user
        System.out.println("Enter anny number to check the position");
        numbers = input.nextInt();
        
            while(numbers != position )
            { 
                        last_y = y;
                        for (; y < last_y + 1;) {
                            y = y+1;
                            position = position + 1;
                            if (numbers == position) 
                                {
                                    //System.out.println(x+" "+y);
                                    break;
                                }
                        }
                        if (position >=18) 
                        {
                        last_y = y+2;
                        }else{last_y = y;}
                         
                         if (numbers == position) 
                                {
                                    //System.out.println(x+" "+y);
                                    break;
                                }
                         last_x  = x;
                         if (position>=6) 
                         {
                              for (; y < last_y+1;) 
                                {
                                    y = y+1;
                                    position = position + 1;
                                    //increment y = 2, x = 1, position = 2, last_y = 2
                                    if (numbers == position) 
                                    {
                                        //System.out.println(x+" "+y);
                                        break;
                                    }         
                                }
                                if (numbers == position) 
                                    {
                                        //System.out.println(x+" "+y);
                                        break;
                                    } 
                             // x = 1 last_x = 3, y = 3, last_y = 2, position = 9
                            // Reduce x till is 1
                            //last_x  = x;
                            for (; x > 1; ) 
                            {
                                x = x-1;
                                position = position + 1;
                                if (numbers == position) 
                                {
                                    //System.out.println(x+" "+y);
                                    break;
                                }
                            }
                            
                            if (numbers == position) 
                                {
                                    //System.out.println(x+" "+y);
                                    break;
                                }
                            
                            y = y + 1;
                            position = position + 1;
                            last_y = y;
                            if (numbers == position) 
                                {
                                    //System.out.println(x+" "+y);
                                    break;
                                }
                         }
                        //last_x = x;
                        for (; x < last_x+1;)
                        {
                            x = x + 1;
                            position = position + 1;
                            if (numbers == position) 
                                {
                                    //System.out.println(x+" "+y);
                                    break;
                                }
                        }
                       
                        //last_x = x;
                        if (numbers == position) 
                                {
                                    //System.out.println(x+" "+y);
                                    break;
                                }

                    //Reduce y till y=1, last_y = 2
                    for (; y>1; ) 
                    {
                        y = y-1;
                        position = position + 1;
                        if (position == numbers) 
                        {
                           // System.out.println(x+" "+y);
                            break;
                        }
                    }
                    
                    if (numbers == position) 
                                {
                                    //System.out.println(x+" "+y);
                                    break;
                                }
                    
                    last_x=x;
                    for (; x < last_x+1;) 
                    {
                        x = x + 1;
                        position = position + 1;

                        if (numbers == position) 
                        {

                            //System.out.println(x+" "+y);
                            break;
                        }
                    }
                    
                     if (numbers == position) 
                        {

                            //System.out.println(x+" "+y);
                            break;
                        }
                     last_y = y;
                    
                    
            }
        
        
             System.out.println(x+" "+y);
       
    }
    
}
