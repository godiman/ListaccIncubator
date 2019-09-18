
package atmproject;

/**
 *
 * @author Gooditech
 */
public class AtmAccount {
    
    //Variables declaration
    private String name;   
    private double accBalance;
    private double deposit;
    private double withdraw;
    private double transfer;
    
    
    
    private String pin;
    
    // Constructor with parameter
    public AtmAccount( String pin, double accBalance, String name ){
        if (pin.compareTo("1330")==0 || pin.compareTo("1234")==0) {
            this.pin = pin;
        }
        
        this.accBalance = accBalance;
        this.name = name;
    
    }
    
    
    // method that set the first name
    public void setFullName(String name){
        this.name = name;
    
    }
    
    public String getFullName(){
        return name;
    }
    
    
    
    
    // method that set the pin 
    public void setPin(String pin){
         this.pin = pin;
   
    }
    
    public String getPin(){
        return pin;
    }//pin 1 ends here
   
    //method that display the balance
    public double displayBalance(){
    
        return accBalance;
    }
    
    //method that display the balance
   
    
       
    
    public void setDeposit(double deposit){
        if (deposit>0) {
            accBalance  = deposit + accBalance;
             this.deposit = deposit;
        }
       
    }
    
    public double getDeposit(){
        return deposit;
    }
    
    
    
    public void setWithdrawal( double withdraw){
        if ((withdraw>0)) {
           accBalance = accBalance - withdraw;
            this.withdraw = withdraw;
        }
    }
       
    
   
    public double getWithdrawal(){
    
    return withdraw;
    }
    
     public void setTransfer( double transfer){
        if ((transfer>0)) {
           accBalance = accBalance - transfer;
            this.transfer = transfer;
        }
    }
       
    
   
    public double getTransfer(){
    
    return transfer;
    }
    



}
