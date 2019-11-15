import java.util.*;

public class Leetcode_44_Solution_2 {
    public boolean isMatch(String s, String p) {
        //p = remove_duplicate_stars(p);
        //return helper(s, p);
        int pLen = p.length();
        int sLen = s.length();

        //base cases
        if (p.equals(s) || p.equals("*")) return true;
        if (p == "" || s == "") return false;

        //init all matrix except [0][0] element as False
        boolean[][] d = new boolean[pLen + 1][sLen + 1];
        d[0][0] = true;

        // DP compute
        for (int pIdx = 1; pIdx <= pLen; pIdx++) {
            // the current character in the pattern is "*"
            if (p.charAt(pIdx - 1) == '*') {
                int sIdx = 1;
                // d[p_idx - 1][s_idx - 1] is a string-pattern match
                // on the previous step, i.e. one character before.
                // Find the first idx in string with the previous math.
                while ((!d[pIdx - 1][sIdx - 1]) && (sIdx <= sLen)) sIdx++;
                // If (string) matches (pattern),
                // when (string) matches (pattern)* as well
                d[pIdx][sIdx - 1] = d[pIdx - 1][sIdx - 1];
                // If (string) matches (pattern),
                // when (string)(whatever_characters) matches (pattern)* as well
                System.out.println(sIdx + "," + pIdx + "," + (p.charAt(pIdx - 1)) + "," + (!d[pIdx - 1][sIdx - 1]) + "," + (sIdx < sLen + 1));
                while (sIdx <= sLen) d[pIdx][sIdx++] = true;

            }
            // the current character in the pattern is '?'
            else if (p.charAt(pIdx - 1) == '?') {
                System.out.println(pIdx + "," + (p.charAt(pIdx - 1)));
                for (int sIdx = 1; sIdx <= sLen; sIdx++)
                    d[pIdx][sIdx] = d[pIdx - 1][sIdx - 1];
            }
            // the current character in the pattern is not '*' or '?'
            else {
                System.out.println(pIdx + "," + (p.charAt(pIdx - 1)));
                for (int sIdx = 1; sIdx <= sLen; sIdx++) {
                    // Match is possible if there is a previous match
                    // and current characters are the same
                    d[pIdx][sIdx] = d[pIdx - 1][sIdx - 1] &&
                        (p.charAt(pIdx - 1) == s.charAt(sIdx - 1));
                }
            }
        }
        for (int pIdx = pLen; pIdx >= 0; pIdx--) {
        	System.out.println(Arrays.toString(d[pIdx]));
        }
        return d[pLen][sLen];
    }

    public static void main(String[] args) {
        String s = "ghixjk", p = "*gh*j?";
        Programs myObj = new Programs();
        System.out.println(myObj.isMatch(s, p));
    }
}