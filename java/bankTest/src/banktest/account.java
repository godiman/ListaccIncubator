// class account.java

package banktest;

public class account {
    private String name;
    private double balance;
    
    //constructor
    public account(String name, double balance){
        this.name = name;       
        // Validating the bank 
        if( balance > 0.0){
            this.balance = balance;
    }
}
     public String getName(){
        return name;   
    }
    //method that add the deposit amount   
    public void deposite(double depositAmount){
    
        if(depositAmount>0.0){
            balance = balance+depositAmount;
        }
    }
    
    public void withdrawal(double withdrawalAmount){
        if(withdrawalAmount >= balance){
            System.out.println("Withdrawal amount exceeded the account's balance ");
        }
        else{
            System.out.printf( "%.2f has been withdrawn from your account%n", withdrawalAmount);
            balance = balance - withdrawalAmount;
        }
    }   
    // Method to return the user info 
    public double getBalance(){
        return balance;
    } 
}
