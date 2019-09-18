package banktest;

import java.util.Scanner;

public class BankTest {

    public static void main(String[] args) {
        account user1 = new account("John Boo" , 700);
        account user2 = new account("Ben Jackson" , 400) ;
        
        System.out.printf("%s balance: $%.2f%n", user1.getName(), user1.getBalance());
        System.out.printf("%s balnce: $%.2f%n%n", user2.getName(), user2.getBalance());       
        Scanner input =  new Scanner(System.in);
        
        System.out.printf("Enter user1 deposit amount:%n");
        double depositAmount = input.nextDouble();
        System.out.printf("%.2f added to your account%n ", depositAmount);
        user1.deposite(depositAmount);
         
        System.out.printf("%s balance is:$%.2f %n", user1.getName(), user1.getBalance());        
        System.out.println("");
        
        System.out.printf("Enter user2 deposit amount%n");
        depositAmount = input.nextDouble();
        System.out.printf("%.2f added to your account%n", depositAmount);
        user2.deposite(depositAmount);
        
        
        System.out.printf("%s balance is: $%.2f%n", user2.getName(), user2.getBalance());
        System.out.println("");
        
        // user to withdraw money from account       
        System.out.printf("Enter the withdrawal amount for user1:%n");
        double withdraw = input.nextDouble();       
        user1.withdrawal(withdraw);       
        System.out.printf("%s new balance is: %.2f" ,user1.getName(), user1.getBalance());    
    }
    
}
