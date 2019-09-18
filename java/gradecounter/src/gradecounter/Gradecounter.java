    //************************************
    // PROGRAM THAT CALCULATE STUDENT GP
    //************************************
package gradecounter;

import java.util.Scanner;
public class Gradecounter {

    public static void main(String[] args) {
        // Creating the object of scanner
       Scanner input = new Scanner(System.in);
       int grades = 0, cu, tcu;
       double avg = 0, total = 0;
       String grade = "";
       String Error = "Total credit unit should not be more than 30";
            //Get input from the user
            System.out.println("Enter total credit unit");
            tcu = input.nextInt();
            if ( tcu > 30) 
            {
               System.out.println(Error);
               Runtime.getRuntime().exit(1);
            }
        // Using loop
       while(grades != -1)
       {
            System.out.println("Enter your grades points e.g [F=0,1=E,2=D,3=C,4=B,5=A] or enter -1 to terminate the program");
            grades = input.nextInt();
            if (grades == -1) 
            {
               break;
            }
            System.out.println("Enter the credit unit of the each course ");
            cu = input.nextInt();
            int cp = grades*cu;
            total += cp;
       }
            avg = total/tcu;
             if (avg >= 4.5) 
                 grade = "First class";
             if (avg >= 3.5 && avg < 4.5) 
                 grade = "Second class upper";
             if (avg >= 2.5 && avg < 3.5) 
                 grade = "Second class lower";
             if (avg >= 1.5 && avg < 2.5) 
                 grade = "Third class";
             if (avg >= 0 && avg < 1.5) 
                 grade = "No certificate";
        
        System.out.printf("%s %.2f%n%s %s%n","Your GP is:", avg, "You are on:", grade);
    }
    
}
