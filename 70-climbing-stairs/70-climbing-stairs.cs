public class Solution {
    int[] cacheArr;
    public int ClimbStairs(int n) {
        
        return GetSteps(n);
        
    }
    
    private int GetSteps(int n)
    {        
        if(cacheArr == null) //Can be used this way in case if the ClimbStairs was to be called multiple times
        {
            cacheArr = new int[n + 3];

            cacheArr[0] = 0;
            cacheArr[1] = 1;
            cacheArr[2] = 2;

            if(n == 0)
                return cacheArr[0];
            if(n == 1)
                return cacheArr[1];
            if(n == 2)
                return cacheArr[2];

            for(int step = 3; step <= n; step++)
                cacheArr[step] = cacheArr[step - 1] + cacheArr[step - 2];
        }
        return cacheArr[n];
    }
}