public class Solution {
    public int ClimbStairs(int n) {
        
        var cacheArr = new int[n + 2];

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
        return cacheArr[n];
        
    }
}