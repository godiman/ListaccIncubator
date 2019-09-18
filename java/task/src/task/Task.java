
package task;

import java.util.Scanner;

public class Task {
// Method that calculate the fibonacci of a given number
    public int fib(int num){
        if (num==0) {
            return 0;
        }
        else if(num==1)
        {
            return 1;
        }
        else {
            return fib (num-1)+ fib(num-2);
        }
    }
    
    public static void main(String[] args) 
    {
        Task task = new Task();
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter any number");
        int num = scan.nextInt();
        System.out.print("Fib" + " "+ num + " "+ "=" + " ");
        for (int ax = 0; ax < num; ax++) {
        System.out.print( task.fib(ax)+ " ");
        }
        
        
        
        
        
       /*  int [] scores = new int [] {10, 50, 60, 10, 30, 35, 60, 75, 80,75,90,30};  
        //Array fr will store frequencies of element  
        int [] times = new int [scores.length];  
        int checked = -1;  
        for(int i = 0; i < scores.length; i++)
        {  
            int count = 1;  
            for(int j = 1+i; j < scores.length; j++)
            {  
                if(scores[i] == scores[j])
                {  
                    count++;  
                    //To avoid counting same element again  
                    times[j] = checked;  
                }  
            }  
            if(times[i] != checked)  
                times[i] = count;  
        }  
  
            System.out.println("Scores          Frequency");
        for(int i = 0; i < times.length; i++){  
            if(times[i] != checked)  
                System.out.printf("%d               %d%n", scores[i], times[i]);  
        } 
        
        System.out.println("");
        
        System.out.println("");*/
     
    }
    
}
