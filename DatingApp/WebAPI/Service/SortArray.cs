namespace WebAPI.Service
{
    public class SortArray
    {
       public int[] sortIt()
        {
            int []array = new int []{6,3,8,2,0,7,8};
            for (int i = 0; i < array.Length; i++)
            {
                int least = array[1];
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i]<least)
                    {
                        array[i] = array[j];
                        array[j] = least;
                    }
                    least = array[i];
                }
            }
          return  array;
        }
    }
}