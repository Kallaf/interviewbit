class Solution {
    public List<int> repeatedNumber(List<int> A) {
        long diff=0,diff2=0;
        for(int i=0;i<A.Count;i++)
        {
            long j = i+1;
            long k = A[i];
            diff += k - j;
            diff2 += (k*k) - (j*j);
        }
        List<int> ans = new List<int>(){0,0};
        ans[0] = (int) ((diff + diff2/diff) / 2);
        ans[1] = ans[0] - (int)diff;
        return ans;
    }
}
