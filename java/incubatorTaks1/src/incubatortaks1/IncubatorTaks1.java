/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package incubatortaks1;

import java.util.Scanner;

/**
 *
 * @author Gooditech
 */
public class IncubatorTaks1 {
    
    public  void addnum(int firstArray[],int secondArray[])
    {
        // Declaration of variables
         int sum=0;
            int i=0;
            int k = 0, j = 0;
            boolean found = false;
            
             // Pick the first element of the the first array
               for ( i = 0; i < firstArray.length; ) 
               {           
                   //Pick the second element of the first array
                   for ( j = i+1; j < firstArray.length; j++) 
                   {      
                       found = false;
                       // Add the first and the second element of the first array
                       sum = firstArray[i]+firstArray[j]; 
                       //System.out.println(sum);
                       
                       //Iterates through the second array
                        for (; k < secondArray.length; k++) 
                        {
                            //Checks if the sum of the number in the first 
                            //array is equal to the number in the second array
                          if (sum == secondArray[k]) 
                           {
                               //Display the sum 
                               System.out.println(firstArray[i]+"+"+firstArray[j]+" "+"in the first array = "+" "+sum+" "+"in the second array"); 
                               
                               found = true;
                               //breaks the loop if number is found in the second array
                               
                           }
                          
                            if (found!=false) {
                                break;
                            }
                           
                       }
                        //breaks the loop if number is found in the second array
                       
                       if (found!=false) {
                                
                            }
                      i++;//Increment I if number is not found in the first iteration
                      
                   }
                   //breaks the loop if number is found in the second array
                        break; 
                            
                }//ends first for loop
              
    
    }

    /**
     * @param args the command line arguments
     */
        public static void main(String[] args) {
            // object of the class IncubatorTaks1
            IncubatorTaks1 test = new IncubatorTaks1();
            
            int numbers[] = {2,2,3,4,5,6,8,9,10};
            int sumNum[] = {2,4,5,7,9,10,11,12,14};
            test.addnum(numbers, sumNum);
        
        }
    
}
