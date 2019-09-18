//******************************************
//PROGRAM THAT SORT SINGLE DIMENSIONL ARRAY
//******************************************
package sortarray;

public class SortArray {

    public static void main(String[] args) {
        
        int []arr = new int[]{2,1,5,4,8,3,9,20,30,15,18,1};
        for (int i = 0; i < arr.length; i++) // access each element of the array
        {
            int min = arr[i];
            for (int k = i+1; k < arr.length; k++) 
            {
             if (arr[k]<min) 
             {
                    arr[i]= arr[k];// swap the array
                    arr[k] = min;
                    min = arr[i];   
                }
            }    
        }
       //print each element of the sored array
        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i] + " ");
        }
    }
    
}
